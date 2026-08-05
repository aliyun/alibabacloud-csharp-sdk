// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class HotLiveRtcStreamRequest : TeaModel {
        /// <summary>
        /// <para>The application name of the live stream to prefetch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The audio Msid.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rts audio</para>
        /// </summary>
        [NameInMap("AudioMsid")]
        [Validation(Required=false)]
        public string AudioMsid { get; set; }

        /// <summary>
        /// <para>The duration to maintain the prefetch connection. Unit: milliseconds. The default value, 0, means the connection is always maintained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ConnectionTimeout")]
        [Validation(Required=false)]
        public string ConnectionTimeout { get; set; }

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
        /// <para>The custom timeout period for a timeout event. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("MediaTimeout")]
        [Validation(Required=false)]
        public string MediaTimeout { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The prefetch area. For more information, see the RegionCode lookup table.</para>
        /// <remarks>
        /// <para>For regions within China, specify the corresponding code from the &quot;Region codes for China&quot; table. For all other regions, specify the country code.</para>
        /// <list type="bullet">
        /// <item><description>If the CodeRegionHasNoNode error is returned after you specify a RegionCode, the corresponding area is not covered by L1 nodes and cannot be prefetched. In this case, specify a different RegionCode.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZHJ</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

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
        /// <para>The name of the live stream to prefetch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The video Msid.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rts video</para>
        /// </summary>
        [NameInMap("VideoMsid")]
        [Validation(Required=false)]
        public string VideoMsid { get; set; }

    }

}
