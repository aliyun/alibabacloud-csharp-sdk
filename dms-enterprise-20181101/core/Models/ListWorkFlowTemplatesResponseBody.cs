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

        /// <summary>
        /// <para>The approval templates.</para>
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
                /// <para>The description of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("CreateUserId")]
                [Validation(Required=false)]
                public long? CreateUserId { get; set; }

                /// <summary>
                /// <para>Indicates whether the approval template is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Y: The approval template is enabled.</description></item>
                /// <item><description>N: The approval template is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the approval template is predefined by the system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: The approval template is predefined by the system.</description></item>
                /// <item><description>0: The approval template is not predefined by the system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsSystem")]
                [Validation(Required=false)]
                public int? IsSystem { get; set; }

                /// <summary>
                /// <para>The ID of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <para>The name of the approval template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Admin</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <para>The details of approval nodes.</para>
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
                        /// <para>The description of the approval node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Comment")]
                        [Validation(Required=false)]
                        public string Comment { get; set; }

                        /// <summary>
                        /// <para>The ID of the creator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1234</para>
                        /// </summary>
                        [NameInMap("CreateUserId")]
                        [Validation(Required=false)]
                        public long? CreateUserId { get; set; }

                        /// <summary>
                        /// <para>The ID of the approval node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public long? NodeId { get; set; }

                        /// <summary>
                        /// <para>The name of the approval node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("NodeName")]
                        [Validation(Required=false)]
                        public string NodeName { get; set; }

                        /// <summary>
                        /// <para>The type of the approval node. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>SYS: The approval node is predefined by the system.</description></item>
                        /// <item><description>USER_LIST: The approval node is created by a user.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SYS</para>
                        /// </summary>
                        [NameInMap("NodeType")]
                        [Validation(Required=false)]
                        public string NodeType { get; set; }

                        /// <summary>
                        /// <para>The position of the approval node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Position")]
                        [Validation(Required=false)]
                        public int? Position { get; set; }

                        /// <summary>
                        /// <para>The ID of the template.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>12345</para>
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
