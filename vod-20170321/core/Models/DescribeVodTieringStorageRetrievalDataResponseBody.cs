// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodTieringStorageRetrievalDataResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The data retrieval information.
        /// </summary>
        [NameInMap("RetrievalData")]
        [Validation(Required=false)]
        public List<DescribeVodTieringStorageRetrievalDataResponseBodyRetrievalData> RetrievalData { get; set; }
        public class DescribeVodTieringStorageRetrievalDataResponseBodyRetrievalData : TeaModel {
            /// <summary>
            /// The retrieved Cold Archive data in the bulk mode.
            /// </summary>
            [NameInMap("CABulkRetrievalData")]
            [Validation(Required=false)]
            public long? CABulkRetrievalData { get; set; }

            /// <summary>
            /// The retrieved Cold Archive data in the expedited mode.
            /// </summary>
            [NameInMap("CAHighPriorRetrievalData")]
            [Validation(Required=false)]
            public long? CAHighPriorRetrievalData { get; set; }

            /// <summary>
            /// The retrieved Cold Archive data in the standard mode.
            /// </summary>
            [NameInMap("CAStdRetrievalData")]
            [Validation(Required=false)]
            public long? CAStdRetrievalData { get; set; }

            /// <summary>
            /// The storage region.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The data retrieval information.
            /// </summary>
            [NameInMap("RetrievalData")]
            [Validation(Required=false)]
            public long? RetrievalData { get; set; }

            /// <summary>
            /// The storage type.
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// The timestamp of the returned data. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

    }

}
