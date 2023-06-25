// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FaceThumbnail : TeaModel {
        [NameInMap("face_group_id")]
        [Validation(Required=false)]
        public string FaceGroupId { get; set; }

        [NameInMap("face_id")]
        [Validation(Required=false)]
        public string FaceId { get; set; }

        [NameInMap("face_thumbnail")]
        [Validation(Required=false)]
        [Obsolete]
        public string FaceThumbnail_ { get; set; }

    }

}
