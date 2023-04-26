// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodStorageDataResponseBody : TeaModel {
        /// <summary>
        /// The time granularity at which the data was queried. Valid values:
        /// 
        /// *   **hour**
        /// *   **day**
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The storage usage data returned.
        /// </summary>
        [NameInMap("StorageData")]
        [Validation(Required=false)]
        public DescribeVodStorageDataResponseBodyStorageData StorageData { get; set; }
        public class DescribeVodStorageDataResponseBodyStorageData : TeaModel {
            [NameInMap("StorageDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodStorageDataResponseBodyStorageDataStorageDataItem> StorageDataItem { get; set; }
            public class DescribeVodStorageDataResponseBodyStorageDataStorageDataItem : TeaModel {
                /// <summary>
                /// The outbound traffic. Unit: bytes. The outbound traffic is generated when videos are directly downloaded or played from OSS buckets without Alibaba Cloud CDN acceleration.
                /// </summary>
                [NameInMap("NetworkOut")]
                [Validation(Required=false)]
                public string NetworkOut { get; set; }

                /// <summary>
                /// The detailed usage data of storage-related resources. Unit: bytes.
                /// </summary>
                [NameInMap("StorageUtilization")]
                [Validation(Required=false)]
                public string StorageUtilization { get; set; }

                /// <summary>
                /// The timestamp of the returned data. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
