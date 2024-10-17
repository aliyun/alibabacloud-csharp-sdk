// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetApprovalDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The approval details of the ticket.</para>
        /// </summary>
        [NameInMap("ApprovalDetail")]
        [Validation(Required=false)]
        public GetApprovalDetailResponseBodyApprovalDetail ApprovalDetail { get; set; }
        public class GetApprovalDetailResponseBodyApprovalDetail : TeaModel {
            /// <summary>
            /// <para>The ID of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>184****</para>
            /// </summary>
            [NameInMap("AuditId")]
            [Validation(Required=false)]
            public long? AuditId { get; set; }

            /// <summary>
            /// <para>The time when the approval process was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-29 14:17:25</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The information about the approver.</para>
            /// </summary>
            [NameInMap("CurrentHandlers")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailCurrentHandlers CurrentHandlers { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailCurrentHandlers : TeaModel {
                [NameInMap("CurrentHandler")]
                [Validation(Required=false)]
                public List<GetApprovalDetailResponseBodyApprovalDetailCurrentHandlersCurrentHandler> CurrentHandler { get; set; }
                public class GetApprovalDetailResponseBodyApprovalDetailCurrentHandlersCurrentHandler : TeaModel {
                    /// <summary>
                    /// <para>The ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The nickname of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nickName</para>
                    /// </summary>
                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                }

            }

            /// <summary>
            /// <para>The description of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[Instance permissions] Application\<br/>Permission type: ⌈Logon⌋\<br/>Application period: 30.0 days\<br/>Background description: [Instance permissions] logon test\<br/>\<br/>[Application list]\<br/>\&lt;span style=\&quot;color:red\&quot;&gt;product\</span> rm-bp144d5ky4l4rli0417\<em>\</em>\<em>\</em>.mysql.rds.aliyuncs.com:3306 - PRODUCT\<br/></para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>384****</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The type of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NDDL</b>: a schema design ticket</description></item>
            /// <item><description><b>DATA_TRACK</b>: a data tracking ticket</description></item>
            /// <item><description><b>TABLE_SYNC</b>: a table synchronization ticket</description></item>
            /// <item><description><b>PERM_APPLY</b>: a permission application ticket</description></item>
            /// <item><description><b>DATA_EXPORT</b>: a data export ticket</description></item>
            /// <item><description><b>DATA_CORRECT</b>: a data change ticket</description></item>
            /// <item><description><b>OWNER_APPLY</b>: an owner role application ticket</description></item>
            /// <item><description><b>SENSITIVITY</b>: a column sensitivity level change ticket</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PERM_APPLY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The reasons for the approval.</para>
            /// </summary>
            [NameInMap("ReasonList")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailReasonList ReasonList { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailReasonList : TeaModel {
                [NameInMap("Reasons")]
                [Validation(Required=false)]
                public List<string> Reasons { get; set; }

            }

            /// <summary>
            /// <para>The ID of the workflow template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The title of the approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Permission application ticket - 384\<em>\</em>\<em>\</em></para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The approval status of the ticket. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AUDITING</b>: The ticket is being reviewed.</description></item>
            /// <item><description><b>REJECT</b>: The ticket was rejected.</description></item>
            /// <item><description><b>CANCEL</b>: The ticket was revoked.</description></item>
            /// <item><description><b>APPROVED</b>: The ticket was approved.</description></item>
            /// </list>
            /// <remarks>
            /// <para>An approval process contains multiple approval nodes, and this parameter is returned for each approval node.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("WorkflowInsCode")]
            [Validation(Required=false)]
            public string WorkflowInsCode { get; set; }

            /// <summary>
            /// <para>The details of approval nodes.</para>
            /// </summary>
            [NameInMap("WorkflowNodes")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailWorkflowNodes WorkflowNodes { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodes : TeaModel {
                [NameInMap("WorkflowNode")]
                [Validation(Required=false)]
                public List<GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNode> WorkflowNode { get; set; }
                public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNode : TeaModel {
                    /// <summary>
                    /// <para>The IDs of the approvers.</para>
                    /// </summary>
                    [NameInMap("AuditUserIdList")]
                    [Validation(Required=false)]
                    public GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNodeAuditUserIdList AuditUserIdList { get; set; }
                    public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNodeAuditUserIdList : TeaModel {
                        [NameInMap("AuditUserIds")]
                        [Validation(Required=false)]
                        public List<string> AuditUserIds { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the approval node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DBA</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>The remarks of the approval.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reason: Approved</para>
                    /// </summary>
                    [NameInMap("OperateComment")]
                    [Validation(Required=false)]
                    public string OperateComment { get; set; }

                    /// <summary>
                    /// <para>The time when the ticket was submitted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-10-15 13:47:54</para>
                    /// </summary>
                    [NameInMap("OperateTime")]
                    [Validation(Required=false)]
                    public string OperateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the user who submitted the ticket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1****</para>
                    /// </summary>
                    [NameInMap("OperatorId")]
                    [Validation(Required=false)]
                    public long? OperatorId { get; set; }

                    /// <summary>
                    /// <para>The approval status of the ticket. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>START</b>: The ticket was submitted.</description></item>
                    /// <item><description><b>ERROR</b>: An error occurred.</description></item>
                    /// <item><description><b>AUDITING</b>: The ticket is being reviewed.</description></item>
                    /// <item><description><b>REJECT</b>: The ticket was rejected.</description></item>
                    /// <item><description><b>CANCEL</b>: The ticket was revoked.</description></item>
                    /// <item><description><b>APPROVED</b>: The ticket was approved.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>APPROVED</para>
                    /// </summary>
                    [NameInMap("WorkflowInsCode")]
                    [Validation(Required=false)]
                    public string WorkflowInsCode { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingWorkflowInstanceId</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowInstanceId is mandatory for this action.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66DE630B-ECA1-52A3-9198-602066F9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
