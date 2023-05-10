// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetFeatureDetailsRequest : TeaModel {
        /// <summary>
        /// The resource types that support the scenario feature.
        /// </summary>
        [NameInMap("Feature")]
        [Validation(Required=false)]
        public string Feature { get; set; }

        /// <summary>
        /// The resource types that support the system tag `acs:ros:stackId`.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
