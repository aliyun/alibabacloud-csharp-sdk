// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchStoriesRequest : TeaModel {
        [NameInMap("cover_image_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string CoverImageThumbnailProcess { get; set; }

        [NameInMap("cover_video_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string CoverVideoThumbnailProcess { get; set; }

        [NameInMap("create_time_range")]
        [Validation(Required=false)]
        public SearchStoriesRequestCreateTimeRange CreateTimeRange { get; set; }
        public class SearchStoriesRequestCreateTimeRange : TeaModel {
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("custom_labels")]
        [Validation(Required=false)]
        [Obsolete]
        public string CustomLabels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("face_group_ids")]
        [Validation(Required=false)]
        public List<string> FaceGroupIds { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("story_end_time_range")]
        [Validation(Required=false)]
        public SearchStoriesRequestStoryEndTimeRange StoryEndTimeRange { get; set; }
        public class SearchStoriesRequestStoryEndTimeRange : TeaModel {
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        [NameInMap("story_name")]
        [Validation(Required=false)]
        public string StoryName { get; set; }

        [NameInMap("story_start_time_range")]
        [Validation(Required=false)]
        public SearchStoriesRequestStoryStartTimeRange StoryStartTimeRange { get; set; }
        public class SearchStoriesRequestStoryStartTimeRange : TeaModel {
            [NameInMap("end")]
            [Validation(Required=false)]
            public string End { get; set; }

            [NameInMap("start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("story_type")]
        [Validation(Required=false)]
        public string StoryType { get; set; }

        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        [Obsolete]
        public long? UrlExpireSec { get; set; }

        [NameInMap("with_empty_stories")]
        [Validation(Required=false)]
        public bool? WithEmptyStories { get; set; }

    }

}
