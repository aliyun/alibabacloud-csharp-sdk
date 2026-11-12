// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAIDBClusterDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI database cluster. The cluster must have DBType set to polardb_ai. This parameter is required. If it is not provided, the service returns InvalidDBClusterId.Malformed (404).</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze88***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The name of the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset01</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The dataset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>train</b>: training dataset</description></item>
        /// <item><description><b>eval</b>: evaluation dataset</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>train</para>
        /// </summary>
        [NameInMap("DatasetType")]
        [Validation(Required=false)]
        public string DatasetType { get; set; }

        /// <summary>
        /// <para>The import method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LocalImport</b>: local import</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LocalImport</para>
        /// </summary>
        [NameInMap("ImportMode")]
        [Validation(Required=false)]
        public string ImportMode { get; set; }

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
        /// <para>The training mode for the dataset. Dataset formats vary by mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sft</b>: supervised fine-tuning, dedicated to training datasets</description></item>
        /// <item><description><b>grpo</b>: reinforcement learning optimization, dedicated to training datasets</description></item>
        /// <item><description><b>text</b>: text generation, dedicated to validation datasets</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sft</para>
        /// </summary>
        [NameInMap("TrainMode")]
        [Validation(Required=false)]
        public string TrainMode { get; set; }

    }

}
