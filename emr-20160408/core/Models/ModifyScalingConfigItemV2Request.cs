// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ModifyScalingConfigItemV2Request : TeaModel {
        [NameInMap("ConfigItemBizId")]
        [Validation(Required=false)]
        public string ConfigItemBizId { get; set; }

        [NameInMap("ConfigItemInformation")]
        [Validation(Required=false)]
        public string ConfigItemInformation { get; set; }

        [NameInMap("ConfigItemType")]
        [Validation(Required=false)]
        public string ConfigItemType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ScalingGroupBizId")]
        [Validation(Required=false)]
        public string ScalingGroupBizId { get; set; }

    }

}
