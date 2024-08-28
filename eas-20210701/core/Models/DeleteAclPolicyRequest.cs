// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteAclPolicyRequest : TeaModel {
        [NameInMap("AclPolicyList")]
        [Validation(Required=false)]
        public List<DeleteAclPolicyRequestAclPolicyList> AclPolicyList { get; set; }
        public class DeleteAclPolicyRequestAclPolicyList : TeaModel {
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
