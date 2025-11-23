// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class PreviewWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID. You can use the request ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The details of the workflow.</para>
        /// </summary>
        [NameInMap("WorkflowDetail")]
        [Validation(Required=false)]
        public PreviewWorkflowResponseBodyWorkflowDetail WorkflowDetail { get; set; }
        public class PreviewWorkflowResponseBodyWorkflowDetail : TeaModel {
            /// <summary>
            /// <para>The remarks of the approval template.</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The name of the approval template.</para>
            /// </summary>
            [NameInMap("WfCateName")]
            [Validation(Required=false)]
            public string WfCateName { get; set; }

            /// <summary>
            /// <para>The approval nodes.</para>
            /// </summary>
            [NameInMap("WorkflowNodeList")]
            [Validation(Required=false)]
            public PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeList WorkflowNodeList { get; set; }
            public class PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeList : TeaModel {
                [NameInMap("WorkflowNode")]
                [Validation(Required=false)]
                public List<PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNode> WorkflowNode { get; set; }
                public class PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNode : TeaModel {
                    /// <summary>
                    /// <para>The approvers.</para>
                    /// </summary>
                    [NameInMap("AuditUserList")]
                    [Validation(Required=false)]
                    public PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNodeAuditUserList AuditUserList { get; set; }
                    public class PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNodeAuditUserList : TeaModel {
                        [NameInMap("AuditUser")]
                        [Validation(Required=false)]
                        public List<PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNodeAuditUserListAuditUser> AuditUser { get; set; }
                        public class PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNodeAuditUserListAuditUser : TeaModel {
                            /// <summary>
                            /// <para>The nickname of the approver.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Owner</para>
                            /// </summary>
                            [NameInMap("NickName")]
                            [Validation(Required=false)]
                            public string NickName { get; set; }

                            /// <summary>
                            /// <para>The name of the approver.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>db_test</para>
                            /// </summary>
                            [NameInMap("RealName")]
                            [Validation(Required=false)]
                            public string RealName { get; set; }

                            /// <summary>
                            /// <para>The ID of the approver.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>16***</para>
                            /// </summary>
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public long? UserId { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The remarks of the approval node.</para>
                    /// </summary>
                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <para>The name of the approval node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Owner</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// <para>The type of the approval node.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>USER_LIST: The approval node is created by a user.</description></item>
                    /// <item><description>UNKNOWN: The source of the approval node is unknown.</description></item>
                    /// <item><description>SYS: The approval node is predefined by the system.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SYS</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                }

            }

        }

    }

}
