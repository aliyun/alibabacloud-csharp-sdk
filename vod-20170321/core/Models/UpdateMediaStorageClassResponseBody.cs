// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaStorageClassResponseBody : TeaModel {
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public UpdateMediaStorageClassResponseBodyForbiddenList ForbiddenList { get; set; }
        public class UpdateMediaStorageClassResponseBodyForbiddenList : TeaModel {
            [NameInMap("MediaForbiddenReasonDTO")]
            [Validation(Required=false)]
            public List<UpdateMediaStorageClassResponseBodyForbiddenListMediaForbiddenReasonDTO> MediaForbiddenReasonDTO { get; set; }
            public class UpdateMediaStorageClassResponseBodyForbiddenListMediaForbiddenReasonDTO : TeaModel {
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

        }

        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public UpdateMediaStorageClassResponseBodyIgnoredList IgnoredList { get; set; }
        public class UpdateMediaStorageClassResponseBodyIgnoredList : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public List<string> MediaId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
