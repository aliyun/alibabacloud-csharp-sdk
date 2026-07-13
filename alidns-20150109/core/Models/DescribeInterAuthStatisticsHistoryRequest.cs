// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInterAuthStatisticsHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.&lt;props=&quot;china&quot;&gt;You can get this value by calling the <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c4g.11186623.help-menu-search-29697.d_0">DescribeDomains</a> operation.
        /// &lt;props=&quot;intl&quot;&gt;You can get this value by calling the <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describedomains?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDomains</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dns-example.top</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a Unix timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>Warning: A large time range for a domain with a high volume of resolution logs may cause query timeouts or inaccurate results.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1741526400000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>The DNS response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Rcode")]
        [Validation(Required=false)]
        public string Rcode { get; set; }

        /// <summary>
        /// <para>The server region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-3</para>
        /// </summary>
        [NameInMap("ServerRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This value is a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1474335170000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>The statistical metric type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROTOCOL
        /// 其它：
        /// PROTOCOL：DNS请求UDP协议、TCP协议维度统计（仅全局域名统计）
        /// QTYPE：DNS请求记录类型分布，如A、AAAA、CNAME、MX 等
        /// RCODE：DNS否定应答统计
        /// SUCCESS_RATIO：SUCCESS_RATIO：平均解析成功率（解析成功率 = 返回与请求记录类型（QTYPE）匹配的有效应答次数 / 总解析次数）
        /// REQUEST：DNS请求量统计，展示QPS查询趋势</para>
        /// </summary>
        [NameInMap("StatisticalType")]
        [Validation(Required=false)]
        public string StatisticalType { get; set; }

        /// <summary>
        /// <para>The zone name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lisheng999.com</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

    }

}
