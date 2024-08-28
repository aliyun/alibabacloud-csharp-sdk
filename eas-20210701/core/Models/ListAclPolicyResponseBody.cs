// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListAclPolicyResponseBody : TeaModel {
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("InternetAclPolicyList")]
        [Validation(Required=false)]
        public List<ListAclPolicyResponseBodyInternetAclPolicyList> InternetAclPolicyList { get; set; }
        public class ListAclPolicyResponseBodyInternetAclPolicyList : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

        [NameInMap("IntranetVpcAclPolicyList")]
        [Validation(Required=false)]
        public List<ListAclPolicyResponseBodyIntranetVpcAclPolicyList> IntranetVpcAclPolicyList { get; set; }
        public class ListAclPolicyResponseBodyIntranetVpcAclPolicyList : TeaModel {
            [NameInMap("IntranetAclPolicyList")]
            [Validation(Required=false)]
            public List<ListAclPolicyResponseBodyIntranetVpcAclPolicyListIntranetAclPolicyList> IntranetAclPolicyList { get; set; }
            public class ListAclPolicyResponseBodyIntranetVpcAclPolicyListIntranetAclPolicyList : TeaModel {
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("Entry")]
                [Validation(Required=false)]
                public string Entry { get; set; }

            }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
