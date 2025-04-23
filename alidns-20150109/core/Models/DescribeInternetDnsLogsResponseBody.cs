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

        /// <summary>
        /// <para>The queried logs.</para>
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
                /// <para>Parse log ID (can be duplicated).</para>
                /// 
                /// <b>Example:</b>
                /// <para>3583</para>
                /// </summary>
                [NameInMap("DnsMsgId")]
                [Validation(Required=false)]
                public string DnsMsgId { get; set; }

                /// <summary>
                /// <para>Parse timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1709196249000</para>
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public long? LogTime { get; set; }

                /// <summary>
                /// <para>The protocol type of the domain name resolution query request:</para>
                /// <list type="bullet">
                /// <item><description>UDP</description></item>
                /// <item><description>TCP</description></item>
                /// <item><description>HTTP</description></item>
                /// <item><description>HTTPS</description></item>
                /// <item><description>DOH</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UDP</para>
                /// </summary>
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
                /// <para>Record type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("QueryType")]
                [Validation(Required=false)]
                public string QueryType { get; set; }

                /// <summary>
                /// <para>Parse response time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Rt")]
                [Validation(Required=false)]
                public int? Rt { get; set; }

                /// <summary>
                /// <para>Parse server IP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>140.205.XX.XX</para>
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// <para>Source IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>59.82.XX.XX</para>
                /// </summary>
                [NameInMap("SourceIp")]
                [Validation(Required=false)]
                public string SourceIp { get; set; }

                /// <summary>
                /// <para>Response status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NOERROR</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The value set for the edns-client-subnet option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>170.33.XX.XX</para>
                /// </summary>
                [NameInMap("SubnetIp")]
                [Validation(Required=false)]
                public string SubnetIp { get; set; }

                /// <summary>
                /// <para>Array of parsing results.</para>
                /// </summary>
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
