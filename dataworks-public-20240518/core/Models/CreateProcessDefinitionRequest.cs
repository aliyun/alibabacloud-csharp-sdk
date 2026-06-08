// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateProcessDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public List<CreateProcessDefinitionRequestApprovalNodes> ApprovalNodes { get; set; }
        public class CreateProcessDefinitionRequestApprovalNodes : TeaModel {
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
            /// <para>default-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public List<CreateProcessDefinitionRequestNotificationServices> NotificationServices { get; set; }
        public class CreateProcessDefinitionRequestNotificationServices : TeaModel {
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<CreateProcessDefinitionRequestRuleConditions> RuleConditions { get; set; }
        public class CreateProcessDefinitionRequestRuleConditions : TeaModel {
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
        /// <para>Extension</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
