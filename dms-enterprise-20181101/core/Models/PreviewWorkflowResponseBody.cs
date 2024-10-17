// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class PreviewWorkflowResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("WorkflowDetail")]
        [Validation(Required=false)]
        public PreviewWorkflowResponseBodyWorkflowDetail WorkflowDetail { get; set; }
        public class PreviewWorkflowResponseBodyWorkflowDetail : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("WfCateName")]
            [Validation(Required=false)]
            public string WfCateName { get; set; }

            [NameInMap("WorkflowNodeList")]
            [Validation(Required=false)]
            public PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeList WorkflowNodeList { get; set; }
            public class PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeList : TeaModel {
                [NameInMap("WorkflowNode")]
                [Validation(Required=false)]
                public List<PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNode> WorkflowNode { get; set; }
                public class PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNode : TeaModel {
                    [NameInMap("AuditUserList")]
                    [Validation(Required=false)]
                    public PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNodeAuditUserList AuditUserList { get; set; }
                    public class PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNodeAuditUserList : TeaModel {
                        [NameInMap("AuditUser")]
                        [Validation(Required=false)]
                        public List<PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNodeAuditUserListAuditUser> AuditUser { get; set; }
                        public class PreviewWorkflowResponseBodyWorkflowDetailWorkflowNodeListWorkflowNodeAuditUserListAuditUser : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>Owner</para>
                            /// </summary>
                            [NameInMap("NickName")]
                            [Validation(Required=false)]
                            public string NickName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>db_test</para>
                            /// </summary>
                            [NameInMap("RealName")]
                            [Validation(Required=false)]
                            public string RealName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>16***</para>
                            /// </summary>
                            [NameInMap("UserId")]
                            [Validation(Required=false)]
                            public long? UserId { get; set; }

                        }

                    }

                    [NameInMap("Comment")]
                    [Validation(Required=false)]
                    public string Comment { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Owner</para>
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
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
