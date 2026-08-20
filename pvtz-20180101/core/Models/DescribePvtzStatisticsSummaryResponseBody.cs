// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribePvtzStatisticsSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurPage")]
        [Validation(Required=false)]
        public int? CurPage { get; set; }

        /// <summary>
        /// <para>A list of statistical entries for the current page.</para>
        /// </summary>
        [NameInMap("PageData")]
        [Validation(Required=false)]
        public List<DescribePvtzStatisticsSummaryResponseBodyPageData> PageData { get; set; }
        public class DescribePvtzStatisticsSummaryResponseBodyPageData : TeaModel {
            /// <summary>
            /// <para>The UNIX timestamp for the start of the current statistical period, rounded down to the minute.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776774900000</para>
            /// </summary>
            [NameInMap("AggrTimestamp")]
            [Validation(Required=false)]
            public long? AggrTimestamp { get; set; }

            /// <summary>
            /// <para>The total number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-ni1iadds-2c8uyzvgrm5ftsnq.clb.gz-tencentclb.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The fluctuation rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19</para>
            /// </summary>
            [NameInMap("FluctuationValue")]
            [Validation(Required=false)]
            public int? FluctuationValue { get; set; }

            /// <summary>
            /// <para>The average resolution latency, in milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Latency")]
            [Validation(Required=false)]
            public long? Latency { get; set; }

            /// <summary>
            /// <para>The resolution line.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            /// <summary>
            /// <para>The statistics module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AUTHORITY</para>
            /// </summary>
            [NameInMap("Module")]
            [Validation(Required=false)]
            public string Module { get; set; }

            /// <summary>
            /// <para>The value from the previous statistical period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2227</para>
            /// </summary>
            [NameInMap("PreviousCount")]
            [Validation(Required=false)]
            public long? PreviousCount { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UDP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The DNS query type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("Qtype")]
            [Validation(Required=false)]
            public string Qtype { get; set; }

            /// <summary>
            /// <para>The success rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public long? Ratio { get; set; }

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
            /// <para>The source IP address of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110.19.60.72</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The source ISP of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>telecom</para>
            /// </summary>
            [NameInMap("SourceIsp")]
            [Validation(Required=false)]
            public string SourceIsp { get; set; }

            /// <summary>
            /// <para>The source region of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1uvv79h1t8unnzdh3nq</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the zone. The operation\&quot;s behavior depends on whether you specify this parameter:</para>
            /// <list type="bullet">
            /// <item><description><para>If you specify a ZoneId, the operation returns the change log of DNS records for that zone.<br></para>
            /// </description></item>
            /// <item><description><para>If you omit ZoneId, the operation returns the change log of all zone operations and DNS resolution changes for all zones in your account.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>479226c2db1f9bed449b0502c13bcd9d</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The zone name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bwcj.biz</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is <b>100</b>. The default value is <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0FCB52A-D512-41A0-8595-40234EDCFD8B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
