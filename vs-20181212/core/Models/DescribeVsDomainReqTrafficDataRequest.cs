// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainReqTrafficDataRequest : TeaModel {
        /// <summary>
        /// <para>Visual Edge Computing Service domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>End time of the query. Must be later than the start time. Specify in ISO 8601 format using UTC time.<br>Format: YYYY-MM-DDThh:mm:ssZ<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-13T10:00:41Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Time granularity of the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>300</b> (default).</para>
        /// </description></item>
        /// <item><description><para><b>3600</b>.</para>
        /// </description></item>
        /// <item><description><para><b>86400</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you omit this parameter or specify an unsupported value, the default value <b>300</b> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>ISP name in English. Call DescribeCdnRegionAndIsp to get valid values. If you omit this parameter, the system returns data for all ISPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>Region name in English. Call DescribeCdnRegionAndIsp to get valid values. If you omit this parameter, the system returns data for all regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Start time of the query. Specify in ISO 8601 format using UTC time.<br>Format: YYYY-MM-DDThh:mm:ssZ<br>Minimum time granularity is 5 minutes.<br>If you omit this parameter, the system returns data for the last 24 hours.<br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
