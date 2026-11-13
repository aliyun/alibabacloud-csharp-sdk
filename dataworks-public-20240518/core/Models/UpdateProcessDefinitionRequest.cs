// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateProcessDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>The list of approval nodes. Note: System policies do not take effect.</para>
        /// </summary>
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionRequestApprovalNodes> ApprovalNodes { get; set; }
        public class UpdateProcessDefinitionRequestApprovalNodes : TeaModel {
            /// <summary>
            /// <para>The type of approver for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataWorksProjectRole: Workspace role</description></item>
            /// <item><description>DataWorksProjectMember: Workspace member</description></item>
            /// <item><description>TableAdministrator: Table owner</description></item>
            /// <item><description>TableOrProjectAdministrator: Table or workspace administrator</description></item>
            /// <item><description>AliyunResourceOwner: Alibaba Cloud account</description></item>
            /// <item><description>MaxComputeRole: MaxCompute administrator</description></item>
            /// <item><description>DLFAdmin: DLF legacy administrator</description></item>
            /// <item><description>DLFNextAdmin: DLFNext administrator</description></item>
            /// <item><description>TenantRole: Tenant role</description></item>
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
            /// <para>The assignees. The semantics vary based on the AccountType:</para>
            /// <list type="bullet">
            /// <item><description>DataWorksProjectMember: Specifies the user ID of the workspace member.</description></item>
            /// <item><description>DataWorksProjectRole: Specifies the code of the workspace role.</description></item>
            /// <item><description>MaxComputeRole: Specifies the MaxCompute role.</description></item>
            /// <item><description>TenantRole: Specifies the code of the tenant role.</description></item>
            /// <item><description>AliyunRamUser: Specifies the RAM user ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataWorksProjectMember</para>
            /// </summary>
            [NameInMap("Assignees")]
            [Validation(Required=false)]
            public string Assignees { get; set; }

            /// <summary>
            /// <para>The extension properties. Different additional declarations are required based on the AccountType:</para>
            /// <list type="bullet">
            /// <item><description><c>DataWorksProjectMember</c>: The key is projectId, and the value is the user ID of the workspace member. Separate multiple values with commas.</description></item>
            /// <item><description><c>MaxComputeRole</c>: The key is the MaxCompute project, and the value is the role name in MaxCompute. Separate multiple values with commas.</description></item>
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
        /// <para>The idempotency token. Used to prevent duplicate operations caused by multiple calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the approval process definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Approval policy for MaxCompute tables in the lwt_ide_simple project</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the approval process definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177554881536128</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the approval process definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute table approval</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification service declaration.</para>
        /// </summary>
        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionRequestNotificationServices> NotificationServices { get; set; }
        public class UpdateProcessDefinitionRequestNotificationServices : TeaModel {
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
            /// <para>Mail</para>
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
            /// <para>The Webhook URL. This parameter is required when the channel is DingRobot or Weixin.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
            /// </summary>
            [NameInMap("Receiver")]
            [Validation(Required=false)]
            public string Receiver { get; set; }

        }

        /// <summary>
        /// <para>The list of conditional rules. Note: System policies do not take effect.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionRequestRuleConditions> RuleConditions { get; set; }
        public class UpdateProcessDefinitionRequestRuleConditions : TeaModel {
            /// <summary>
            /// <para>The conditional expression, such as <c>((#type==\\&quot;typeValue\\&quot;))</c> or <c>((#odpsProject==\\&quot;PX_BEIJING_TEST\\&quot;))</c>.</para>
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
            /// <item><description><b>Deployment</b>: Used to determine whether the approval policy is matched when the application is submitted.</description></item>
            /// <item><description><b>Running</b>: Used to determine whether to skip approval while the approval process runs. [Supported only for MaxCompute]</description></item>
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

    }

}
