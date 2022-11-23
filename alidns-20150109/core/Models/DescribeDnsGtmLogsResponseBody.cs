// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmLogsResponseBody : TeaModel {
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public DescribeDnsGtmLogsResponseBodyLogs Logs { get; set; }
        public class DescribeDnsGtmLogsResponseBodyLogs : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmLogsResponseBodyLogsLog> Log { get; set; }
            public class DescribeDnsGtmLogsResponseBodyLogsLog : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("OperAction")]
                [Validation(Required=false)]
                public string OperAction { get; set; }

                [NameInMap("OperTime")]
                [Validation(Required=false)]
                public string OperTime { get; set; }

                [NameInMap("OperTimestamp")]
                [Validation(Required=false)]
                public long? OperTimestamp { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
