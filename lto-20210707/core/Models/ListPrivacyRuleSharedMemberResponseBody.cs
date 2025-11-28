// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Lto20210707.Models
{
    public class ListPrivacyRuleSharedMemberResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPrivacyRuleSharedMemberResponseBodyData> Data { get; set; }
        public class ListPrivacyRuleSharedMemberResponseBodyData : TeaModel {
            [NameInMap("BizChainId")]
            [Validation(Required=false)]
            public string BizChainId { get; set; }

            [NameInMap("BizChainName")]
            [Validation(Required=false)]
            public string BizChainName { get; set; }

            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<ListPrivacyRuleSharedMemberResponseBodyDataMemberList> MemberList { get; set; }
            public class ListPrivacyRuleSharedMemberResponseBodyDataMemberList : TeaModel {
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("Shared")]
                [Validation(Required=false)]
                public string Shared { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
