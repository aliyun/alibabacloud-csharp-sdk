// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainStreamTranscodeDataRequest : TeaModel {
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
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T22:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The time granularity of the query. Unit: seconds. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3600</b>: 1 hour</description></item>
        /// <item><description><b>86400</b>: 1 day</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the time granularity of 1 hour is used by default.</para>
        /// </remarks>
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
        /// <para>The time precision of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>min</b> (default): in minutes.</description></item>
        /// <item><description><b>sec</b>: in seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>min</para>
        /// </summary>
        [NameInMap("Precision")]
        [Validation(Required=false)]
        public string Precision { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The key that is used to group data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>domain</b>: The DomainName parameter is available in the response only if Split is set to domain.</description></item>
        /// <item><description><b>region</b>: The Region parameter is available in the response only if Split is set to region.</description></item>
        /// <item><description><b>transcode_type</b>: The TanscodeType parameter is available in the response only if Split is set to transcode_type.</description></item>
        /// <item><description><b>resolution</b>: The Resolution parameter is available in the response only if Split is set to resolution.</description></item>
        /// <item><description><b>fps</b>: The Fps parameter is available in the response only if Split is set to fps.</description></item>
        /// </list>
        /// <para>You can specify one or more keys. If you specify multiple keys, separate them with commas (,).</para>
        /// <para>Default value: <c>domain,region,transcode_type,resolution,fps</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("Split")]
        [Validation(Required=false)]
        public string Split { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>The minimum query interval is 1 hour.</description></item>
        /// <item><description>If you do not set this parameter, the transcoding length for the last 24 hours is returned.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
