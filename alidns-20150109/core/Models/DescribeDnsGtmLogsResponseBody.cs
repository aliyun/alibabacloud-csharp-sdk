// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmLogsResponseBody : TeaModel {
        /// <summary>
        /// The returned logs.
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public DescribeDnsGtmLogsResponseBodyLogs Logs { get; set; }
        public class DescribeDnsGtmLogsResponseBodyLogs : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmLogsResponseBodyLogsLog> Log { get; set; }
            public class DescribeDnsGtmLogsResponseBodyLogsLog : TeaModel {
                /// <summary>
                /// The formatted message content.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The ID of the object on which the operation was performed.
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// The name of the object on which the operation was performed.
                /// </summary>
                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                /// <summary>
                /// The type of the object on which the operation was performed.
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// The ID of the record.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The operation performed.
                /// </summary>
                [NameInMap("OperAction")]
                [Validation(Required=false)]
                public string OperAction { get; set; }

                /// <summary>
                /// The time when the operation was performed.
                /// </summary>
                [NameInMap("OperTime")]
                [Validation(Required=false)]
                public string OperTime { get; set; }

                /// <summary>
                /// The timestamp of the operation.
                /// </summary>
                [NameInMap("OperTimestamp")]
                [Validation(Required=false)]
                public long? OperTimestamp { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned on all pages.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
