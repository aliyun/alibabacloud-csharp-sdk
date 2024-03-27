// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetStorageResponseBody : TeaModel {
        /// <summary>
        /// The information about the storage.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetStorageResponseBodyData Data { get; set; }
        public class GetStorageResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the storage region can be changed for once. Default value: false Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("CanOperate")]
            [Validation(Required=false)]
            public bool? CanOperate { get; set; }

            /// <summary>
            /// Indicates whether the storage region can be changed. Default value: false Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("DisplayRegion")]
            [Validation(Required=false)]
            public bool? DisplayRegion { get; set; }

            /// <summary>
            /// The region where the data is stored.
            /// 
            /// If the data management center is **cn-hangzhou**, the default value of **Region** is cn-shanghai, which specifies the China (Shanghai) region. If the data management center is **ap-southeast-1**, the default value of **Region** is ap-southeast-1, which specifies the Singapore region.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The storage period of logs. Unit: day. Default value: 180. Valid values: 30 to 3000.
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
