// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplatePolicyResponseBody : TeaModel {
        /// <summary>
        /// The information about the policy.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GenerateTemplatePolicyResponseBodyPolicy Policy { get; set; }
        public class GenerateTemplatePolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// The statements that are contained in the policy.
            /// </summary>
            [NameInMap("Statement")]
            [Validation(Required=false)]
            public List<GenerateTemplatePolicyResponseBodyPolicyStatement> Statement { get; set; }
            public class GenerateTemplatePolicyResponseBodyPolicyStatement : TeaModel {
                /// <summary>
                /// The operations that are performed on the specified resource.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public List<string> Action { get; set; }

                /// <summary>
                /// The effect of the statement. Valid values:
                /// 
                /// *   Allow
                /// *   Deny
                /// </summary>
                [NameInMap("Effect")]
                [Validation(Required=false)]
                public string Effect { get; set; }

                /// <summary>
                /// The object that the statement covers. An asterisk (\*) indicates all resources.
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            /// <summary>
            /// The version number.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
