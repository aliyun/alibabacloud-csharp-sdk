// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeScalingConfigItemV2ResponseBody : TeaModel {
        [NameInMap("ConfigItemInformation")]
        [Validation(Required=false)]
        public string ConfigItemInformation { get; set; }

        [NameInMap("ConfigItemType")]
        [Validation(Required=false)]
        public string ConfigItemType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingConfigItemBizId")]
        [Validation(Required=false)]
        public string ScalingConfigItemBizId { get; set; }

        [NameInMap("ScalingGroupBizId")]
        [Validation(Required=false)]
        public string ScalingGroupBizId { get; set; }

    }

}
