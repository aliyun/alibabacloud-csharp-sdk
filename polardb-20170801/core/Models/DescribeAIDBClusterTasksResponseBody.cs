// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>polardb_ai</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3.1</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterTasksResponseBodyItems> Items { get; set; }
        public class DescribeAIDBClusterTasksResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-06-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("CompletedTime")]
            [Validation(Required=false)]
            public string CompletedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-25T09:37:10Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DBNodeDescription")]
            [Validation(Required=false)]
            public string DBNodeDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pm-2ze***</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("DBNodeStatusDesc")]
            [Validation(Required=false)]
            public string DBNodeStatusDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing-i</para>
            /// </summary>
            [NameInMap("DataZoneId")]
            [Validation(Required=false)]
            public string DataZoneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polardb_ai</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.1</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("ModelPath")]
            [Validation(Required=false)]
            public string ModelPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("ModelSource")]
            [Validation(Required=false)]
            public string ModelSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("RunningTimes")]
            [Validation(Required=false)]
            public string RunningTimes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-06-09T18:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sft</para>
            /// </summary>
            [NameInMap("TrainMode")]
            [Validation(Required=false)]
            public string TrainMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lora</para>
            /// </summary>
            [NameInMap("TrainType")]
            [Validation(Required=false)]
            public string TrainType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-2ze***</para>
        /// </summary>
        [NameInMap("RelativeDBClusterId")]
        [Validation(Required=false)]
        public string RelativeDBClusterId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>925B84D9-CA72-432C-95CF-738C22******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
