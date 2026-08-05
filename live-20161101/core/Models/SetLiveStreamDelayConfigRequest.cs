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
        /// <para>The FLV playback latency. Unit: seconds.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, the latency is set based on the value of FlvLevel.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("FlvDelay")]
        [Validation(Required=false)]
        public int? FlvDelay { get; set; }

        /// <summary>
        /// <para>The FLV latency level. This parameter is ignored if FlvDelay is set.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>short</b> (default): 2 seconds.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: 4 seconds.</para>
        /// </description></item>
        /// <item><description><para><b>long</b>: more than 4 seconds.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If both FlvDelay and FlvLevel are left empty, the default value <b>short</b> is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("FlvLevel")]
        [Validation(Required=false)]
        public string FlvLevel { get; set; }

        /// <summary>
        /// <para>The HLS playback latency. Unit: seconds.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, the latency is set based on the value of HlsLevel.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HlsDelay")]
        [Validation(Required=false)]
        public int? HlsDelay { get; set; }

        /// <summary>
        /// <para>The HLS latency level. This parameter is ignored if HlsDelay is set.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>short</b> (default): 3 seconds.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: 6 seconds.</para>
        /// </description></item>
        /// <item><description><para><b>long</b>: 15 seconds.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If both HlsDelay and HlsLevel are left empty, the default value <b>short</b> is used.</para>
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
        /// <para>The RTMP playback latency. Unit: seconds.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, the latency is set based on the value of RtmpLevel.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("RtmpDelay")]
        [Validation(Required=false)]
        public int? RtmpDelay { get; set; }

        /// <summary>
        /// <para>The RTMP latency level. This parameter is ignored if RtmpDelay is set.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>short</b> (default): 2 seconds.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: 4 seconds.</para>
        /// </description></item>
        /// <item><description><para><b>long</b>: more than 4 seconds.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If both RtmpDelay and RtmpLevel are left empty, the default value <b>short</b> is used.</para>
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
