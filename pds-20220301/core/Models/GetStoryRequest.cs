// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetStoryRequest : TeaModel {
        [NameInMap("cover_image_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string CoverImageThumbnailProcess { get; set; }

        [NameInMap("cover_video_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string CoverVideoThumbnailProcess { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageThumbnailProcess { get; set; }

        [NameInMap("image_url_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string ImageUrlProcess { get; set; }

        [NameInMap("story_id")]
        [Validation(Required=false)]
        public string StoryId { get; set; }

        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        [Obsolete]
        public long? UrlExpireSec { get; set; }

        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        [Obsolete]
        public string VideoThumbnailProcess { get; set; }

    }

}
