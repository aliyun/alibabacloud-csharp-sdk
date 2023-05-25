// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkFlowTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The approval templates.
        /// </summary>
        [NameInMap("WorkFlowTemplates")]
        [Validation(Required=false)]
        public ListWorkFlowTemplatesResponseBodyWorkFlowTemplates WorkFlowTemplates { get; set; }
        public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplates : TeaModel {
            [NameInMap("WorkFlowTemplate")]
            [Validation(Required=false)]
            public List<ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplate> WorkFlowTemplate { get; set; }
            public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplate : TeaModel {
                /// <summary>
                /// The description of the approval template.
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// The ID of the creator.
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public long? CreateUserId { get; set; }

                /// <summary>
                /// Indicates whether the approval template is enabled. Valid values:
                /// 
                /// *   Y: The approval template is enabled.
                /// *   N: The approval template is disabled.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// Indicates whether the approval template is predefined by the system. Valid values:
                /// 
                /// *   1: The approval template is predefined by the system.
                /// *   0: The approval template is not predefined by the system.
                /// </summary>
                [NameInMap("IsSystem")]
                [Validation(Required=false)]
                public int? IsSystem { get; set; }

                /// <summary>
                /// The ID of the approval template.
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// The name of the approval template.
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// The details of approval nodes.
                /// </summary>
                [NameInMap("WorkflowNodes")]
                [Validation(Required=false)]
                public ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodes WorkflowNodes { get; set; }
                public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodes : TeaModel {
                    [NameInMap("WorkflowNode")]
                    [Validation(Required=false)]
                    public List<ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodesWorkflowNode> WorkflowNode { get; set; }
                    public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodesWorkflowNode : TeaModel {
                        /// <summary>
                        /// The description of the approval node.
                        /// </summary>
                        [NameInMap("Comment")]
                        [Validation(Required=false)]
                        public string Comment { get; set; }

                        /// <summary>
                        /// The ID of the creator.
                        /// </summary>
                        [NameInMap("CreateUserId")]
                        [Validation(Required=false)]
                        public long? CreateUserId { get; set; }

                        /// <summary>
                        /// The ID of the approval node.
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public long? NodeId { get; set; }

                        /// <summary>
                        /// The name of the approval node.
                        /// </summary>
                        [NameInMap("NodeName")]
                        [Validation(Required=false)]
                        public string NodeName { get; set; }

                        /// <summary>
                        /// The type of the approval node. Valid values:
                        /// 
                        /// *   SYS: The approval node is predefined by the system.
                        /// *   USER_LIST: The approval node is created by a user.
                        /// </summary>
                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        /// <summary>
                        /// The position of the approval node.
                        /// </summary>
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        /// <summary>
                        /// The ID of the template.
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public long? TemplateId { get; set; }

                    }

                }

            }

        }

    }

}
