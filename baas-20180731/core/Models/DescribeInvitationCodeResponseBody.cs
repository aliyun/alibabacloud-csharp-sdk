// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeInvitationCodeResponseBody : TeaModel {
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInvitationCodeResponseBodyResult Result { get; set; }
        public class DescribeInvitationCodeResponseBodyResult : TeaModel {
            [NameInMap("Accepted")]
            [Validation(Required=false)]
            public bool? Accepted { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ConsortiumId")]
            [Validation(Required=false)]
            public string ConsortiumId { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// Id
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("SendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            [NameInMap("SenderBid")]
            [Validation(Required=false)]
            public string SenderBid { get; set; }

            [NameInMap("SenderId")]
            [Validation(Required=false)]
            public long? SenderId { get; set; }

            [NameInMap("SenderName")]
            [Validation(Required=false)]
            public string SenderName { get; set; }

            /// <summary>
            /// URL
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
