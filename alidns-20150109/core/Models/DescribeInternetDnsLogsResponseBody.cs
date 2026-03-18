// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInternetDnsLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the log query is precise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Complete")]
        [Validation(Required=false)]
        public bool? Complete { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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

                [NameInMap("Flags")]
                [Validation(Required=false)]
                public string Flags { get; set; }

                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public long? LogTime { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("QueryFlags")]
                [Validation(Required=false)]
                public string QueryFlags { get; set; }

                [NameInMap("QueryName")]
                [Validation(Required=false)]
                public string QueryName { get; set; }

                [NameInMap("QueryType")]
                [Validation(Required=false)]
                public string QueryType { get; set; }

                [NameInMap("ResponseTimestamp")]
                [Validation(Required=false)]
                public string ResponseTimestamp { get; set; }

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

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        /// <summary>
        /// <para>Page size for query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Unique request identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// <para>Total quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
