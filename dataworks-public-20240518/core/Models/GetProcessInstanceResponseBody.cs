// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProcessInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the approval process instance.</para>
        /// </summary>
        [NameInMap("ProcessInstance")]
        [Validation(Required=false)]
        public GetProcessInstanceResponseBodyProcessInstance ProcessInstance { get; set; }
        public class GetProcessInstanceResponseBodyProcessInstance : TeaModel {
            /// <summary>
            /// <para>The user ID of the applicant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1107558004253538</para>
            /// </summary>
            [NameInMap("Applicator")]
            [Validation(Required=false)]
            public string Applicator { get; set; }

            /// <summary>
            /// <para>The username of the applicant\&quot;s Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_account</para>
            /// </summary>
            [NameInMap("ApplicatorName")]
            [Validation(Required=false)]
            public string ApplicatorName { get; set; }

            /// <summary>
            /// <para>The approval policy applied to this process instance.</para>
            /// </summary>
            [NameInMap("ApprovalProcessDefinition")]
            [Validation(Required=false)]
            public GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinition ApprovalProcessDefinition { get; set; }
            public class GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinition : TeaModel {
                /// <summary>
                /// <para>The approval nodes.</para>
                /// </summary>
                [NameInMap("ApprovalNodes")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionApprovalNodes> ApprovalNodes { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionApprovalNodes : TeaModel {
                    /// <summary>
                    /// <para>The type of the approver for the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>DataWorksProjectRole</c>: A workspace role</para>
                    /// </description></item>
                    /// <item><description><para><c>DataWorksProjectMember</c>: A workspace member</para>
                    /// </description></item>
                    /// <item><description><para><c>TableAdministrator</c>: A table administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>TableOrProjectAdministrator</c>: A table or workspace administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>AliyunResourceOwner</c>: An Alibaba Cloud account</para>
                    /// </description></item>
                    /// <item><description><para><c>MaxComputeRole</c>: A MaxCompute role</para>
                    /// </description></item>
                    /// <item><description><para><c>DLFAdmin</c>: A DlfLegacy administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>DLFNextAdmin</c>: A DLFNext administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>TenantRole</c>: A tenant role</para>
                    /// </description></item>
                    /// <item><description><para><c>EmrAdministrator</c>: An Emr administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>LindormAdministrator</c>: A Lindorm administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>AliyunRamUser</c>: A RAM user</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DataWorksProjectRole</para>
                    /// </summary>
                    [NameInMap("AccountType")]
                    [Validation(Required=false)]
                    public string AccountType { get; set; }

                    /// <summary>
                    /// <para>The specified approvers.</para>
                    /// <para>The contents of this parameter depend on the <c>AccountType</c> value:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <c>AccountType</c> is <c>DataWorksProjectMember</c>, this parameter contains the user IDs of workspace members.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>AccountType</c> is <c>DataWorksProjectRole</c>, this parameter contains the codes of workspace roles.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>AccountType</c> is <c>MaxComputeRole</c>, this parameter contains the MaxCompute roles.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>AccountType</c> is <c>TenantRole</c>, this parameter contains the codes of tenant roles.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>AccountType</c> is <c>AliyunRamUser</c>, this parameter contains the user IDs of RAM users.</para>
                    /// </description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Assignees")]
                    [Validation(Required=false)]
                    public List<string> Assignees { get; set; }

                    /// <summary>
                    /// <para>The extended description of the approval node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("ExtensionProperties")]
                    [Validation(Required=false)]
                    public string ExtensionProperties { get; set; }

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
                    /// <para>The node name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default-name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The description of the approval policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>流程定义描述</para>
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
                /// <para>The approval policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>323861511451222099</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the approval policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SYSTEM_GENERATE_DEFAULT</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The notification services.</para>
                /// </summary>
                [NameInMap("NotificationServices")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionNotificationServices> NotificationServices { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionNotificationServices : TeaModel {
                    /// <summary>
                    /// <para>The notification channel. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Mail</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Sms</c></para>
                    /// </description></item>
                    /// <item><description><para><c>DingRobot</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Weixin</c></para>
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
                    /// <para>Additional information in JSON format. For example, <c>{&quot;atAll&quot;:&quot;true&quot;}</c> indicates whether to @all members.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;atAll&quot;:&quot;true&quot;}</para>
                    /// </summary>
                    [NameInMap("Extension")]
                    [Validation(Required=false)]
                    public string Extension { get; set; }

                    /// <summary>
                    /// <para>If <c>Channel</c> is set to <c>DingRobot</c> or <c>Weixin</c>, the value of this parameter must be the webhook URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://dingtalk">https://dingtalk</a></para>
                    /// </summary>
                    [NameInMap("Receiver")]
                    [Validation(Required=false)]
                    public string Receiver { get; set; }

                }

                /// <summary>
                /// <para>The rules that determine when the approval policy takes effect.</para>
                /// </summary>
                [NameInMap("RuleConditions")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionRuleConditions> RuleConditions { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionRuleConditions : TeaModel {
                    /// <summary>
                    /// <para>The expression of the rule condition. Format: <c>((#type==\\&quot;typeValue\\&quot;))</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>((#odpsProject==\&quot;PX_BEIJING_TEST\&quot;))</para>
                    /// </summary>
                    [NameInMap("Expression")]
                    [Validation(Required=false)]
                    public string Expression { get; set; }

                    /// <summary>
                    /// <para>The rule scope. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Deployment</c>: Determines whether the policy applies when a request is submitted.</para>
                    /// </description></item>
                    /// <item><description><para><c>Running</c>: Determines whether to skip approval while the process instance runs. This value is supported only for MaxCompute approval policies.</para>
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
                    /// <para>The type of the rule condition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>odpsProject</c>: Applies to a specific MaxCompute project.</para>
                    /// </description></item>
                    /// <item><description><para><c>hologresInstanceId</c>: Applies to a specific Hologres instance.</para>
                    /// </description></item>
                    /// <item><description><para><c>sensibleLevel</c>: Applies to a specific security level.</para>
                    /// </description></item>
                    /// <item><description><para><c>tableGuid</c>: Applies to a specific table.</para>
                    /// </description></item>
                    /// <item><description><para><c>projectId</c>: Applies to a specific workspace.</para>
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
                /// <para>The subtype of the approval policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Table</c></para>
                /// </description></item>
                /// <item><description><para><c>Column</c></para>
                /// </description></item>
                /// <item><description><para><c>Database</c></para>
                /// </description></item>
                /// <item><description><para><c>Schema</c></para>
                /// </description></item>
                /// <item><description><para><c>Default</c></para>
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
                /// <para>The type of the approval policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>MaxCompute</c></para>
                /// </description></item>
                /// <item><description><para><c>DataService</c></para>
                /// </description></item>
                /// <item><description><para><c>DlfV1</c> (Custom creation is not supported)</para>
                /// </description></item>
                /// <item><description><para><c>Extension</c></para>
                /// </description></item>
                /// <item><description><para><c>Hologres</c></para>
                /// </description></item>
                /// <item><description><para><c>Emr</c> (Custom creation is not supported)</para>
                /// </description></item>
                /// <item><description><para><c>DataAssetGovernance</c> (Custom creation is not supported)</para>
                /// </description></item>
                /// <item><description><para><c>Lindorm</c> (Custom creation is not supported)</para>
                /// </description></item>
                /// <item><description><para><c>StarRocks</c> (Custom creation is not supported)</para>
                /// </description></item>
                /// <item><description><para><c>DlfNext</c> (Custom creation is not supported)</para>
                /// </description></item>
                /// <item><description><para><c>DataWorks</c> (Custom creation is not supported)</para>
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
            /// <para>The approval tasks.</para>
            /// </summary>
            [NameInMap("ApprovalTasks")]
            [Validation(Required=false)]
            public List<GetProcessInstanceResponseBodyProcessInstanceApprovalTasks> ApprovalTasks { get; set; }
            public class GetProcessInstanceResponseBodyProcessInstanceApprovalTasks : TeaModel {
                /// <summary>
                /// <para>The approval comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("ApprovalComment")]
                [Validation(Required=false)]
                public string ApprovalComment { get; set; }

                /// <summary>
                /// <para>The approval decision. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Agree</c></para>
                /// </description></item>
                /// <item><description><para><c>Deny</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Deny</para>
                /// </summary>
                [NameInMap("ApprovalDecision")]
                [Validation(Required=false)]
                public string ApprovalDecision { get; set; }

                /// <summary>
                /// <para>The approval node from the corresponding approval policy.</para>
                /// </summary>
                [NameInMap("ApprovalNode")]
                [Validation(Required=false)]
                public GetProcessInstanceResponseBodyProcessInstanceApprovalTasksApprovalNode ApprovalNode { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalTasksApprovalNode : TeaModel {
                    /// <summary>
                    /// <para>The type of the approver for the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>DataWorksProjectRole</c>: A workspace role</para>
                    /// </description></item>
                    /// <item><description><para><c>DataWorksProjectMember</c>: A workspace member</para>
                    /// </description></item>
                    /// <item><description><para><c>TableAdministrator</c>: A table administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>TableOrProjectAdministrator</c>: A table or workspace administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>AliyunResourceOwner</c>: An Alibaba Cloud account</para>
                    /// </description></item>
                    /// <item><description><para><c>MaxComputeRole</c>: A MaxCompute role</para>
                    /// </description></item>
                    /// <item><description><para><c>DLFAdmin</c>: A DlfLegacy administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>DLFNextAdmin</c>: A DLFNext administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>TenantRole</c>: A tenant role</para>
                    /// </description></item>
                    /// <item><description><para><c>EmrAdministrator</c>: An Emr administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>LindormAdministrator</c>: A Lindorm administrator</para>
                    /// </description></item>
                    /// <item><description><para><c>AliyunRamUser</c>: A RAM user</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DataWorksProjectRole</para>
                    /// </summary>
                    [NameInMap("AccountType")]
                    [Validation(Required=false)]
                    public string AccountType { get; set; }

                    /// <summary>
                    /// <para>The specified approvers.</para>
                    /// <para>The contents of this parameter depend on the <c>AccountType</c> value:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <c>AccountType</c> is <c>DataWorksProjectMember</c>, this parameter contains the user IDs of workspace members.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>AccountType</c> is <c>DataWorksProjectRole</c>, this parameter contains the codes of workspace roles.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>AccountType</c> is <c>MaxComputeRole</c>, this parameter contains the MaxCompute roles.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>AccountType</c> is <c>TenantRole</c>, this parameter contains the codes of tenant roles.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>AccountType</c> is <c>AliyunRamUser</c>, this parameter contains the user IDs of RAM users.</para>
                    /// </description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("Assignees")]
                    [Validation(Required=false)]
                    public List<string> Assignees { get; set; }

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
                    /// <para>The node name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default-name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The user ID of the actual approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>207947399706614297</para>
                /// </summary>
                [NameInMap("Assignee")]
                [Validation(Required=false)]
                public string Assignee { get; set; }

                /// <summary>
                /// <para>The name of the actual approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("AssigneeName")]
                [Validation(Required=false)]
                public string AssigneeName { get; set; }

                /// <summary>
                /// <para>The time when the task was completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715590800000</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public long? CompleteTime { get; set; }

                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715587200000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The approval task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>task_001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The status of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Completed</c>: The task is complete.</para>
                /// </description></item>
                /// <item><description><para><c>Pending</c>: The task is pending.</para>
                /// </description></item>
                /// <item><description><para><c>Aborted</c>: The task is aborted.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Aborted</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The candidate approvers for the task.</para>
                /// </summary>
                [NameInMap("TaskCandidates")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyProcessInstanceApprovalTasksTaskCandidates> TaskCandidates { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalTasksTaskCandidates : TeaModel {
                    /// <summary>
                    /// <para>The name of the approver.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>李四</para>
                    /// </summary>
                    [NameInMap("MemberName")]
                    [Validation(Required=false)]
                    public string MemberName { get; set; }

                    /// <summary>
                    /// <para>The user ID of the approver.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>207947397776614297</para>
                    /// </summary>
                    [NameInMap("MemberUserId")]
                    [Validation(Required=false)]
                    public string MemberUserId { get; set; }

                }

            }

            /// <summary>
            /// <para>The authorization failure message.</para>
            /// <para><b>Note</b>: This parameter is returned only if the authorization fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S-400007:ODPS acl auth failed. odps table acl auth failed</para>
            /// </summary>
            [NameInMap("AuthErrorMessage")]
            [Validation(Required=false)]
            public string AuthErrorMessage { get; set; }

            /// <summary>
            /// <para>The process instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>332066440109224007</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The reason for the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>业务需要</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The time when the approval process started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-25 10:20:18 CST</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public object StartTime { get; set; }

            /// <summary>
            /// <para>The status of the process instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Completed</c>: The request is approved.</para>
            /// </description></item>
            /// <item><description><para><c>Running</c>: The request is in the approval process.</para>
            /// </description></item>
            /// <item><description><para><c>Aborted</c>: The request is withdrawn.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the process instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute表权限申请</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
