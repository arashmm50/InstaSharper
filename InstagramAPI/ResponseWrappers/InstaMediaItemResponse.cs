﻿using InstagramAPI.Classes.Models;
using Newtonsoft.Json;

namespace InstagramAPI.ResponseWrappers
{
    public class InstaMediaItemResponse
    {
        [JsonProperty("taken_at")]
        public string TakenAtUnixLike { get; set; }

        [JsonProperty("pk")]
        public string Pk { get; set; }

        [JsonProperty("id")]
        public string InstaIdentifier { get; set; }

        [JsonProperty("device_timestamp")]
        public string DeviceTimeStapUnixLike { get; set; }

        [JsonProperty("media_type")]
        public InstaMediaType MediaType { get; set; }


        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("client_cache_key")]
        public string ClientCacheKey { get; set; }

        [JsonProperty("filter_type")]
        public string FilterType { get; set; }

        [JsonProperty("image_versions2")]
        public InstaImageCandidatesResponse Images { get; set; }

        [JsonProperty("original_width")]
        public int Width { get; set; }

        [JsonProperty("original_height")]
        public string Height { get; set; }

        [JsonProperty("user")]
        public InstaUserResponse User { get; set; }

        [JsonProperty("organic_tracking_token")]
        public string TrakingToken { get; set; }

        [JsonProperty("like_count")]
        public int LikesCount { get; set; }

        [JsonProperty("next_max_id")]
        public string NextMaxId { get; set; }

        [JsonProperty("caption")]
        public InstaCaptionResponse Caption { get; set; }

        [JsonProperty("comment_count")]
        public string CommentsCount { get; set; }

        [JsonProperty("photo_of_you")]
        public bool PhotoOfYou { get; set; }

        [JsonProperty("has_liked")]
        public bool HasLiked { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }
}