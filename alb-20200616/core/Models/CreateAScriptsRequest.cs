// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateAScriptsRequest : TeaModel {
        /// <summary>
        /// The information about the AScript rules.
        /// </summary>
        [NameInMap("AScripts")]
        [Validation(Required=false)]
        public List<CreateAScriptsRequestAScripts> AScripts { get; set; }
        public class CreateAScriptsRequestAScripts : TeaModel {
            /// <summary>
            /// The name of the AScript rule.
            /// 
            /// The name must be 2 to 128 character in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AScriptName")]
            [Validation(Required=false)]
            public string AScriptName { get; set; }

            /// <summary>
            /// Specifies whether to enable the AScript rule. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// Specifies whether to enable the extended attributes of the AScript rule. Valid values:
            /// 
            /// *   true
            /// *   false (default)
            /// </summary>
            [NameInMap("ExtAttributeEnabled")]
            [Validation(Required=false)]
            public bool? ExtAttributeEnabled { get; set; }

            /// <summary>
            /// The extended attributes.
            /// </summary>
            [NameInMap("ExtAttributes")]
            [Validation(Required=false)]
            public List<CreateAScriptsRequestAScriptsExtAttributes> ExtAttributes { get; set; }
            public class CreateAScriptsRequestAScriptsExtAttributes : TeaModel {
                /// <summary>
                /// The attribute name.
                /// 
                /// Set the value to **EsDebug**, which specifies that if requests carry the _es_dbg parameter and the value is the specified key, the debugging header is enabled to output the execution result.
                /// </summary>
                [NameInMap("AttributeKey")]
                [Validation(Required=false)]
                public string AttributeKey { get; set; }

                /// <summary>
                /// The attribute value, which must be 1 to 128 characters in length, and can contain letters or digits.
                /// </summary>
                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public string AttributeValue { get; set; }

            }

            /// <summary>
            /// The content of the AScript rule.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The listener ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
