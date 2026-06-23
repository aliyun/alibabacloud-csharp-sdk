// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateProcessDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>The list of approval nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public List<CreateProcessDefinitionRequestApprovalNodes> ApprovalNodes { get; set; }
        public class CreateProcessDefinitionRequestApprovalNodes : TeaModel {
            /// <summary>
            /// <para>The type of approver for the node:</para>
            /// <list type="bullet">
            /// <item><description>DataWorksProjectRole: workspace role.</description></item>
            /// <item><description>DataWorksProjectMember: workspace member.</description></item>
            /// <item><description>TableAdministrator: table owner.</description></item>
            /// <item><description>TableOrProjectAdministrator: table or workspace administrator.</description></item>
            /// <item><description>AliyunResourceOwner: Alibaba Cloud account.</description></item>
            /// <item><description>MaxComputeRole: MaxCompute administrator.</description></item>
            /// <item><description>DLFAdmin: DLF Legacy administrator.</description></item>
            /// <item><description>DLFNextAdmin: DLF Next administrator.</description></item>
            /// <item><description>TenantRole: tenant role.</description></item>
            /// <item><description>EmrAdministrator: EMR administrator.</description></item>
            /// <item><description>LindormAdministrator: Lindorm administrator.</description></item>
            /// <item><description>AliyunRamUser: RAM user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TableOrProjectAdministrator</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The semantics of this parameter varies based on the value of <c>AccountType</c>:</para>
            /// <list type="bullet">
            /// <item><description>DataWorksProjectMember: the user ID of the workspace member.</description></item>
            /// <item><description>DataWorksProjectRole: the code of the workspace role. If a custom workspace role is required, set this parameter to &quot;custom-role&quot; and further configure the role in ExtensionProperties.</description></item>
            /// <item><description>MaxComputeRole: the MaxCompute role.</description></item>
            /// <item><description>TenantRole: the code of the tenant role.</description></item>
            /// <item><description>AliyunRamUser: the RAM user ID.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Assignees")]
            [Validation(Required=false)]
            public List<string> Assignees { get; set; }

            /// <summary>
            /// <para>The additional declarations required based on the value of <c>AccountType</c>:</para>
            /// <list type="bullet">
            /// <item><description><para>DataWorksProjectMember: specify different workspace member user IDs. The key is the workspace ID, and the value is the user ID of the workspace member. Separate multiple user IDs with commas (,).</para>
            /// </description></item>
            /// <item><description><para>DataWorksProjectRole: specify different custom workspace role codes. The key is the workspace ID, and the value is the custom workspace role code. Separate multiple role codes with commas (,).</para>
            /// </description></item>
            /// <item><description><para>MaxComputeRole: specify the roles under a MaxCompute project. The key is the MaxCompute project name, and the value is the role name in MaxCompute. Separate multiple role names with commas (,).</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExtensionProperties")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtensionProperties { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token. We recommend that you use a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the process definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个示例策略</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the process definition.</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The name of the process definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的审批策略</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification service declarations.</para>
        /// </summary>
        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public List<CreateProcessDefinitionRequestNotificationServices> NotificationServices { get; set; }
        public class CreateProcessDefinitionRequestNotificationServices : TeaModel {
            /// <summary>
            /// <para>The notification channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Mail</description></item>
            /// <item><description>Sms</description></item>
            /// <item><description>DingRobot</description></item>
            /// <item><description>Weixin</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DingRobot</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The extension information in JSON format. Example: <c>{&quot;atAll&quot;:&quot;true&quot;}</c>, which specifies whether to mention all members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>The WebhookUrl that must be specified when Channel is set to DingRobot or Weixin.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
            /// </summary>
            [NameInMap("Receiver")]
            [Validation(Required=false)]
            public string Receiver { get; set; }

        }

        /// <summary>
        /// <para>The list of condition rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<CreateProcessDefinitionRequestRuleConditions> RuleConditions { get; set; }
        public class CreateProcessDefinitionRequestRuleConditions : TeaModel {
            /// <summary>
            /// <para>The condition expression in the format of ((#type==\&quot;typeValue\&quot;)). Example: ((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;)).</para>
            /// 
            /// <b>Example:</b>
            /// <para>((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;))</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The stage at which the rule takes effect:</para>
            /// <list type="bullet">
            /// <item><description><c>Deployment</c>: used to determine whether the approval policy matches when a request is submitted.</description></item>
            /// <item><description><c>Running</c>: used to determine whether approval is exempted during the execution of the approval process. This value is supported only for the MaxCompute type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deployment</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The condition type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>odpsProject</c></description></item>
            /// <item><description><c>hologresInstanceId</c></description></item>
            /// <item><description><c>sensibleLevel</c></description></item>
            /// <item><description><c>tableGuid</c></description></item>
            /// <item><description><c>projectId</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>odpsProject</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The subtype. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Table</description></item>
        /// <item><description>Column</description></item>
        /// <item><description>Database</description></item>
        /// <item><description>Schema</description></item>
        /// <item><description>Default</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Table</para>
        /// </summary>
        [NameInMap("SubType")]
        [Validation(Required=false)]
        public string SubType { get; set; }

        /// <summary>
        /// <para>The type of the process definition. Valid values:</para>
        /// <ol>
        /// <item><description>MaxCompute</description></item>
        /// <item><description>DataService</description></item>
        /// <item><description>Extension</description></item>
        /// <item><description>Hologres</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>Extension</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
