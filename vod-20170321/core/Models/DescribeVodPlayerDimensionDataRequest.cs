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
        /// <item><description>Os: Operating system.</description></item>
        /// <item><description>AppVersion: App version.</description></item>
        /// <item><description>SdkVersion: SDK version.</description></item>
        /// <item><description>Codec: Codec.</description></item>
        /// <item><description>VideoType: Video format.</description></item>
        /// <item><description>Network: Network type.</description></item>
        /// <item><description>Isp: ISP.</description></item>
        /// <item><description>VideoDefinition: Resolution.</description></item>
        /// <item><description>Domain: Domain name.</description></item>
        /// <item><description>Country: Country.</description></item>
        /// <item><description>Province: Province.</description></item>
        /// <item><description>ErrorCode: Error code.</description></item>
        /// <item><description>IsHw: Hardware decoding.</description></item>
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
        /// <para>The end time of the query. Format: yyyy-mm-ddThh:mm:ssZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06-05T15:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The region used to limit the query scope when querying the metadata for the Province and ISP dimensions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL (default): All regions.</description></item>
        /// <item><description>CN: China.</description></item>
        /// <item><description>OVERSEAS: Outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can query playback data history for the past year.</description></item>
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
