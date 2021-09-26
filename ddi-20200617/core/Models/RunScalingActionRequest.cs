// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class RunScalingActionRequest : TeaModel {
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ScalingActionType")]
        [Validation(Required=false)]
        public string ScalingActionType { get; set; }

        [NameInMap("ScalingGroupBizId")]
        [Validation(Required=false)]
        public string ScalingGroupBizId { get; set; }

        [NameInMap("ActionParam")]
        [Validation(Required=false)]
        public string ActionParam { get; set; }

    }

}
