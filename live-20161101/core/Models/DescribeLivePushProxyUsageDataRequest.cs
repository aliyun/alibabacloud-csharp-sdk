// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePushProxyUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The main streaming domain to query.</para>
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
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The end time must be later than the start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region. Separate multiple region IDs with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-beijing: China (Beijing)</description></item>
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// <item><description>cn-shenzhen: China (Shenzhen)</description></item>
        /// <item><description>cn-qingdao: China (Qingdao)</description></item>
        /// <item><description>ap-southeast-1: Singapore</description></item>
        /// <item><description>eu-central-1: Germany (Frankfurt)</description></item>
        /// <item><description>ap-northeast-1: Japan (Tokyo)</description></item>
        /// <item><description>ap-southeast-5: Indonesia (Jakarta)</description></item>
        /// </list>
        /// <para>If you do not specify this parameter, data of all regions is aggregated and returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The key that is used to group data. If you do not specify this parameter, the default value region is used. Data is aggregated and returned. Separate multiple keys with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>domain: The value of DomainName in the response takes effect only if SplitBy is set to domain.</description></item>
        /// <item><description>region: This is the default value. The value of Region in the response takes effect only if SplitBy is set to region.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>region</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. By default, data in the last seven days is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
