// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_ai</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.1</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>A list of model operators.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterTasksResponseBodyItems> Items { get; set; }
        public class DescribeAIDBClusterTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("CompletedTime")]
            [Validation(Required=false)]
            public string CompletedTime { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-25T09:37:10Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The node description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBNodeDescription")]
            [Validation(Required=false)]
            public string DBNodeDescription { get; set; }

            /// <summary>
            /// <para>The model operator instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pm-2ze***</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The instance status. This parameter is not always returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>The description of the instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("DBNodeStatusDesc")]
            [Validation(Required=false)]
            public string DBNodeStatusDesc { get; set; }

            /// <summary>
            /// <para>The availability zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing-i</para>
            /// </summary>
            [NameInMap("DataZoneId")]
            [Validation(Required=false)]
            public string DataZoneId { get; set; }

            /// <summary>
            /// <para>The engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_ai</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.1</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The model path.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ModelPath")]
            [Validation(Required=false)]
            public string ModelPath { get; set; }

            /// <summary>
            /// <para>The model source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("ModelSource")]
            [Validation(Required=false)]
            public string ModelSource { get; set; }

            /// <summary>
            /// <para>The runtime parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("RunningTimes")]
            [Validation(Required=false)]
            public string RunningTimes { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The training mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sft</para>
            /// </summary>
            [NameInMap("TrainMode")]
            [Validation(Required=false)]
            public string TrainMode { get; set; }

            /// <summary>
            /// <para>The training type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lora</para>
            /// </summary>
            [NameInMap("TrainType")]
            [Validation(Required=false)]
            public string TrainType { get; set; }

        }

        /// <summary>
        /// <para>The PolarDB cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze***</para>
        /// </summary>
        [NameInMap("RelativeDBClusterId")]
        [Validation(Required=false)]
        public string RelativeDBClusterId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>925B84D9-CA72-432C-95CF-738C22******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
