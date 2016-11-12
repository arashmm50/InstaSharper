﻿using System;
using InstagramAPI.Classes.Models;
using InstagramAPI.Helpers;
using InstagramAPI.ResponseWrappers;

namespace InstagramAPI.Converters
{
    public class InstaMediaConverter : IObjectConverter<InstaMedia, InstaMediaItemResponse>
    {
        public InstaMediaItemResponse SourceObject { get; set; }

        public InstaMedia Convert()
        {
            if (SourceObject == null) throw new ArgumentNullException($"Source object");
            var media = new InstaMedia
            {
                InstaIdentifier = SourceObject.InstaIdentifier,
                Code = SourceObject.Code,
                Pk = SourceObject.Pk,
                ClientCacheKey = SourceObject.ClientCacheKey,
                CommentsCount = SourceObject.CommentsCount,
                DeviceTimeStap = DateTimeHelper.UnixTimestampToDateTime(SourceObject.DeviceTimeStapUnixLike),
                HasLiked = SourceObject.HasLiked,
                PhotoOfYou = SourceObject.PhotoOfYou,
                TrakingToken = SourceObject.TrakingToken,
                TakenAt = DateTimeHelper.UnixTimestampToDateTime(SourceObject.TakenAtUnixLike),
                Height = SourceObject.Height,
                LikesCount = SourceObject.LikesCount,
                MediaType = SourceObject.MediaType,
                FilterType = SourceObject.FilterType,
                Width = SourceObject.Width
            };
            if (SourceObject.User != null) media.User = ConvertersFabric.GetUserConverter(SourceObject.User).Convert();
            if (SourceObject.Caption != null) media.Caption = ConvertersFabric.GetCaptionConverter(SourceObject.Caption).Convert();
            if (SourceObject.NextMaxId != null) media.NextMaxId = SourceObject.NextMaxId;
            if (SourceObject.Images?.Candidates == null) return media;
            foreach (var image in SourceObject.Images.Candidates) media.Images.Add(new Image(image.Url, image.Width, image.Height));
            return media;
        }
    }
}