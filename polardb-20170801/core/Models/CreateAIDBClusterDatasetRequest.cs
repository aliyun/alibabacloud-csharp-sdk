// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAIDBClusterDatasetRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the PolarDB database cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze88***</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The dataset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataset01</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The type of the dataset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>train</b>: training set</para>
        /// </description></item>
        /// <item><description><para><b>eval</b>: evaluation set</para>
        /// </description></item>
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
        /// <para>The training mode for the dataset. The dataset format depends on the mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sft</b>: supervised fine-tuning. For training sets only.</para>
        /// </description></item>
        /// <item><description><para><b>grpo</b>: reinforcement learning optimization. For training sets only.</para>
        /// </description></item>
        /// <item><description><para><b>text</b>: text generation. For validation sets only.</para>
        /// </description></item>
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
