// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOssBucketScanInfoResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOssBucketScanInfoResponseBodyData> Data { get; set; }
        public class ListOssBucketScanInfoResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the bucket.
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// Configuration status, valid values:
            /// 
            /// - **0**: No Configuration.
            /// - **1**: Not Open.
            /// - **2**: Open.
            /// </summary>
            [NameInMap("ConfigStatus")]
            [Validation(Required=false)]
            public int? ConfigStatus { get; set; }

            /// <summary>
            /// The number of high-risk objects.
            /// </summary>
            [NameInMap("HighRisk")]
            [Validation(Required=false)]
            public long? HighRisk { get; set; }

            /// <summary>
            /// The time when the most recent check ended. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastScanEndTime")]
            [Validation(Required=false)]
            public long? LastScanEndTime { get; set; }

            /// <summary>
            /// The time when the bucket was last checked. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// The number of low-risk objects.
            /// </summary>
            [NameInMap("LowRisk")]
            [Validation(Required=false)]
            public long? LowRisk { get; set; }

            /// <summary>
            /// The number of medium-risk objects.
            /// </summary>
            [NameInMap("MediumRisk")]
            [Validation(Required=false)]
            public long? MediumRisk { get; set; }

            /// <summary>
            /// The reason why the bucket cannot be checked.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of objects that are checked.
            /// </summary>
            [NameInMap("ScanObject")]
            [Validation(Required=false)]
            public long? ScanObject { get; set; }

            /// <summary>
            /// Indicates whether the bucket is checked. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Scanned")]
            [Validation(Required=false)]
            public bool? Scanned { get; set; }

            /// <summary>
            /// The check status of the bucket. Valid values:
            /// 
            /// *   **1**: The bucket is not checked.
            /// *   **2**: All objects in the bucket are being checked.
            /// *   **3**: Only new objects are being checked.
            /// *   **4**: The bucket is checked.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The storage class of the bucket. Valid values:
            /// 
            /// *   **Standard**
            /// *   **IA**
            /// *   **Archive**
            /// *   **ColdArchive**
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// Indicates whether the bucket can be checked. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Support")]
            [Validation(Required=false)]
            public bool? Support { get; set; }

            /// <summary>
            /// The total number of objects in the bucket.
            /// </summary>
            [NameInMap("TotalObject")]
            [Validation(Required=false)]
            public long? TotalObject { get; set; }

        }

        /// <summary>
        /// The page information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListOssBucketScanInfoResponseBodyPageInfo PageInfo { get; set; }
        public class ListOssBucketScanInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
