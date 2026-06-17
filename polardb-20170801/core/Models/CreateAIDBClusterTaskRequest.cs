// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAIDBClusterTaskRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.pg.g6.4xlarge.guh</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the training dataset. This parameter is required for fine-tuning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pds-2zetrain***</para>
        /// </summary>
        [NameInMap("DatasetPath")]
        [Validation(Required=false)]
        public string DatasetPath { get; set; }

        /// <summary>
        /// <para>The ID of the validation dataset. This parameter is required for evaluation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pds-2zetrain***</para>
        /// </summary>
        [NameInMap("EvalDatasetPath")]
        [Validation(Required=false)]
        public string EvalDatasetPath { get; set; }

        /// <summary>
        /// <para>The type of model service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>aitrain</b>: For model operator tuning.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aitrain</para>
        /// </summary>
        [NameInMap("KubeType")]
        [Validation(Required=false)]
        public string KubeType { get; set; }

        /// <summary>
        /// <para>The model name.</para>
        /// <list type="bullet">
        /// <item><description><para>For a <b>preset model</b>, specify the model name.</para>
        /// </description></item>
        /// <item><description><para>For a <b>custom model</b>, specify the path to the model. This option is for models trained in a cold storage edition instance.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen3-8B</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>public</b>: A preset model.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: A custom model.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("ModelSource")]
        [Validation(Required=false)]
        public string ModelSource { get; set; }

        /// <summary>
        /// <para>The type of the custom model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3</para>
        /// </summary>
        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The runtime parameters, specified as a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;split_dataset_ratio&quot;: 0.1,&quot;train_mode&quot;: &quot;grpo&quot;,&quot;train_type&quot;: &quot;lora&quot;,&quot;num_epochs&quot;: 1,&quot;batch_size&quot;: 2,&quot;eval_batch_size&quot;: 2, &quot;num_generations&quot;: 2, &quot;learning_rate&quot;: &quot;1e-6&quot;, &quot;data_file_list&quot;: &quot;test-00000-of-00001.jsonl#1000&quot;, &quot;lora_rank&quot;: 8, &quot;lora_alpha&quot;: 32, &quot;external_plugins&quot;: &quot;/plugin/train/plugin.py&quot;, &quot;reward_funcs&quot;: &quot;format,external_countdown&quot;, &quot;gpu_memory_utilization&quot;: 0.4}</para>
        /// </summary>
        [NameInMap("RunningParameter")]
        [Validation(Required=false)]
        public string RunningParameter { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp**************</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*******************</para>
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

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
