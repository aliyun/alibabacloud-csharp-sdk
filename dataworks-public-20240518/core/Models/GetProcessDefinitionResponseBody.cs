// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProcessDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <para>Process definition</para>
        /// </summary>
        [NameInMap("ProcessDefinition")]
        [Validation(Required=false)]
        public GetProcessDefinitionResponseBodyProcessDefinition ProcessDefinition { get; set; }
        public class GetProcessDefinitionResponseBodyProcessDefinition : TeaModel {
            /// <summary>
            /// <para>Approval node list</para>
            /// </summary>
            [NameInMap("ApprovalNodes")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionApprovalNodes> ApprovalNodes { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionApprovalNodes : TeaModel {
                /// <summary>
                /// <para><b>Node approver type</b>:</para>
                /// <list type="bullet">
                /// <item><description><para>DataWorksProjectRole project role</para>
                /// </description></item>
                /// <item><description><para>DataWorksProjectMember project member</para>
                /// </description></item>
                /// <item><description><para>TableAdministrator table administrator</para>
                /// </description></item>
                /// <item><description><para>TableOrProjectAdministrator Table or project administrator</para>
                /// </description></item>
                /// <item><description><para>AliyunResourceOwner Alibaba Cloud account</para>
                /// </description></item>
                /// <item><description><para>MaxComputeRole MC Administrator</para>
                /// </description></item>
                /// <item><description><para>DLFAdmin and DlfLegacy administrator</para>
                /// </description></item>
                /// <item><description><para>DLFNext Administrator</para>
                /// </description></item>
                /// <item><description><para>TenantRole tenant role</para>
                /// </description></item>
                /// <item><description><para>EmrAdministrator Emr administrator</para>
                /// </description></item>
                /// <item><description><para>LindormAdministrator Lindorm Administrator</para>
                /// </description></item>
                /// <item><description><para>AliyunRamUser RAM user</para>
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
                /// <para><b><c>AccountType</c> has different semantics for different types</b>:</para>
                /// <list type="bullet">
                /// <item><description><para>DataWorksProjectMember specifies the project member\&quot;s UserId.</para>
                /// </description></item>
                /// <item><description><para>DataWorksProjectRole specifies the code of the project role.</para>
                /// </description></item>
                /// <item><description><para>MaxComputeRole specifies the MaxCompute role.</para>
                /// </description></item>
                /// <item><description><para>TenantRole specifies the tenant role code.</para>
                /// </description></item>
                /// <item><description><para>AliyunRamUser specifies the RAM user ID.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("Assignees")]
                [Validation(Required=false)]
                public List<string> Assignees { get; set; }

                /// <summary>
                /// <para>When <c>AccountType </c>is set to different types, you must provide different additional declarations:</para>
                /// <list type="bullet">
                /// <item><description><para>DataWorksProjectMember: The key is projectId, and the value is the UserIds of project members, separated by commas.</para>
                /// </description></item>
                /// <item><description><para>MaxComputeRole: The key is a MaxCompute project and the value is a role name in MaxCompute. Multiple role names are separated by a comma.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("ExtensionProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtensionProperties { get; set; }

                /// <summary>
                /// <para>Node ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a809b6a-2a62-4c6c-9c23-c2a145e3877d</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para><b>Node Name</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>default-name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The description of the business process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>订单业务数据审批流程</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Enable</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Process definition ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>210001039767</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>System Default Policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsSystem")]
            [Validation(Required=false)]
            public bool? IsSystem { get; set; }

            /// <summary>
            /// <para>Process definition name</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute 表审批</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Notification Service Statement</para>
            /// </summary>
            [NameInMap("NotificationServices")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionNotificationServices> NotificationServices { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionNotificationServices : TeaModel {
                /// <summary>
                /// <para>Notification channel, an enumeration:</para>
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
                /// <para>DingRobot</para>
                /// </summary>
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                /// <summary>
                /// <para>Additional information in JSON format, such as <c>{&quot;atAll&quot;:&quot;true&quot;}</c> to specify whether to @all members.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>You must specify WebhookUrl when Channel is DingRobot or Weixin.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
                /// </summary>
                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

            }

            /// <summary>
            /// <para>List of rule conditions</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionRuleConditions> RuleConditions { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionRuleConditions : TeaModel {
                /// <summary>
                /// <para>A conditional expression is in the format <c>((#type==\\&quot;typeValue\\&quot;))</c>, such as <c>((#odpsProject==\\&quot;PX_BEIJING_TEST\\&quot;))</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;))</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>rule effective stage:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Deployment</c> determines whether an application matches this approval policy upon submission.</para>
                /// </description></item>
                /// <item><description><para><c>Running</c> is used to determine whether an approval process is approval-free. This feature is supported only for the MaxCompute type.</para>
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
                /// <para>The condition type. This is an enumeration:</para>
                /// <list type="bullet">
                /// <item><description><para><c>odpsProject</c>,</para>
                /// </description></item>
                /// <item><description><para><c>hologresInstanceId</c></para>
                /// </description></item>
                /// <item><description><para><c>sensibleLevel</c>,</para>
                /// </description></item>
                /// <item><description><para><c>tableGuid</c>,</para>
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

            /// <summary>
            /// <para>Subtype:</para>
            /// <list type="bullet">
            /// <item><description><para>Table</para>
            /// </description></item>
            /// <item><description><para>Column</para>
            /// </description></item>
            /// <item><description><para>Database</para>
            /// </description></item>
            /// <item><description><para>Schema</para>
            /// </description></item>
            /// <item><description><para>Default</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Table</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <para>Process definition type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>MaxCompute</para>
            /// </description></item>
            /// <item><description><para>DataService</para>
            /// </description></item>
            /// <item><description><para>Extension</para>
            /// </description></item>
            /// <item><description><para>Hologres</para>
            /// </description></item>
            /// <item><description><para>DlfV1 (Custom creation not supported).</para>
            /// </description></item>
            /// <item><description><para>EMR (Custom creation not supported).</para>
            /// </description></item>
            /// <item><description><para>DataAssetGovernance (Custom creation not supported).</para>
            /// </description></item>
            /// <item><description><para>Lindorm (Custom creation not supported).</para>
            /// </description></item>
            /// <item><description><para>StarRocks (Custom creation not supported).</para>
            /// </description></item>
            /// <item><description><para>DlfNext (Custom creation not supported).</para>
            /// </description></item>
            /// <item><description><para>DataWorks (Custom creation not supported).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>API request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17***903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
