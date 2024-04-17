// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SetStorageRequest : TeaModel {
        /// <summary>
        /// The storage region of logs.
        /// 
        /// If the data management center is **cn-hangzhou**, the default value of **Region** is cn-shanghai, which specifies the China (Shanghai) region. If the data management center is **ap-southeast-1**, the default value of **Region** is ap-southeast-1, which specifies the Singapore region.
        /// 
        /// The region for log storage cannot be changed. To change the region, contact the technical support of threat analysis.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The data management center of the threat analysis feature. Specify this parameter based on the region where your assets reside. Valid values:
        /// 
        /// *   cn-hangzhou: Your assets reside in regions in China.
        /// *   ap-southeast-1: Your assets reside in regions outside China.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// The storage duration of logs. Default value: 180. Minimum value: 30. Maximum value: 3000. Unit: days.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
