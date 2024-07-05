// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTieringStorageDataResponseBody : TeaModel {
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
        public List<DescribeVodTieringStorageDataResponseBodyStorageData> StorageData { get; set; }
        public class DescribeVodTieringStorageDataResponseBodyStorageData : TeaModel {
            /// <summary>
            /// The data that is stored less than a month. Unit: bytes.
            /// </summary>
            [NameInMap("LessthanMonthDatasize")]
            [Validation(Required=false)]
            public long? LessthanMonthDatasize { get; set; }

            /// <summary>
            /// The region in which data is queried.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The storage type.
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// The storage usage. Unit: bytes.
            /// </summary>
            [NameInMap("StorageUtilization")]
            [Validation(Required=false)]
            public long? StorageUtilization { get; set; }

            /// <summary>
            /// The timestamp of the data returned. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

    }

}
