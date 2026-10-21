// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListTrafficStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.
        /// Note: This parameter is required in practice. If this parameter is not specified, the API returns a 400 error: &quot;The specified Lang can not be empty.&quot;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The list of user IDs for batch data ingestion.</para>
        /// </summary>
        [NameInMap("LogUserIds")]
        [Validation(Required=false)]
        public List<long?> LogUserIds { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba_cloud_sas</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region where the threat detection and response data management center resides. Specify the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: The assets reside outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public int? RegionTag { get; set; }

        /// <summary>
        /// <para>The user ID that the administrator switches to when viewing from another member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The statistical period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TrafficStatisticPeriod")]
        [Validation(Required=false)]
        public string TrafficStatisticPeriod { get; set; }

        /// <summary>
        /// <para>The statistical granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>day: day. This is the default value.</description></item>
        /// <item><description>hour: hour.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("TrafficStatisticPeriodType")]
        [Validation(Required=false)]
        public string TrafficStatisticPeriodType { get; set; }

        /// <summary>
        /// <para>The statistical dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Region</description></item>
        /// <item><description>Product</description></item>
        /// <item><description>DataIngetion</description></item>
        /// <item><description>logUserId</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("TrafficStatisticType")]
        [Validation(Required=false)]
        public string TrafficStatisticType { get; set; }

        /// <summary>
        /// <para>The log traffic type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentAnalysisLogTraffic</para>
        /// </summary>
        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

    }

}
