// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class ModifyAutoScalingConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        [NameInMap("ConfigName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        [NameInMap("EffectiveTimeEnd")]
        [Validation(Required=false)]
        public string EffectiveTimeEnd { get; set; }

        [NameInMap("EffectiveTimeStart")]
        [Validation(Required=false)]
        public string EffectiveTimeStart { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NodesMax")]
        [Validation(Required=false)]
        public int? NodesMax { get; set; }

        [NameInMap("NodesMin")]
        [Validation(Required=false)]
        public int? NodesMin { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ScaleRuleList")]
        [Validation(Required=false)]
        public string ScaleRuleListShrink { get; set; }

        [NameInMap("ScaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("SpecId")]
        [Validation(Required=false)]
        public string SpecId { get; set; }

        [NameInMap("StorageCapacityMax")]
        [Validation(Required=false)]
        public long? StorageCapacityMax { get; set; }

    }

}
