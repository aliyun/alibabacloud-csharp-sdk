// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FaceGroup : TeaModel {
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("group_cover_face_boundary")]
        [Validation(Required=false)]
        public FaceGroupGroupCoverFaceBoundary GroupCoverFaceBoundary { get; set; }
        public class FaceGroupGroupCoverFaceBoundary : TeaModel {
            [NameInMap("height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("left")]
            [Validation(Required=false)]
            public int? Left { get; set; }

            [NameInMap("top")]
            [Validation(Required=false)]
            public int? Top { get; set; }

            [NameInMap("width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        [NameInMap("group_cover_file_id")]
        [Validation(Required=false)]
        public string GroupCoverFileId { get; set; }

        [NameInMap("group_cover_height")]
        [Validation(Required=false)]
        public long? GroupCoverHeight { get; set; }

        [NameInMap("group_cover_url")]
        [Validation(Required=false)]
        public string GroupCoverUrl { get; set; }

        [NameInMap("group_cover_width")]
        [Validation(Required=false)]
        public long? GroupCoverWidth { get; set; }

        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("image_count")]
        [Validation(Required=false)]
        public long? ImageCount { get; set; }

        [NameInMap("remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
