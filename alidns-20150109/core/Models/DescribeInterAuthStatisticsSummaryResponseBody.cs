// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeInterAuthStatisticsSummaryResponseBody : TeaModel {
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
        /// <para>The paginated data.</para>
        /// </summary>
        [NameInMap("PageData")]
        [Validation(Required=false)]
        public List<DescribeInterAuthStatisticsSummaryResponseBodyPageData> PageData { get; set; }
        public class DescribeInterAuthStatisticsSummaryResponseBodyPageData : TeaModel {
            /// <summary>
            /// <para>The start time of the current period (the 0th second of the minute).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1776754800000</para>
            /// </summary>
            [NameInMap("AggrTimestamp")]
            [Validation(Required=false)]
            public long? AggrTimestamp { get; set; }

            /// <summary>
            /// <para>The number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The domain name. Queries the transfer records of the specified domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nervermsf.com</para>
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
            /// <para>The resolution line.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            /// <summary>
            /// <para>The value of the previous period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2227</para>
            /// </summary>
            [NameInMap("PreviousCount")]
            [Validation(Required=false)]
            public long? PreviousCount { get; set; }

            /// <summary>
            /// <para>The protocol type of the DNS resolution query request. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>UDP</para>
            /// </description></item>
            /// <item><description><para>TCP.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP%DF\&quot;</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The request record type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A</para>
            /// </summary>
            [NameInMap("Qtype")]
            [Validation(Required=false)]
            public string Qtype { get; set; }

            /// <summary>
            /// <para>The success rate or proportion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
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
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112.16.17.203</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The ISP of the request source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>telecom</para>
            /// </summary>
            [NameInMap("SourceIsp")]
            [Validation(Required=false)]
            public string SourceIsp { get; set; }

            /// <summary>
            /// <para>The source region for copying the image. If not specified, a random region is selected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            /// <summary>
            /// <para>The zone name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>longzi.xyz</para>
            /// </summary>
            [NameInMap("ZoneName")]
            [Validation(Required=false)]
            public string ZoneName { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>853805EA-3D47-47D5-9A1A-A45C24313ABD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
