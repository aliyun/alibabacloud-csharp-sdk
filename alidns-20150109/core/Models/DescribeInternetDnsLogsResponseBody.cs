// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInternetDnsLogsResponseBody : TeaModel {
        [NameInMap("Complete")]
        [Validation(Required=false)]
        public bool? Complete { get; set; }

        [NameInMap("CurPage")]
        [Validation(Required=false)]
        public int? CurPage { get; set; }

        [NameInMap("Logs")]
        [Validation(Required=false)]
        public DescribeInternetDnsLogsResponseBodyLogs Logs { get; set; }
        public class DescribeInternetDnsLogsResponseBodyLogs : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<DescribeInternetDnsLogsResponseBodyLogsLog> Log { get; set; }
            public class DescribeInternetDnsLogsResponseBodyLogsLog : TeaModel {
                [NameInMap("DnsMsgId")]
                [Validation(Required=false)]
                public string DnsMsgId { get; set; }

                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public long? LogTime { get; set; }

                [NameInMap("QueryName")]
                [Validation(Required=false)]
                public string QueryName { get; set; }

                [NameInMap("QueryType")]
                [Validation(Required=false)]
                public string QueryType { get; set; }

                [NameInMap("Rt")]
                [Validation(Required=false)]
                public int? Rt { get; set; }

                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                [NameInMap("SourceIp")]
                [Validation(Required=false)]
                public string SourceIp { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubnetIp")]
                [Validation(Required=false)]
                public string SubnetIp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public DescribeInternetDnsLogsResponseBodyLogsLogValue Value { get; set; }
                public class DescribeInternetDnsLogsResponseBodyLogsLogValue : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public List<string> Value { get; set; }

                }

            }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
