// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateFacegroupRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("group_cover_face_id")]
        [Validation(Required=false)]
        public string GroupCoverFaceId { get; set; }

        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
