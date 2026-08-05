// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataByLayerRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain. You can specify multiple domain names separated by commas (,). If this parameter is left empty, the aggregated data of all domain names is returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pull.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query, in the format of <i>yyyy-MM-ddTHH:mm:ssZ</i> (UTC). The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-03-16T16:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the data to query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>300</b></para>
        /// </description></item>
        /// <item><description><para><b>3600</b></para>
        /// </description></item>
        /// <item><description><para><b>86400</b></para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Time range ≤ 3 days: Valid data timestamp granularity values are 300, 3600, and 86400.</description></item>
        /// <item><description>3 days &lt; time range ≤ 31 days: Valid data timestamp granularity values are 3600 and 86400.</description></item>
        /// <item><description>Time range &gt; 31 days: The only valid value is 86400.</description></item>
        /// <item><description>If this parameter is not specified or the specified value is not supported, the default value 300 is used.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The name of the Internet service provider (ISP) in English. If this parameter is not specified, data for all ISPs is returned.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeLiveRegionAndIsp</a> operation to query the English names of regions and ISPs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tele***</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The query dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Network layer (IPv4, IPv6)</para>
        /// </description></item>
        /// <item><description><para>Application layer (http, https, quic)</para>
        /// </description></item>
        /// <item><description><para>all (default)</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values: all | IPv4 | IPv6 | http | https | quic (case-sensitive).</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// <para>The name of the region in English. If this parameter is not specified, data for all regions is returned.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/91077.html">DescribeLiveRegionAndIsp</a> operation to query the English names of regions and ISPs.</para>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query, in the format of <i>yyyy-MM-ddTHH:mm:ssZ</i> (UTC).</para>
        /// <remarks>
        /// <para>If this parameter is not specified, data for the last 24 hours is returned by default. The minimum data granularity is 5 minutes.</para>
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
