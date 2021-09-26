// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeScalingGroupResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ActiveStatus")]
        [Validation(Required=false)]
        public string ActiveStatus { get; set; }

        [NameInMap("HostGroupBizId")]
        [Validation(Required=false)]
        public string HostGroupBizId { get; set; }

        [NameInMap("ScalingInMode")]
        [Validation(Required=false)]
        public string ScalingInMode { get; set; }

        [NameInMap("ScalingMinSize")]
        [Validation(Required=false)]
        public long? ScalingMinSize { get; set; }

        [NameInMap("ScalingMaxSize")]
        [Validation(Required=false)]
        public long? ScalingMaxSize { get; set; }

        [NameInMap("ConfigState")]
        [Validation(Required=false)]
        public string ConfigState { get; set; }

    }

}
