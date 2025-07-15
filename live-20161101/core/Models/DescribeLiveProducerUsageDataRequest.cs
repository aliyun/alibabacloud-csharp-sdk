// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveProducerUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>You can query one or more domain names. If you specify multiple domain names, separate them with commas (,).</description></item>
        /// <item><description>If you leave this parameter empty, the data of all domain names within your Alibaba Cloud account is returned.</description></item>
        /// </list>
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
        /// <para> The end time must be later than the start time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-31T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The production studio instance that you want to query. You can specify one or more production studio instances. Separate multiple instances with commas (,).</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the usage data of all production studio instances is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a17d0184-462d-4630-b2a6-8c26dde2****</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>The time granularity for a query. Valid values: 3600 and 86400. Unit: seconds.</para>
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
        /// <para>The region in which the domain name resides. If you leave this parameter empty, the data of all regions is returned. You can specify multiple regions by separating them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The key that is used to group data. You can specify one or more keys. Separate multiple keys with commas (,). Valid values: domain, region, instance, and type. The data for a key that you specify by using the SplitBy parameter is returned by group.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the aggregated data is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>type</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The type of the production studio. You can specify one or more production studio types. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>slidelive</b>: playlist-mode studio.</description></item>
        /// <item><description><b>universal</b>: general studio.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not set this parameter, the usage data of all types of production studios is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>slidelive</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("app")]
        [Validation(Required=false)]
        public string App { get; set; }

    }

}
