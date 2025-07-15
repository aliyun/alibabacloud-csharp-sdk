// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataByLayerRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain. You can specify multiple domain names by separating them with commas (,). If you leave this parameter empty, the data of all domain names within your Alibaba Cloud account is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pull.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-16T16:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>300</b></description></item>
        /// <item><description><b>3600</b></description></item>
        /// <item><description><b>86400</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the time range specified by the StartTime and EndTime parameters is smaller than or equal to 3 days, the supported time granularities include 300, 3,600, and 86,400 seconds.</para>
        /// </description></item>
        /// <item><description><para>If the time range is larger than 3 days but smaller than or equal to 31 days, the supported time granularities include 3,600 and 86,400 seconds.</para>
        /// </description></item>
        /// <item><description><para>If the time range is larger than 31 days, the supported time granularity is 86,400 seconds.</para>
        /// </description></item>
        /// <item><description><para>If you specify an invalid value or do not specify this parameter, the default time granularity of 300 seconds is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP). If you do not specify this parameter, the data of all ISPs is returned.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeLiveRegionAndIsp</a> operation to query available regions and ISPs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tele***</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The layer at which you want to query the data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPv4 and IPv6 (network layer)</description></item>
        /// <item><description>http, https, and quic (application layer)</description></item>
        /// <item><description>all (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// <para>The name of the region. If you do not specify this parameter, the data of all regions is returned.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeLiveRegionAndIsp</a> operation to query available regions and ISPs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format. The time must be displayed in UTC.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the data of the last 24 hours is returned by default. The minimum time granularity is 5 minutes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-15T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
