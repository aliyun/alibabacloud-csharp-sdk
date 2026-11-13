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
            /// <para>The approver type for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataWorksProjectRole: workspace role</description></item>
            /// <item><description>DataWorksProjectMember: workspace member</description></item>
            /// <item><description>TableAdministrator: table owner</description></item>
            /// <item><description>TableOrProjectAdministrator: table or workspace administrator</description></item>
            /// <item><description>AliyunResourceOwner: Alibaba Cloud account</description></item>
            /// <item><description>MaxComputeRole: MaxCompute administrator</description></item>
            /// <item><description>DLFAdmin: DLF legacy administrator</description></item>
            /// <item><description>DLFNextAdmin: DLFNext administrator</description></item>
            /// <item><description>TenantRole: tenant role</description></item>
            /// <item><description>EmrAdministrator: EMR administrator</description></item>
            /// <item><description>LindormAdministrator: Lindorm administrator</description></item>
            /// <item><description>AliyunRamUser: RAM user</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TableOrProjectAdministrator</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The assignees. The semantics vary based on the value of AccountType:</para>
            /// <list type="bullet">
            /// <item><description>DataWorksProjectMember: specifies the user ID of the workspace member.</description></item>
            /// <item><description>DataWorksProjectRole: specifies the code of the workspace role. If a custom workspace role is required, set this parameter to &quot;custom-role&quot; and further configure it in ExtensionProperties.</description></item>
            /// <item><description>MaxComputeRole: specifies the MaxCompute role.</description></item>
            /// <item><description>TenantRole: specifies the code of the tenant role.</description></item>
            /// <item><description>AliyunRamUser: specifies the RAM user ID.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Assignees")]
            [Validation(Required=false)]
            public List<string> Assignees { get; set; }

            /// <summary>
            /// <para>The extended properties. Different additional declarations are required based on the value of AccountType:</para>
            /// <list type="bullet">
            /// <item><description><para>DataWorksProjectMember: You must set the user IDs of different workspace members. The key is the workspace ID, and the value is the user ID of the workspace member. Separate multiple values with commas (,).</para>
            /// </description></item>
            /// <item><description><para>DataWorksProjectRole: You must set the codes of different custom workspace roles. The key is the workspace ID, and the value is the code of the custom workspace role. Separate multiple values with commas (,).</para>
            /// </description></item>
            /// <item><description><para>MaxComputeRole: You must set the roles under the MaxCompute project. The key is the MaxCompute project, and the value is the role name in MaxCompute. Separate multiple values with commas (,).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;449656&quot;: &quot;role_project_admin,role_project_pe&quot;}</para>
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
        /// <para>The client token that is used to ensure idempotence. We recommend using a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the flow definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a sample policy</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the flow definition.</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The name of the flow definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My approval policy</para>
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
            /// <para>The extended information in JSON format. For example, <c>{&quot;atAll&quot;:&quot;true&quot;}</c> specifies whether to mention all users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>The receiver. When Channel is set to DingRobot or Weixin, you must specify WebhookUrl.</para>
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
            /// <para>The conditional expression, in the format of ((#type==\&quot;typeValue\&quot;)). Example: ((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;)).</para>
            /// 
            /// <b>Example:</b>
            /// <para>((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;))</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The stage where the rule takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Deployment</c>: Used to determine whether the approval policy is matched when the application is submitted.</description></item>
            /// <item><description><c>Running</c>: Used to determine whether the approval process is exempt from approval during execution. This value is supported only for the MaxCompute type.</description></item>
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
            /// <item><description><c>odpsProject</c> </description></item>
            /// <item><description><c>hologresInstanceId</c></description></item>
            /// <item><description><c>sensibleLevel</c> </description></item>
            /// <item><description><c>tableGuid</c> </description></item>
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
        /// <para>The type of the flow definition. Valid values:</para>
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
