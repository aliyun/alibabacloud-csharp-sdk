// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DeployAppRequest : TeaModel {
        [NameInMap("ArmsFlag")]
        [Validation(Required=false)]
        public bool? ArmsFlag { get; set; }

        [NameInMap("ContainerImageList")]
        [Validation(Required=false)]
        public List<string> ContainerImageList { get; set; }

        [NameInMap("DefaultPacketOfAppGroup")]
        [Validation(Required=false)]
        public string DefaultPacketOfAppGroup { get; set; }

        [NameInMap("DeployPacketId")]
        [Validation(Required=false)]
        public long? DeployPacketId { get; set; }

        [NameInMap("DeployPacketUrl")]
        [Validation(Required=false)]
        public string DeployPacketUrl { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("InitContainerImageList")]
        [Validation(Required=false)]
        public List<string> InitContainerImageList { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PauseType")]
        [Validation(Required=false)]
        public string PauseType { get; set; }

        [NameInMap("TotalPartitions")]
        [Validation(Required=false)]
        public int? TotalPartitions { get; set; }

        [NameInMap("UpdateStrategyType")]
        [Validation(Required=false)]
        public string UpdateStrategyType { get; set; }

    }

}
