// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveProducerUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain name of the cloud producer studio.</para>
        /// <list type="bullet">
        /// <item><description>Supports single or batch domain name queries. Separate multiple domain names with commas (,) for batch queries.</description></item>
        /// <item><description>If this parameter is left empty, merged data of all live streaming domain names is returned by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-31T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance to query. Batch query is supported. Separate multiple instances with commas (,).</para>
        /// <remarks>
        /// <para>If this parameter is left empty, merged data of all instances is returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a17d0184-462d-4630-b2a6-8c26dde2****</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>The time granularity of the queried data. Valid values: 3600 (1 hour) and 86400 (1 day). Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region to which the domain name belongs. If this parameter is left empty, merged data of all regions is returned by default. Batch query is supported. Separate multiple regions with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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
        /// <para>The grouping key. You can specify one or more of the following: domain, region, instance, or type. Separate multiple values with commas (,). The specified fields will be grouped in the output.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, only aggregated data is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>type</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The start time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The producer type. Batch query is supported. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>slidelive</b>: playlist-based.</para>
        /// </description></item>
        /// <item><description><para><b>universal</b>: general-purpose.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is left empty, merged data of all producer types is returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>slidelive</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The name of the application to which the stream belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("app")]
        [Validation(Required=false)]
        public string App { get; set; }

    }

}
