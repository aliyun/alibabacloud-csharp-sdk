// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class HotLiveRtcStreamRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The audio MSID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rts audio</para>
        /// </summary>
        [NameInMap("AudioMsid")]
        [Validation(Required=false)]
        public string AudioMsid { get; set; }

        /// <summary>
        /// <para>The duration for which the prefetch connection is maintained. Unit: milliseconds. Default value: 0, which specifies that the prefetch connection is always maintained.</para>
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
        /// <para>The custom period after which a timeout event is triggered. Unit: milliseconds.</para>
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
        /// <para>The code of the region in which the live stream is prefetched. For more information, see the following tables that list available region codes.</para>
        /// <remarks>
        /// <para> Region codes include provincial codes for China and country codes for all countries.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZHJ</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the live stream that you want to prefetch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The video MSID.</para>
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
