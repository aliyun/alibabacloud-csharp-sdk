// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByLayerRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify up to 500 domain names in each request. Separate multiple domain names with commas (,).</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the bandwidth data about all accelerated domain names that belong to your Alibaba Cloud account is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-06T07:20:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the data entries. Unit: seconds.</para>
        /// <para>The time granularity varies with the maximum time range per query. Valid values: 300 (5 minutes), 3600 (1 hour), and 86400 (1 day). For more information, see <b>Usage notes</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP). You can call the <a href="~~DescribeCdnRegionAndIsp~~">DescribeCdnRegionAndIsp</a> operation to query ISPs. If you do not specify an ISP, data of all ISPs is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The layer at which you want to query the bandwidth data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Network layer: <b>IPv4</b> and <b>IPv6</b>.</description></item>
        /// <item><description>Application layer: <b>http</b>, <b>https</b>, and <b>quic</b>.</description></item>
        /// <item><description><b>all</b>: specifies that both the network and application layers are included.</description></item>
        /// </list>
        /// <para>Default value: <b>all</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// <para>The name of the region. You can call the <a href="~~DescribeCdnRegionAndIsp~~">DescribeCdnRegionAndIsp</a> operation to query regions. If you do not specify a region, data in all regions is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beijing</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-06T07:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
