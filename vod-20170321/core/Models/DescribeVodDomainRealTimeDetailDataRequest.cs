// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeDetailDataRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. You can specify a maximum of 20 accelerated domain names in each call. Separate domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2019-11-30T05:40:00Z.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-23T12:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of data that you want to query. You can specify multiple data types and separate them with commas (,). Valid values:</para>
        /// <para>qps: the number of queries per second bps: bandwidth data http_code: HTTP status codes</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bps</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("IspNameEn")]
        [Validation(Required=false)]
        public string IspNameEn { get; set; }

        /// <summary>
        /// <para>The name of the region. If you do not specify a region, data in all regions is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shanghai</para>
        /// </summary>
        [NameInMap("LocationNameEn")]
        [Validation(Required=false)]
        public string LocationNameEn { get; set; }

        /// <summary>
        /// <para>Specifies whether to return a summary value. Valid values:</para>
        /// <para>true false (default)</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Merge")]
        [Validation(Required=false)]
        public string Merge { get; set; }

        /// <summary>
        /// <para>Specifies whether to return a summary value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: groups the results by domain name and merges the results by region and ISP.</description></item>
        /// <item><description><b>false</b>: groups the results by domain name.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MergeLocIsp")]
        [Validation(Required=false)]
        public string MergeLocIsp { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. Example: 2019-11-30T05:33:00Z.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-01-23T12:35:12Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
