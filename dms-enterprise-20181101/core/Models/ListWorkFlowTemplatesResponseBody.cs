// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkFlowTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("WorkFlowTemplates")]
        [Validation(Required=false)]
        public ListWorkFlowTemplatesResponseBodyWorkFlowTemplates WorkFlowTemplates { get; set; }
        public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplates : TeaModel {
            [NameInMap("WorkFlowTemplate")]
            [Validation(Required=false)]
            public List<ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplate> WorkFlowTemplate { get; set; }
            public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplate : TeaModel {
                public int? IsSystem { get; set; }
                public ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodes WorkflowNodes { get; set; }
                public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodes : TeaModel {
                    [NameInMap("WorkflowNode")]
                    [Validation(Required=false)]
                    public List<ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodesWorkflowNode> WorkflowNode { get; set; }
                    public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodesWorkflowNode : TeaModel {
                        [NameInMap("Comment")]
                        [Validation(Required=false)]
                        public string Comment { get; set; }

                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        [NameInMap("NodeName")]
                        [Validation(Required=false)]
                        public string NodeName { get; set; }

                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        [NameInMap("CreateUserId")]
                        [Validation(Required=false)]
                        public long? CreateUserId { get; set; }

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public long? TemplateId { get; set; }

                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public long? NodeId { get; set; }

                    }

                }
                public string Comment { get; set; }
                public string Enabled { get; set; }
                public string TemplateName { get; set; }
                public long? TemplateId { get; set; }
                public long? CreateUserId { get; set; }
            }
        };

    }

}
