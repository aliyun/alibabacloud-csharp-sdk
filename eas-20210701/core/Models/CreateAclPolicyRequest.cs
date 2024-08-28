// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateAclPolicyRequest : TeaModel {
        [NameInMap("AclPolicyList")]
        [Validation(Required=false)]
        public List<CreateAclPolicyRequestAclPolicyList> AclPolicyList { get; set; }
        public class CreateAclPolicyRequestAclPolicyList : TeaModel {
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

}
