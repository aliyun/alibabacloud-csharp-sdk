// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetInviteStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInviteStatusResponseBodyData Data { get; set; }
        public class GetInviteStatusResponseBodyData : TeaModel {
            [NameInMap("InviteStatus")]
            [Validation(Required=false)]
            public List<GetInviteStatusResponseBodyDataInviteStatus> InviteStatus { get; set; }
            public class GetInviteStatusResponseBodyDataInviteStatus : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("InviteStatusList")]
                [Validation(Required=false)]
                public GetInviteStatusResponseBodyDataInviteStatusInviteStatusList InviteStatusList { get; set; }
                public class GetInviteStatusResponseBodyDataInviteStatusInviteStatusList : TeaModel {
                    [NameInMap("AssociationSuccessTime")]
                    [Validation(Required=false)]
                    public string AssociationSuccessTime { get; set; }

                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public long? Cid { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("SubAccountType")]
                    [Validation(Required=false)]
                    public string SubAccountType { get; set; }

                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
