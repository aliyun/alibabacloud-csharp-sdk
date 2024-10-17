// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskResponseBody : TeaModel {
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
        /// <para>The ID of the request. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7838266C-E17B-58F4-B072-4DC356B58258</para>
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
        /// <para>The task node.</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public GetTaskResponseBodyTask Task { get; set; }
        public class GetTaskResponseBodyTask : TeaModel {
            /// <summary>
            /// <para>The ID of the task flow to which the node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7321</para>
            /// </summary>
            [NameInMap("DagId")]
            [Validation(Required=false)]
            public long? DagId { get; set; }

            /// <summary>
            /// <para>The position of the node on the Directed Acyclic Graph (DAG).</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;{\&quot;x\&quot;:0,\&quot;y\&quot;:0,\&quot;layoutType\&quot;:\&quot;Horizontal\&quot;}&quot;,  &quot;id&quot;: 51***}</para>
            /// </summary>
            [NameInMap("GraphParam")]
            [Validation(Required=false)]
            public string GraphParam { get; set; }

            /// <summary>
            /// <para>The advanced configuration for the node.</para>
            /// </summary>
            [NameInMap("NodeConfig")]
            [Validation(Required=false)]
            public string NodeConfig { get; set; }

            /// <summary>
            /// <para>The configuration for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;dbList\&quot;:[{\&quot;instanceId\&quot;:177****}&quot;   }</para>
            /// </summary>
            [NameInMap("NodeContent")]
            [Validation(Required=false)]
            public string NodeContent { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cross-database Spark SQL-1</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The output variables for the node. This parameter is available only for some types of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;outputs&quot;:[ &quot;extractMethod&quot;:&quot;json&quot; , &quot;variableName&quot;:&quot;var&quot;,   &quot;description&quot;:&quot;demo desc&quot; } ] }</para>
            /// </summary>
            [NameInMap("NodeOutput")]
            [Validation(Required=false)]
            public string NodeOutput { get; set; }

            /// <summary>
            /// <para>The type of the node. For more information about the valid values for this parameter, see <a href="https://help.aliyun.com/document_detail/424705.html">NodeType parameter</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SPARK_SQL</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The time variables configured for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;variables\&quot;:[{\&quot;name\&quot;:\&quot;Today\&quot;,\&quot;pattern\&quot;:\&quot;yyyy-MM-dd|+1d\&quot;}]}</para>
            /// </summary>
            [NameInMap("TimeVariables")]
            [Validation(Required=false)]
            public string TimeVariables { get; set; }

        }

    }

}
