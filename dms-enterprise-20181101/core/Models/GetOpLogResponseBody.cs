// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOpLogResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("OpLogDetails")]
        [Validation(Required=false)]
        public GetOpLogResponseBodyOpLogDetails OpLogDetails { get; set; }
        public class GetOpLogResponseBodyOpLogDetails : TeaModel {
            [NameInMap("OpLogDetail")]
            [Validation(Required=false)]
            public List<GetOpLogResponseBodyOpLogDetailsOpLogDetail> OpLogDetail { get; set; }
            public class GetOpLogResponseBodyOpLogDetailsOpLogDetail : TeaModel {
                public string Database { get; set; }
                public string Module { get; set; }
                public string OpContent { get; set; }
                public string OpTime { get; set; }
                public long? OrderId { get; set; }
                public string UserId { get; set; }
                public string UserNick { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
