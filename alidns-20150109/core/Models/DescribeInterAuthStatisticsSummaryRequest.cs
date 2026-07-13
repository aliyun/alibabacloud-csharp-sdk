// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInterAuthStatisticsSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DESC (default): descending order</para>
        /// </description></item>
        /// <item><description><para>ASC: ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>Warning: If the query time range is large and the domain name has an excessive volume of resolution logs, the query may time out or return inaccurate results..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1741526400000</para>
        /// </summary>
        [NameInMap("EndTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>Used for the report of subdomain names with sudden increases or decreases in request volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up
        /// down</para>
        /// </summary>
        [NameInMap("GrowType")]
        [Validation(Required=false)]
        public string GrowType { get; set; }

        /// <summary>
        /// <para>The sort parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>createDate: sorts by creation time (default if left empty)</description></item>
        /// <item><description>expireDate: sorts by expiration time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sampling period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DAY: day</para>
        /// </description></item>
        /// <item><description><para>WEEK: week</para>
        /// </description></item>
        /// <item><description><para>MONTH: month.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DAY</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

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
        /// <para>The region of the resolution cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-3</para>
        /// </summary>
        [NameInMap("ServerRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

        /// <summary>
        /// <para>The route type. Valid values: cloud: cloud route. local: on-premises route.</para>
        /// 
        /// <b>Example:</b>
        /// <para>File</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516779348000</para>
        /// </summary>
        [NameInMap("StartTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>The type of statistical metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QTYPE_RATIO
        /// 枚举值：
        /// QTYPE_RATIO：DNS请求记录类型占比
        /// RCODE_DOMAIN：否定应答域名TOP排行
        /// RCODE_SOURCE_IP：某否定应答域名的请求源地址TOP排行
        /// REQUEST_ZONE：域名请求量排行（zone级别）
        /// REQUEST_DOMAIN：子域名请求量排行（domain name级别）
        /// SOURCE_REGION：请求来源地域分布
        /// SOURCE_ISP：请求来源运营商（ISP）分布
        /// SOURCE_IP：请求源IP详情（含地域、运营商、占比）
        /// LINE_HIT：解析线路命中详情
        /// LINE_RATIO：解析线路流量占比</para>
        /// </summary>
        [NameInMap("StatisticalType")]
        [Validation(Required=false)]
        public string StatisticalType { get; set; }

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
