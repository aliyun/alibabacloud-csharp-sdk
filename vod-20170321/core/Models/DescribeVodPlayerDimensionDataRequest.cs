// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodPlayerDimensionDataRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-1000000</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The dimension type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Os: operating system.</description></item>
        /// <item><description>AppVersion: application version.</description></item>
        /// <item><description>SdkVersion: SDK version.</description></item>
        /// <item><description>Codec: codec.</description></item>
        /// <item><description>VideoType: video format.</description></item>
        /// <item><description>Network: network type.</description></item>
        /// <item><description>Isp: Internet service provider.</description></item>
        /// <item><description>VideoDefinition: resolution.</description></item>
        /// <item><description>Domain: domain name.</description></item>
        /// <item><description>Country: country.</description></item>
        /// <item><description>Province: province.</description></item>
        /// <item><description>ErrorCode: error code.</description></item>
        /// <item><description>IsHw: whether hardware decoding is used.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Os</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the yyyy-mm-ddthh:mm:ssz format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-05T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The region filter used when querying the Province or Isp dimension metadata. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL (default): all regions.</description></item>
        /// <item><description>CN: China.</description></item>
        /// <item><description>OVERSEAS: outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <i>yyyy-mm-dd</i>t<i>hh:mm:ss</i>z format (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Playback data from the last year is supported.</description></item>
        /// <item><description>The time range for a single query cannot exceed 31 days.</description></item>
        /// <item><description>The time interval is left-closed and right-open [StartTime, EndTime).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-24T00:55:06Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
