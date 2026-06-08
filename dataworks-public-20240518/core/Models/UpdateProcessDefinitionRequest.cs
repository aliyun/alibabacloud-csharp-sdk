// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateProcessDefinitionRequest : TeaModel {
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionRequestApprovalNodes> ApprovalNodes { get; set; }
        public class UpdateProcessDefinitionRequestApprovalNodes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>TableOrProjectAdministrator</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DataWorksProjectMember</para>
            /// </summary>
            [NameInMap("Assignees")]
            [Validation(Required=false)]
            public string Assignees { get; set; }

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
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177554881536128</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionRequestNotificationServices> NotificationServices { get; set; }
        public class UpdateProcessDefinitionRequestNotificationServices : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Mail</para>
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
        public List<UpdateProcessDefinitionRequestRuleConditions> RuleConditions { get; set; }
        public class UpdateProcessDefinitionRequestRuleConditions : TeaModel {
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

    }

}
