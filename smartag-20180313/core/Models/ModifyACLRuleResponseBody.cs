// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyACLRuleResponseBody : TeaModel {
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AcrId")]
        [Validation(Required=false)]
        public string AcrId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public ModifyACLRuleResponseBodyDpiGroupIds DpiGroupIds { get; set; }
        public class ModifyACLRuleResponseBodyDpiGroupIds : TeaModel {
            [NameInMap("DpiGroupId")]
            [Validation(Required=false)]
            public List<string> DpiGroupId { get; set; }
        };

        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public ModifyACLRuleResponseBodyDpiSignatureIds DpiSignatureIds { get; set; }
        public class ModifyACLRuleResponseBodyDpiSignatureIds : TeaModel {
            [NameInMap("DpiSignatureId")]
            [Validation(Required=false)]
            public List<string> DpiSignatureId { get; set; }
        };

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

    }

}
