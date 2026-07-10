// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterTaskAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The access information of the model in the test deployment scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;networkInterfaceId\&quot;:\&quot;eni-2zea***\&quot;,\&quot;port\&quot;:\&quot;8000\&quot;,\&quot;host\&quot;:\&quot;192.<b>.</b>.**\&quot;}</para>
        /// </summary>
        [NameInMap("AccessInfo")]
        [Validation(Required=false)]
        public string AccessInfo { get; set; }

        /// <summary>
        /// <para>The network type of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-12T03:45:13Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task01</para>
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-2ze99***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The training status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ACTIVATION</b>: Training in progress.</description></item>
        /// <item><description><b>COMPLETED</b>: Training succeeded.</description></item>
        /// <item><description><b>FAILED</b>: Training failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// <para>The training status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ACTIVATION</b>: Training in progress.</description></item>
        /// <item><description><b>COMPLETED</b>: Training succeeded.</description></item>
        /// <item><description><b>FAILED</b>: Training failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETED</para>
        /// </summary>
        [NameInMap("DBClusterStatusDesc")]
        [Validation(Required=false)]
        public string DBClusterStatusDesc { get; set; }

        /// <summary>
        /// <para>The engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb_ai</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3.1</b>: model operator tuning.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3.1</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        /// <summary>
        /// <para>The datasets.</para>
        /// </summary>
        [NameInMap("DataSets")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterTaskAttributeResponseBodyDataSets> DataSets { get; set; }
        public class DescribeAIDBClusterTaskAttributeResponseBodyDataSets : TeaModel {
            /// <summary>
            /// <para>The dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataset02</para>
            /// </summary>
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            /// <summary>
            /// <para>The dataset path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polardb_ai/datasets/train/grpo/dataset02/test-**.jsonl#1000</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The ratio of data split from the training set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1</para>
            /// </summary>
            [NameInMap("SplitDatasetRatio")]
            [Validation(Required=false)]
            public string SplitDatasetRatio { get; set; }

            /// <summary>
            /// <para>The type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>train</b>: training set.</description></item>
            /// <item><description><b>eval</b>: validation set.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>train</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The additional information, including runtime parameters.</para>
        /// </summary>
        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ExtraInfo { get; set; }

        /// <summary>
        /// <para>The type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>18</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("KindCode")]
        [Validation(Required=false)]
        public long? KindCode { get; set; }

        /// <summary>
        /// <para>The lock mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Locked.</description></item>
        /// <item><description><b>1</b>: Unlocked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The maintenance end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The maintenance start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The list of output model paths in the model fine-tuning scenario.</para>
        /// </summary>
        [NameInMap("ModelPath")]
        [Validation(Required=false)]
        public string ModelPath { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>45D24263-7E3A-4140-9472-************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task information.</para>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterTaskAttributeResponseBodyTaskInfo> TaskInfo { get; set; }
        public class DescribeAIDBClusterTaskAttributeResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The task completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-10T01:56:00Z</para>
            /// </summary>
            [NameInMap("CompletedTime")]
            [Validation(Required=false)]
            public string CompletedTime { get; set; }

            /// <summary>
            /// <para>The foundation model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen-1.7B</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>The path of the custom model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen-1.7B</para>
            /// </summary>
            [NameInMap("ModelPath")]
            [Validation(Required=false)]
            public string ModelPath { get; set; }

            /// <summary>
            /// <para>The model source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>public</b>: pre-trained model.</description></item>
            /// <item><description><b>custom</b>: custom model.</description></item>
            /// </list>
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
            /// <para>{&quot;split_dataset_ratio&quot;: 0.1,&quot;train_mode&quot;: &quot;grpo&quot;,&quot;train_type&quot;: &quot;lora&quot;,&quot;num_epochs&quot;: 1,&quot;batch_size&quot;: 2,&quot;eval_batch_size&quot;: 2, &quot;num_generations&quot;: 2, &quot;learning_rate&quot;: &quot;1e-6&quot;, &quot;data_file_list&quot;: &quot;test-00000-of-00001.jsonl#1000&quot;, &quot;lora_rank&quot;: 8, &quot;lora_alpha&quot;: 32, &quot;external_plugins&quot;: &quot;/plugin/train/plugin.py&quot;, &quot;reward_funcs&quot;: &quot;format,external_countdown&quot;, &quot;gpu_memory_utilization&quot;: 0.4}</para>
            /// </summary>
            [NameInMap("RunningTimes")]
            [Validation(Required=false)]
            public string RunningTimes { get; set; }

            /// <summary>
            /// <para>The task start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-09-10T01:56:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sft</b>: SFT-efficient training.</description></item>
            /// <item><description><b>grpo</b>: GRPO-reinforcement learning.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>stf</para>
            /// </summary>
            [NameInMap("TrainMode")]
            [Validation(Required=false)]
            public string TrainMode { get; set; }

            /// <summary>
            /// <para>The training method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>lora</b></description></item>
            /// <item><description><b>full</b>: full-parameter training.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lora</para>
            /// </summary>
            [NameInMap("TrainType")]
            [Validation(Required=false)]
            public string TrainType { get; set; }

        }

        [NameInMap("TuneArch")]
        [Validation(Required=false)]
        public string TuneArch { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
