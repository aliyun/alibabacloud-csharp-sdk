// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeDetailDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. Separate multiple accelerated domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time, and the maximum time range to query is 10 minutes.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of information that you want to query. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>qps</b>: queries per second (QPS)</description></item>
        /// <item><description><b>bps</b>: bandwidth</description></item>
        /// <item><description><b>http_code</b>: HTTP status code</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The name of the ISP. You can call the <a href="~~DescribeDcdnRegionAndIsp~~">DescribeDcdnRegionAndIsp</a> operation to obtain the ISP name.</para>
        /// <para>If you do not set this parameter, data of all ISPs is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region. You can call the <a href="~~DescribeDcdnRegionAndIsp~~">DescribeDcdnRegionAndIsp</a> operation to obtain the region name.</para>
        /// <para>If you do not set this parameter, all regions are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beijing</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// <para>Specifies whether to return a summary value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Merge")]
        [Validation(Required=false)]
        public string Merge { get; set; }

        /// <summary>
        /// <para>Specifies whether to return a summary value of <b>LocationNameEn</b> and <b>IspNameEn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MergeLocIsp")]
        [Validation(Required=false)]
        public string MergeLocIsp { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-30T05:33:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
