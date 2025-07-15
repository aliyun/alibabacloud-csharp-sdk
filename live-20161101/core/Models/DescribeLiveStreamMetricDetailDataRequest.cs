// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMetricDetailDataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application for which you want to query the monitoring data of streams.</para>
        /// <remarks>
        /// <para> If you specify the StreamName parameter, you must also specify the AppName parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The accelerated domain name. You can specify only one domain name. If you specify multiple domain names, an error occurs.</description></item>
        /// <item><description>If you do not specify the AppName and StreamName parameters, monitoring data of all streams for the domain name is returned.</description></item>
        /// <item><description>If you leave this parameter empty, monitoring data of streams under all domain names is returned.</description></item>
        /// <item><description>If you specify the DomainName parameter and set both the AppName and StreamName parameters to all, monitoring data of all streams in all applications under the specified domain name is returned.</description></item>
        /// <item><description>When you specify the DomainName parameter, make sure that the domain name is a domain name used for live streaming and that you have the permissions on the domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time, and the maximum time range that can be specified is one day. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The token used to query data by page. Up to 5,000 rows of data can be returned per query. If the number of rows exceeds 5,000, a token that determines the start point of the next query is provided in the response. If you specify this parameter, data continues to be obtained from the end of the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UjsM9x3aVcJi9a0-ArwJUTTC67CIBKLw*****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The streaming protocol. Valid values: <b>flv</b>, <b>hls</b>, <b>rtmp</b>, <b>rts</b>, and <b>p2p</b>.</para>
        /// <para>You can specify multiple protocols. Separate multiple protocols with commas (,). However, data over multiple protocols is not aggregated and is returned based on the stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flv</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the stream. The stream must belong to the application that is specified by the AppName parameter.</para>
        /// <remarks>
        /// <para> If you specify the StreamName parameter, you must also specify the AppName parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
