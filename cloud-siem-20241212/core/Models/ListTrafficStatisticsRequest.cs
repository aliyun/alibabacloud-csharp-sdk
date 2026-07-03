// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListTrafficStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>A list of user IDs for batch data ingestion.</para>
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
        /// <para>The region of the Data Management center for threat analysis. Select a region based on the location of your asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your asset is in the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your asset is outside China.</para>
        /// </description></item>
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
        /// <para>The user ID of a member. This parameter is used by an administrator to switch to the perspective of the member.</para>
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
        /// <para>The statistic granularity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>day: day. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>hour: hour.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("TrafficStatisticPeriodType")]
        [Validation(Required=false)]
        public string TrafficStatisticPeriodType { get; set; }

        /// <summary>
        /// <para>The statistic dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Region</para>
        /// </description></item>
        /// <item><description><para>Product</para>
        /// </description></item>
        /// <item><description><para>DataIngetion</para>
        /// </description></item>
        /// <item><description><para>logUserId</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Region</para>
        /// </summary>
        [NameInMap("TrafficStatisticType")]
        [Validation(Required=false)]
        public string TrafficStatisticType { get; set; }

        /// <summary>
        /// <para>The type of the log traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentAnalysisLogTraffic</para>
        /// </summary>
        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

    }

}
