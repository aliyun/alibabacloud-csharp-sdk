// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain. You can query one or more domain names. If you specify multiple domain names, separate them with commas (,). If you leave this parameter empty, the data of all domain names within your Alibaba Cloud account is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T09:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>300</b> (default)</description></item>
        /// <item><description><b>3600</b></description></item>
        /// <item><description><b>86400</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify an invalid value or do not specify this parameter, the default value <b>300</b> is used.</para>
        /// </description></item>
        /// <item><description><para>When the time granularity is <b>300</b> seconds, the returned bandwidth is the average bandwidth within the 300 seconds.</para>
        /// </description></item>
        /// <item><description><para>When the time granularity is <b>3600</b> or <b>86400</b> seconds, the returned bandwidth is the peak value of all average bandwidths within each 300-second period.</para>
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
        /// <para>The name of the Internet service provider (ISP). You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeCdnRegionAndIsp</a> operation to query a list of available ISPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region. You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeCdnRegionAndIsp</a> operation to query a list of available regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tianjin</para>
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
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
