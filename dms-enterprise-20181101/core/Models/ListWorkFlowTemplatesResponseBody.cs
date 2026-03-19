// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListWorkFlowTemplatesResponseBody : TeaModel {
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41067071-0243-4AAB-B3CF-4DE6D54F53B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
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
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public long? CreateUserId { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                [NameInMap("IsSystem")]
                [Validation(Required=false)]
                public int? IsSystem { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("WorkflowNodes")]
                [Validation(Required=false)]
                public ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodes WorkflowNodes { get; set; }
                public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodes : TeaModel {
                    [NameInMap("WorkflowNode")]
                    [Validation(Required=false)]
                    public List<ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodesWorkflowNode> WorkflowNode { get; set; }
                    public class ListWorkFlowTemplatesResponseBodyWorkFlowTemplatesWorkFlowTemplateWorkflowNodesWorkflowNode : TeaModel {
                        [NameInMap("Comment")]
                        [Validation(Required=false)]
                        public string Comment { get; set; }

                        [NameInMap("CreateUserId")]
                        [Validation(Required=false)]
                        public long? CreateUserId { get; set; }

                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public long? NodeId { get; set; }

                        [NameInMap("NodeName")]
                        [Validation(Required=false)]
                        public string NodeName { get; set; }

                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public long? TemplateId { get; set; }

                    }

                }

            }

        }

    }

}
