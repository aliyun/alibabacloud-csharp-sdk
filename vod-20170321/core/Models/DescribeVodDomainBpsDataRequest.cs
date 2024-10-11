// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainBpsDataRequest : TeaModel {
        /// <summary>
        /// <para>The domain name to be queried. If you do not specify this parameter, the merged data of all your domain names for CDN is returned. You can specify multiple domain names. Separate them with commas (,).</para>
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
        /// <para>2015-12-10T14:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The query interval. Unit: seconds. Valid values: <b>300</b>, <b>3600</b>, and <b>86400</b>.</para>
        /// <list type="bullet">
        /// <item><description>If the time range to query is less than 3 days, valid values are <b>300</b>, <b>3600</b>, and <b>86400</b>. The default value is 300.</description></item>
        /// <item><description>If the time range to query is from 3 to less than 31 days, valid values are <b>3600</b> and <b>86400</b>. The default value is 3600.</description></item>
        /// <item><description>If the time range to query is from 31 to 90 days, the valid value is <b>86400</b>.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region. If you do not specify this parameter, the data in all regions is returned. Only data in the China (Shanghai) region can be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The minimum query interval is 5 minutes. If you do not specify this parameter, the data in the last 24 hours is queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T13:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
