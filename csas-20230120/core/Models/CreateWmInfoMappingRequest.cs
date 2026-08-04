// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmInfoMappingRequest : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded string-format watermark information. Length: 1 to 300 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <para>The capacity bit width of the watermark information. Default is 32. This parameter must be consistent with the capacity bit width used during actual embedding or transparent image generation. Valid range: 32 to 64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>Watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PureWebappInvisible</b>: Webpage watermark.</description></item>
        /// <item><description><b>PureAppInvisible</b>: App watermark.</description></item>
        /// <item><description><b>PureScreenInvisible</b>: Screen watermark.</description></item>
        /// <item><description><b>PureDocument</b>: Document watermark.</description></item>
        /// <item><description><b>PureImage</b>: Image watermark.</description></item>
        /// <item><description><b>PureAudio</b>: Audio watermark.</description></item>
        /// <item><description><b>PureVideo</b>: Video watermark.</description></item>
        /// <item><description><b>AigcWebappInvisible</b>: AIGC webpage watermark.</description></item>
        /// <item><description><b>AigcAppInvisible</b>: AIGC App watermark.</description></item>
        /// <item><description><b>AigcScreenInvisible</b>: AIGC screen watermark.</description></item>
        /// <item><description><b>AigcDocument</b>: AIGC document watermark.</description></item>
        /// <item><description><b>AigcImage</b>: AIGC image watermark.</description></item>
        /// <item><description><b>AigcAudio</b>: AIGC audio watermark.</description></item>
        /// <item><description><b>AigcVideo</b>: AIGC video watermark.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PureDocument</para>
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

    }

}
