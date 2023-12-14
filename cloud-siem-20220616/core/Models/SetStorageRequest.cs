// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SetStorageRequest : TeaModel {
        /// <summary>
        /// The storage region of logs. By default, the region of the data management center is used and cannot be changed. cn-shanghai is used for the China data management center, and ap-southeast-1 is used for the Outside China data management center. To change the region, contact the technical support of threat analysis.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in the Chinese mainland or in the China (Hong Kong) region.
        /// *   ap-southeast-1: Your assets reside in regions outside the Chinese mainland, excluding the China (Hong Kong) region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The storage duration of logs. Default value: 180. Minimum value: 30. Maximum value: 3000. Unit: days.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
