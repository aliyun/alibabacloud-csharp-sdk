// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeScalingConfigItemResponseBody : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("ConfigItemType")]
        [Validation(Required=false)]
        public string ConfigItemType { get; set; }

        [NameInMap("ScalingGroupBizId")]
        [Validation(Required=false)]
        public string ScalingGroupBizId { get; set; }

        [NameInMap("ScalingConfigItemBizId")]
        [Validation(Required=false)]
        public string ScalingConfigItemBizId { get; set; }

        [NameInMap("ConfigItemInformation")]
        [Validation(Required=false)]
        public string ConfigItemInformation { get; set; }

    }

}
