// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProcessDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <para>The process definition.</para>
        /// </summary>
        [NameInMap("ProcessDefinition")]
        [Validation(Required=false)]
        public GetProcessDefinitionResponseBodyProcessDefinition ProcessDefinition { get; set; }
        public class GetProcessDefinitionResponseBodyProcessDefinition : TeaModel {
            /// <summary>
            /// <para>The list of approval nodes.</para>
            /// </summary>
            [NameInMap("ApprovalNodes")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionApprovalNodes> ApprovalNodes { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionApprovalNodes : TeaModel {
                /// <summary>
                /// <para><b>The type of approver for the node</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DataWorksProjectRole: Workspace role.</description></item>
                /// <item><description>DataWorksProjectMember: Workspace member.</description></item>
                /// <item><description>TableAdministrator: Table owner.</description></item>
                /// <item><description>TableOrProjectAdministrator: Table or workspace administrator.</description></item>
                /// <item><description>AliyunResourceOwner: Alibaba Cloud account.</description></item>
                /// <item><description>MaxComputeRole: MaxCompute administrator.</description></item>
                /// <item><description>DLFAdmin: DLF legacy administrator.</description></item>
                /// <item><description>DLFNextAdmin: DLFNext administrator.</description></item>
                /// <item><description>TenantRole: Tenant role.</description></item>
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
                /// <para><b>The semantics vary based on the <c>AccountType</c> value</b>:</para>
                /// <list type="bullet">
                /// <item><description>DataWorksProjectMember: Specifies the user ID of the workspace member.</description></item>
                /// <item><description>DataWorksProjectRole: Specifies the code of the workspace role.</description></item>
                /// <item><description>MaxComputeRole: Specifies the MaxCompute role.</description></item>
                /// <item><description>TenantRole: Specifies the code of the tenant role.</description></item>
                /// <item><description>AliyunRamUser: Specifies the RAM user ID.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Assignees")]
                [Validation(Required=false)]
                public List<string> Assignees { get; set; }

                /// <summary>
                /// <para>The additional declarations required for different <c>AccountType</c> values:</para>
                /// <list type="bullet">
                /// <item><description>DataWorksProjectMember: The key is <c>projectId</c>, and the value is the user ID of the workspace member. Separate multiple values with commas.</description></item>
                /// <item><description>MaxComputeRole: The key is the MaxCompute project, and the value is the role name in MaxCompute. Separate multiple values with commas.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;449656&quot;: &quot;role_project_admin,role_project_pe&quot;}</para>
                /// </summary>
                [NameInMap("ExtensionProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtensionProperties { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7a809b6a-2a62-4c6c-9c23-c2a145e3877d</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para><b>The node name.</b></para>
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
            /// <para>Order business data approval process</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the policy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The process definition ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>210001039767</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the policy is the default system policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsSystem")]
            [Validation(Required=false)]
            public bool? IsSystem { get; set; }

            /// <summary>
            /// <para>The name of the process definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute table approval</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The notification service configurations.</para>
            /// </summary>
            [NameInMap("NotificationServices")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionNotificationServices> NotificationServices { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionNotificationServices : TeaModel {
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
                /// <para>The extended information in JSON format, such as <c>{&quot;atAll&quot;:&quot;true&quot;}</c>, which specifies whether to mention all members.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                /// </summary>
                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                /// <summary>
                /// <para>The receiver. If <c>Channel</c> is set to <c>DingRobot</c> or <c>Weixin</c>, you must specify <c>WebhookUrl</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
                /// </summary>
                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

            }

            /// <summary>
            /// <para>The list of effective rules for the approval policy.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyProcessDefinitionRuleConditions> RuleConditions { get; set; }
            public class GetProcessDefinitionResponseBodyProcessDefinitionRuleConditions : TeaModel {
                /// <summary>
                /// <para>The conditional expression in the <c>((#type==\\&quot;typeValue\\&quot;))</c> format, such as <c>((#odpsProject==\\&quot;PX_BEIJING_TEST\\&quot;))</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;))</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The effective stage of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>Deployment</c>: Used to determine whether the approval policy is matched when an application is submitted.</description></item>
                /// <item><description><c>Running</c>: Used to determine whether to skip approval while the approval process runs. This value is supported only for the MaxCompute type.</description></item>
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
            /// <para>The process definition type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MaxCompute</description></item>
            /// <item><description>DataService</description></item>
            /// <item><description>Extension</description></item>
            /// <item><description>Hologres</description></item>
            /// <item><description>DlfV1: Custom creation is not supported.</description></item>
            /// <item><description>Emr: Custom creation is not supported.</description></item>
            /// <item><description>DataAssetGovernance: Custom creation is not supported.</description></item>
            /// <item><description>Lindorm: Custom creation is not supported.</description></item>
            /// <item><description>StarRocks: Custom creation is not supported.</description></item>
            /// <item><description>DlfNext: Custom creation is not supported.</description></item>
            /// <item><description>DataWorks: Custom creation is not supported.</description></item>
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
        /// <para>The API request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17***903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
