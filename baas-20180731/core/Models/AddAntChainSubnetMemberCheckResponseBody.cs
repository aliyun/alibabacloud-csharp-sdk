// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class AddAntChainSubnetMemberCheckResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddAntChainSubnetMemberCheckResponseBodyResult Result { get; set; }
        public class AddAntChainSubnetMemberCheckResponseBodyResult : TeaModel {
            [NameInMap("ConsortiumMemberInfoList")]
            [Validation(Required=false)]
            public List<AddAntChainSubnetMemberCheckResponseBodyResultConsortiumMemberInfoList> ConsortiumMemberInfoList { get; set; }
            public class AddAntChainSubnetMemberCheckResponseBodyResultConsortiumMemberInfoList : TeaModel {
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

            }

        }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
