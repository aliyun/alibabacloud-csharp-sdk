// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplatePolicyResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=true)]
        public GenerateTemplatePolicyResponsePolicy Policy { get; set; }
        public class GenerateTemplatePolicyResponsePolicy : TeaModel {
            [NameInMap("Version")]
            [Validation(Required=true)]
            public string Version { get; set; }
            [NameInMap("Statement")]
            [Validation(Required=true)]
            public List<GenerateTemplatePolicyResponsePolicyStatement> Statement { get; set; }
            public class GenerateTemplatePolicyResponsePolicyStatement : TeaModel {
                public string Resource { get; set; }
                public string Effect { get; set; }
                public List<string> Action { get; set; }
            }
        };

    }

}
