// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainIpaTrafficDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// <para>Separate multiple domain names with commas (,). If you do not specify a value for this parameter, data for all accelerated domain names is queried.</para>
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
        /// <para>2017-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specify whether to implement padding with zeros. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FixTimeGap")]
        [Validation(Required=false)]
        public string FixTimeGap { get; set; }

        /// <summary>
        /// <para>The time granularity of data entries. Unit: seconds.</para>
        /// <para>The time granularity varies with the time range specified by <b>StartTime</b> and <b>EndTime</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the time range between StartTime and EndTime is less than 3 days, the valid values are <b>300</b>, <b>3600</b>, and <b>86400</b>. If you do not specify a value for this parameter, <b>300</b> is used.</description></item>
        /// <item><description>If the time range between StartTime and EndTime is greater than or equal to 3 days and less than 31 days, the valid values are <b>3600</b> and <b>86400</b>. Default value: <b>3600</b>.</description></item>
        /// <item><description>If the time range between StartTime and EndTime is 31 days or longer, the valid value is <b>86400</b>. Default value: <b>86400</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP).</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/207199.html">DescribeDcdnRegionAndIsp</a> operation to query ISPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/207199.html">DescribeDcdnRegionAndIsp</a> operation to query regions.</para>
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
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically calculate the value of the <b>interval</b>. If the <b>timeMerge</b> parameter is set to <b>1</b>, the value of <b>inteval</b> is calculated based on <b>StartTime</b> and <b>EndTime</b>. You can set either this parameter or the <b>interval</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimeMerge")]
        [Validation(Required=false)]
        public string TimeMerge { get; set; }

    }

}
