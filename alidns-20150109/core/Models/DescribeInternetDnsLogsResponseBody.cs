// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInternetDnsLogsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Complete")]
        [Validation(Required=false)]
        public bool? Complete { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurPage")]
        [Validation(Required=false)]
        public int? CurPage { get; set; }

        /// <summary>
        /// <para>The logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public DescribeInternetDnsLogsResponseBodyLogs Logs { get; set; }
        public class DescribeInternetDnsLogsResponseBodyLogs : TeaModel {
            [NameInMap("Log")]
            [Validation(Required=false)]
            public List<DescribeInternetDnsLogsResponseBodyLogsLog> Log { get; set; }
            public class DescribeInternetDnsLogsResponseBodyLogsLog : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3583</para>
                /// </summary>
                [NameInMap("DnsMsgId")]
                [Validation(Required=false)]
                public string DnsMsgId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1709196249000</para>
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public long? LogTime { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The domain name for which you want to query Domain Name System (DNS) records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("QueryName")]
                [Validation(Required=false)]
                public string QueryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("QueryType")]
                [Validation(Required=false)]
                public string QueryType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Rt")]
                [Validation(Required=false)]
                public int? Rt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>140.205.XX.XX</para>
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>59.82.XX.XX</para>
                /// </summary>
                [NameInMap("SourceIp")]
                [Validation(Required=false)]
                public string SourceIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NOERROR</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>170.33.XX.XX</para>
                /// </summary>
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

                /// <summary>
                /// <para>The zone name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
