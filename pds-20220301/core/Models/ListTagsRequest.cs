// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListTagsRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        public string ImageThumbnailProcess { get; set; }

        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        public string VideoThumbnailProcess { get; set; }

    }

}
