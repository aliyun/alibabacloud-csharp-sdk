// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RestoreMediaResponseBody : TeaModel {
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public RestoreMediaResponseBodyForbiddenList ForbiddenList { get; set; }
        public class RestoreMediaResponseBodyForbiddenList : TeaModel {
            [NameInMap("MediaForbiddenReasonDTO")]
            [Validation(Required=false)]
            public List<RestoreMediaResponseBodyForbiddenListMediaForbiddenReasonDTO> MediaForbiddenReasonDTO { get; set; }
            public class RestoreMediaResponseBodyForbiddenListMediaForbiddenReasonDTO : TeaModel {
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
        public RestoreMediaResponseBodyIgnoredList IgnoredList { get; set; }
        public class RestoreMediaResponseBodyIgnoredList : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public List<string> MediaId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
