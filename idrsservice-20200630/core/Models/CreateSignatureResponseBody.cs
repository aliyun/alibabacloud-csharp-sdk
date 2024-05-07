// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class CreateSignatureResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSignatureResponseBodyData Data { get; set; }
        public class CreateSignatureResponseBodyData : TeaModel {
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("RtcAppId")]
            [Validation(Required=false)]
            public string RtcAppId { get; set; }

            [NameInMap("RtcBizName")]
            [Validation(Required=false)]
            public string RtcBizName { get; set; }

            [NameInMap("RtcSign")]
            [Validation(Required=false)]
            public string RtcSign { get; set; }

            [NameInMap("RtcWorkspaceId")]
            [Validation(Required=false)]
            public string RtcWorkspaceId { get; set; }

        }

        [NameInMap("Errors")]
        [Validation(Required=false)]
        public List<CreateSignatureResponseBodyErrors> Errors { get; set; }
        public class CreateSignatureResponseBodyErrors : TeaModel {
            [NameInMap("Field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
