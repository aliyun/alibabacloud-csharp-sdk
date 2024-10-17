// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTasksInTaskFlowResponseBody : TeaModel {
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
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B36B063-6B7D-5595-9FCF-3844B7B7ACD4</para>
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
        /// <para>The tasks in the task flow.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public ListTasksInTaskFlowResponseBodyTasks Tasks { get; set; }
        public class ListTasksInTaskFlowResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<ListTasksInTaskFlowResponseBodyTasksTask> Task { get; set; }
            public class ListTasksInTaskFlowResponseBodyTasksTask : TeaModel {
                /// <summary>
                /// <para>The position of the node on the Directed Acyclic Graph (DAG).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;x\&quot;:435,\&quot;y\&quot;:192,\&quot;layoutType\&quot;:\&quot;Horizontal\&quot;}</para>
                /// </summary>
                [NameInMap("GraphParam")]
                [Validation(Required=false)]
                public string GraphParam { get; set; }

                /// <summary>
                /// <para>The advanced configuration for the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{     &quot;rerun&quot;:{    &quot;rerunEnable&quot;:true,      &quot;rerunCount&quot;:1,   &quot;rerunInterval&quot;:10 //  }}</para>
                /// </summary>
                [NameInMap("NodeConfig")]
                [Validation(Required=false)]
                public string NodeConfig { get; set; }

                /// <summary>
                /// <para>The configuration for the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{     &quot;dbId&quot;:123***,  &quot;sql&quot;:&quot;&quot;,    &quot;dbType&quot;:&quot;polardb&quot; }</para>
                /// </summary>
                [NameInMap("NodeContent")]
                [Validation(Required=false)]
                public string NodeContent { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>92***</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cross-Database Spark SQL-1</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The output variables for the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{  &quot;outputs&quot;:[{ { &quot;row&quot;:0, &quot;column&quot;:-1,                  &quot;combiner&quot;:&quot;,&quot; }            &quot;extractMethod&quot;:&quot;{\&quot;row\&quot;:0,\&quot;column\&quot;:-1,\&quot;combiner\&quot;:\&quot;,\&quot;}&quot;,         &quot;variableName&quot;:&quot;var&quot;,    &quot;description&quot;:&quot;For demo&quot;} ] }</para>
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
                /// <para>{\&quot;variables\&quot;:[{\&quot;name\&quot;:\&quot;test1\&quot;,\&quot;pattern\&quot;:\&quot;yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("TimeVariables")]
                [Validation(Required=false)]
                public string TimeVariables { get; set; }

            }

        }

    }

}
