// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateProcessDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>A list of approval nodes. This parameter does not apply to system policies.</para>
        /// </summary>
        [NameInMap("ApprovalNodes")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionRequestApprovalNodes> ApprovalNodes { get; set; }
        public class UpdateProcessDefinitionRequestApprovalNodes : TeaModel {
            /// <summary>
            /// <para>The approver type for the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>DataWorksProjectRole</c>: A workspace role.</para>
            /// </description></item>
            /// <item><description><para><c>DataWorksProjectMember</c>: A workspace member.</para>
            /// </description></item>
            /// <item><description><para><c>TableAdministrator</c>: A table administrator.</para>
            /// </description></item>
            /// <item><description><para><c>TableOrProjectAdministrator</c>: The administrator of the table or project.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunResourceOwner</c>: An Alibaba Cloud account.</para>
            /// </description></item>
            /// <item><description><para><c>MaxComputeRole</c>: A MaxCompute administrator.</para>
            /// </description></item>
            /// <item><description><para><c>DLFAdmin</c>: A DlfLegacy administrator.</para>
            /// </description></item>
            /// <item><description><para><c>DLFNextAdmin</c>: A DLFNext administrator.</para>
            /// </description></item>
            /// <item><description><para><c>TenantRole</c>: A tenant role.</para>
            /// </description></item>
            /// <item><description><para><c>EmrAdministrator</c>: An EMR administrator.</para>
            /// </description></item>
            /// <item><description><para><c>LindormAdministrator</c>: A Lindorm administrator.</para>
            /// </description></item>
            /// <item><description><para><c>AliyunRamUser</c>: A RAM user.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TableOrProjectAdministrator</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>Specifies the approvers. The required value depends on the <c>AccountType</c>:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>AccountType</c> is <c>DataWorksProjectMember</c>, this parameter specifies the user IDs of workspace members.</para>
            /// </description></item>
            /// <item><description><para>If <c>AccountType</c> is <c>DataWorksProjectRole</c>, this parameter specifies the codes of workspace roles.</para>
            /// </description></item>
            /// <item><description><para>If <c>AccountType</c> is <c>MaxComputeRole</c>, this parameter specifies the MaxCompute roles.</para>
            /// </description></item>
            /// <item><description><para>If <c>AccountType</c> is <c>TenantRole</c>, this parameter specifies the codes of tenant roles.</para>
            /// </description></item>
            /// <item><description><para>If <c>AccountType</c> is <c>AliyunRamUser</c>, this parameter specifies the user IDs of RAM users.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataWorksProjectMember</para>
            /// </summary>
            [NameInMap("Assignees")]
            [Validation(Required=false)]
            public string Assignees { get; set; }

            /// <summary>
            /// <para>Additional properties that are required for specific <c>AccountType</c> values:</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>AccountType</c> is <c>DataWorksProjectMember</c>: The key is <c>projectId</c> and the value is the user ID of a workspace member. Use commas (,) to separate multiple user IDs.</para>
            /// </description></item>
            /// <item><description><para>If <c>AccountType</c> is <c>MaxComputeRole</c>: The key is the MaxCompute project name and the value is the role name in MaxCompute. Use commas (,) to separate multiple role names.</para>
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
        /// <para>An idempotent parameter. It ensures that retried requests do not result in duplicate operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the process definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lwt_ide_simple 项目 MaxCompute 表审批策略</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the process definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>177554881536128</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the process definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute 表审批</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification service configurations.</para>
        /// </summary>
        [NameInMap("NotificationServices")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionRequestNotificationServices> NotificationServices { get; set; }
        public class UpdateProcessDefinitionRequestNotificationServices : TeaModel {
            /// <summary>
            /// <para>The notification channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Mail</para>
            /// </description></item>
            /// <item><description><para>Sms</para>
            /// </description></item>
            /// <item><description><para>DingRobot</para>
            /// </description></item>
            /// <item><description><para>Weixin</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Mail</para>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>Additional information in JSON format. For example, use {&quot;atAll&quot;:&quot;true&quot;} to specify whether to notify all members.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>The webhook URL. This parameter is required when <c>Channel</c> is set to <c>DingRobot</c> or <c>Weixin</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
            /// </summary>
            [NameInMap("Receiver")]
            [Validation(Required=false)]
            public string Receiver { get; set; }

        }

        /// <summary>
        /// <para>A list of rule conditions. This parameter does not apply to system policies.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<UpdateProcessDefinitionRequestRuleConditions> RuleConditions { get; set; }
        public class UpdateProcessDefinitionRequestRuleConditions : TeaModel {
            /// <summary>
            /// <para>The conditional expression. Format: ((#type==\&quot;typeValue\&quot;)). For example: ((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;)).</para>
            /// 
            /// <b>Example:</b>
            /// <para>((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;))</para>
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// <para>The phase in which the rule takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Deployment</b>: Determines whether the approval policy applies when an application is submitted.</para>
            /// </description></item>
            /// <item><description><para><b>Running</b>: Determines whether to skip the approval during the approval process. This phase is supported only for MaxCompute.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deployment</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The type of the condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>odpsProject</c></para>
            /// </description></item>
            /// <item><description><para><c>hologresInstanceId</c></para>
            /// </description></item>
            /// <item><description><para><c>sensibleLevel</c></para>
            /// </description></item>
            /// <item><description><para><c>tableGuid</c></para>
            /// </description></item>
            /// <item><description><para><c>projectId</c></para>
            /// </description></item>
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
