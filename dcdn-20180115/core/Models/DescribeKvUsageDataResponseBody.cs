// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeKvUsageDataResponseBody : TeaModel {
        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The detailed usage data.
        /// </summary>
        [NameInMap("KvUsageData")]
        [Validation(Required=false)]
        public List<DescribeKvUsageDataResponseBodyKvUsageData> KvUsageData { get; set; }
        public class DescribeKvUsageDataResponseBodyKvUsageData : TeaModel {
            /// <summary>
            /// The number of visits.
            /// </summary>
            [NameInMap("Acc")]
            [Validation(Required=false)]
            public long? Acc { get; set; }

            /// <summary>
            /// The request method. This parameter is returned only if **SplitBy** is set to **type**.
            /// </summary>
            [NameInMap("AccessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// The ID of the namespace. This parameter is returned only if **SplitBy** is set to **namespace**.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The timestamp of the data returned.
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
