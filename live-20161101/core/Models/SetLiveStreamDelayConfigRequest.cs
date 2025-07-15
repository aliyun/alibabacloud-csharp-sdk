// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamDelayConfigRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The latency of FLV-based playback. Unit: seconds.</para>
        /// <remarks>
        /// <para> If this parameter is left empty, the latency is set to a value corresponding to the FlvLevel parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("FlvDelay")]
        [Validation(Required=false)]
        public int? FlvDelay { get; set; }

        /// <summary>
        /// <para>The latency level of FLV-based playback. Ignore this parameter if the FlvDelay parameter is configured.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>short</b> (default): The latency is 4 seconds.</description></item>
        /// <item><description><b>medium</b>: The latency is 8 seconds.</description></item>
        /// <item><description><b>long</b>: The latency is 16 seconds.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If both the FlvDelay and FlvLevel parameters are left empty, FlvLevel is set to <b>short</b> by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("FlvLevel")]
        [Validation(Required=false)]
        public string FlvLevel { get; set; }

        /// <summary>
        /// <para>The latency of HLS-based playback. Unit: seconds.</para>
        /// <remarks>
        /// <para> If this parameter is left empty, the latency is set to a value corresponding to the HlsLevel parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HlsDelay")]
        [Validation(Required=false)]
        public int? HlsDelay { get; set; }

        /// <summary>
        /// <para>The latency level of HLS-based playback. Ignore this parameter if the HlsDelay parameter is configured.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>short</b>: The latency is 3 seconds. This is the default value.</description></item>
        /// <item><description><b>medium</b>: The latency is 6 seconds.</description></item>
        /// <item><description><b>long</b>: The latency is 15 seconds.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If both the HlsDelay and HlsLevel parameters are left empty, HlsLevel is set to <b>short</b> by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>short</para>
        /// </summary>
        [NameInMap("HlsLevel")]
        [Validation(Required=false)]
        public string HlsLevel { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The latency of RTMP-based playback. Unit: seconds.</para>
        /// <remarks>
        /// <para> If this parameter is left empty, the latency is set to a value corresponding to the RtmpLevel parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("RtmpDelay")]
        [Validation(Required=false)]
        public int? RtmpDelay { get; set; }

        /// <summary>
        /// <para>The latency level of RTMP-based playback. Ignore this parameter if the RtmpDelay parameter is configured.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>short</b> (default): The latency is 4 seconds.</description></item>
        /// <item><description><b>medium</b>: The latency is 8 seconds.</description></item>
        /// <item><description><b>long</b>: The latency is 16 seconds.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If both the RtmpDelay and RtmpLevel parameters are left empty, RtmpLevel is set to <b>short</b> by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>short</para>
        /// </summary>
        [NameInMap("RtmpLevel")]
        [Validation(Required=false)]
        public string RtmpLevel { get; set; }

    }

}
