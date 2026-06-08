// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProcessInstanceResponseBody : TeaModel {
        [NameInMap("ProcessInstance")]
        [Validation(Required=false)]
        public GetProcessInstanceResponseBodyProcessInstance ProcessInstance { get; set; }
        public class GetProcessInstanceResponseBodyProcessInstance : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1107558004253538</para>
            /// </summary>
            [NameInMap("Applicator")]
            [Validation(Required=false)]
            public string Applicator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_account</para>
            /// </summary>
            [NameInMap("ApplicatorName")]
            [Validation(Required=false)]
            public string ApplicatorName { get; set; }

            [NameInMap("ApprovalProcessDefinition")]
            [Validation(Required=false)]
            public GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinition ApprovalProcessDefinition { get; set; }
            public class GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinition : TeaModel {
                [NameInMap("ApprovalNodes")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionApprovalNodes> ApprovalNodes { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionApprovalNodes : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DataWorksProjectRole</para>
                    /// </summary>
                    [NameInMap("AccountType")]
                    [Validation(Required=false)]
                    public string AccountType { get; set; }

                    [NameInMap("Assignees")]
                    [Validation(Required=false)]
                    public List<string> Assignees { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("ExtensionProperties")]
                    [Validation(Required=false)]
                    public string ExtensionProperties { get; set; }

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
                /// <para>323861511451222099</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SYSTEM_GENERATE_DEFAULT</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NotificationServices")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionNotificationServices> NotificationServices { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionNotificationServices : TeaModel {
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
                    /// <para><a href="https://dingtalk">https://dingtalk</a></para>
                    /// </summary>
                    [NameInMap("Receiver")]
                    [Validation(Required=false)]
                    public string Receiver { get; set; }

                }

                [NameInMap("RuleConditions")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionRuleConditions> RuleConditions { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalProcessDefinitionRuleConditions : TeaModel {
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

            [NameInMap("ApprovalTasks")]
            [Validation(Required=false)]
            public List<GetProcessInstanceResponseBodyProcessInstanceApprovalTasks> ApprovalTasks { get; set; }
            public class GetProcessInstanceResponseBodyProcessInstanceApprovalTasks : TeaModel {
                [NameInMap("ApprovalComment")]
                [Validation(Required=false)]
                public string ApprovalComment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>deny</para>
                /// </summary>
                [NameInMap("ApprovalDecision")]
                [Validation(Required=false)]
                public string ApprovalDecision { get; set; }

                [NameInMap("ApprovalNode")]
                [Validation(Required=false)]
                public GetProcessInstanceResponseBodyProcessInstanceApprovalTasksApprovalNode ApprovalNode { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalTasksApprovalNode : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DataWorksProjectRole</para>
                    /// </summary>
                    [NameInMap("AccountType")]
                    [Validation(Required=false)]
                    public string AccountType { get; set; }

                    [NameInMap("Assignees")]
                    [Validation(Required=false)]
                    public List<string> Assignees { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>207947399706614297</para>
                /// </summary>
                [NameInMap("Assignee")]
                [Validation(Required=false)]
                public string Assignee { get; set; }

                [NameInMap("AssigneeName")]
                [Validation(Required=false)]
                public string AssigneeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1715590800000</para>
                /// </summary>
                [NameInMap("CompleteTime")]
                [Validation(Required=false)]
                public long? CompleteTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1715587200000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>task_001</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Aborted</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TaskCandidates")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyProcessInstanceApprovalTasksTaskCandidates> TaskCandidates { get; set; }
                public class GetProcessInstanceResponseBodyProcessInstanceApprovalTasksTaskCandidates : TeaModel {
                    [NameInMap("MemberName")]
                    [Validation(Required=false)]
                    public string MemberName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>207947397776614297</para>
                    /// </summary>
                    [NameInMap("MemberUserId")]
                    [Validation(Required=false)]
                    public string MemberUserId { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>S-400007:ODPS acl auth failed. odps table acl auth failed</para>
            /// </summary>
            [NameInMap("AuthErrorMessage")]
            [Validation(Required=false)]
            public string AuthErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>332066440109224007</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-25 10:20:18 CST</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public object StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
