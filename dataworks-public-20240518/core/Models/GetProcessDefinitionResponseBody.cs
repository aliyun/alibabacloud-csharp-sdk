// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProcessDefinitionResponseBody : TeaModel {
        [NameInMap("ProcessDefinition")]
        [Validation(Required=false)]
        public GetProcessDefinitionResponseBodyProcessDefinition ProcessDefinition { get; set; }
        public class GetProcessDefinitionResponseBodyProcessDefinition : TeaModel {
            [NameInMap("ApprovalNodes")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionApprovalNodes> ApprovalNodes { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionApprovalNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TableOrProjectAdministrator</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                [NameInMap("Assignees")]
                [Validation(Required=false)]
                public List<string> Assignees { get; set; }

                [NameInMap("ExtensionProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtensionProperties { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7a809b6a-2a62-4c6c-9c23-c2a145e3877d</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default-name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>210001039767</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsSystem")]
            [Validation(Required=false)]
            public bool? IsSystem { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NotificationServices")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionNotificationServices> NotificationServices { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionNotificationServices : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>DingRobot</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
                /// </summary>
                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

            }

            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionRuleConditions> RuleConditions { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionRuleConditions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;))</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Deployment</para>
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odpsProject</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Table</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc5df3a17***903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
