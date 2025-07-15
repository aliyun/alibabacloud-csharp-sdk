// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectPornDataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The main streaming domain to query.</para>
        /// <list type="bullet">
        /// <item><description>You can query one or more domain names. If you specify multiple domain names, separate them with commas (,).</description></item>
        /// <item><description>If you do not specify this parameter, the data of all domain names within your Alibaba Cloud account is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T09:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether a quota of free image scanning is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>free</b>: specifies that a quota of free image scanning is available.</description></item>
        /// <item><description><b>charge</b>: specifies that a quota of free image scanning is not available and fees are charged.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("Fee")]
        [Validation(Required=false)]
        public string Fee { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the domain name resides.</para>
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
        /// <para>The moderation scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>porn</b>: pornography detection. This is the default value.</description></item>
        /// <item><description><b>terrorism</b>: terrorism detection</description></item>
        /// <item><description><b>ad</b>: ad violation detection</description></item>
        /// <item><description><b>live</b>: undesirable scene detection</description></item>
        /// <item><description><b>logo</b>: logo detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>porn</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The fields based on which data is grouped. Separate multiple fields with commas (,).</para>
        /// <remarks>
        /// <para>If you leave the <b>SplitBy</b> parameter empty, only the <b>TimeStamp</b> and <b>Count</b> parameters are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****,liveStream****</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can query data in the last 90 days.</para>
        /// </description></item>
        /// <item><description><para>The minimum data granularity is 5 minutes. If you do not specify this parameter, data in the last 24 hours is queried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
