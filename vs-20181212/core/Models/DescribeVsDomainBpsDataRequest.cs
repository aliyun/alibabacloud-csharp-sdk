// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainBpsDataRequest : TeaModel {
        /// <summary>
        /// <para>Domain Names. If this parameter is empty, the system returns merged data for all accelerated Domain Names. Enter the accelerated Domain Names to query. Separate multiple Domain Names with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time must be later than the start time. The date format follows ISO8601 notation and uses UTC time. Format: YYYY-MM-DDThh:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-02T02:30:48Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for query data. Supports 300, 3600, and 86400 seconds. If this parameter is not specified or the specified value is not supported, the system uses 300 seconds by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The English name of the carrier (ISP). Obtain this from the DescribeCdnRegionAndIsp interface. If not specified, the system queries all carriers (ISPs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The English name of the region. Obtain this from the DescribeCdnRegionAndIsp interface. If not specified, the system queries all regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>guangdong</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The start time for data retrieval. The date format follows ISO8601 notation and uses UTC time. Format: YYYY-MM-DDThh:mm:ssZ. The minimum data granularity is 5 minutes. If not specified, the system reads data from the past 24 hours.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-26T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
