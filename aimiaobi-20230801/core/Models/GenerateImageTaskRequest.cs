// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GenerateImageTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1be065b-adc3-435e-bd01-1c18c5ed75d3</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The task ID of the article. If you do not have one, you can assign a universally unique identifier (UUID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e1be065b-adc3-435e-bd01-1c18c5ed75d3</para>
        /// </summary>
        [NameInMap("ArticleTaskId")]
        [Validation(Required=false)]
        public string ArticleTaskId { get; set; }

        /// <summary>
        /// <para>The content of the paragraphs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ParagraphList")]
        [Validation(Required=false)]
        public List<GenerateImageTaskRequestParagraphList> ParagraphList { get; set; }
        public class GenerateImageTaskRequestParagraphList : TeaModel {
            /// <summary>
            /// <para>The content of the paragraph.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>一直忧伤的猫</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The paragraph ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The unique ID of the task.</para>
            /// <remarks>
            /// <para>By default, you do not need to specify this parameter. The system automatically generates a task ID. If you specify the same TaskId for subsequent tasks, these tasks are considered part of the same conversation group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>e1be065b-adc3-435e-bd01-1c18c5ed75d3</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The current status of the task.</para>
            /// <list type="bullet">
            /// <item><description><para>PENDING: The task is in the queue.</para>
            /// </description></item>
            /// <item><description><para>RUNNING: The task is in progress.</para>
            /// </description></item>
            /// <item><description><para>SUSPENDED: The task is suspended.</para>
            /// </description></item>
            /// <item><description><para>SUCCEEDED: The task was successful.</para>
            /// </description></item>
            /// <item><description><para>FAILED: The task failed.</para>
            /// </description></item>
            /// <item><description><para>UNKNOWN: The task does not exist or its status is unknown.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESSED</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The size of the image to generate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024*1024</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        /// <summary>
        /// <para>The style.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>\&quot;<auto>\&quot;</para>
        /// </summary>
        [NameInMap("Style")]
        [Validation(Required=false)]
        public string Style { get; set; }

    }

}
