// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainTrafficDataRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the Visual Edge Computing Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time must be later than the start time. Use ISO8601 notation for the date format and UTC time.<br>Format: YYYY-MM-DDThh:mm:ssZ<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-21T02:50:42Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity for querying data. Supported values are 300, 3600, and 86400 seconds. If this parameter is not provided or an unsupported value is passed, the default value of 300 seconds is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <para>The English name of the ISP. Obtain this value through the DescribeCdnRegionAndIsp interface. If this parameter is not provided, the system queries all ISPs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The English name of the region. Obtain this value through the DescribeCdnRegionAndIsp interface. If this parameter is not provided, the system queries all regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beijing</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The start time for data retrieval. Use ISO8601 notation for the date format and UTC time.<br>Format: YYYY-MM-DDThh:mm:ssZ<br> The minimum data granularity is 5 minutes.<br> If not specified, the system reads data from the past 24 hours by default.<br><br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-18T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
