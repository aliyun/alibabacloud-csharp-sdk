// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetAssociationStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAssociationStatusResponseBodyData Data { get; set; }
        public class GetAssociationStatusResponseBodyData : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetAssociationStatusResponseBodyDataResult> Result { get; set; }
            public class GetAssociationStatusResponseBodyDataResult : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("InviteStatusList")]
                [Validation(Required=false)]
                public GetAssociationStatusResponseBodyDataResultInviteStatusList InviteStatusList { get; set; }
                public class GetAssociationStatusResponseBodyDataResultInviteStatusList : TeaModel {
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

                    [NameInMap("ValidTime")]
                    [Validation(Required=false)]
                    public string ValidTime { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
