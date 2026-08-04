// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class LookupWmInfoMappingRequest : TeaModel {
        /// <summary>
        /// <para>Bit width of the watermark information. Default value: 32. This parameter must match the bit width used when embedding or generating a transparent image. Valid values: 32 to 64. Use the same value as when you created the mapping. Otherwise, the mapping cannot be found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>Numeric-formatted watermark information. Value source:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~CreateWmInfoMapping~~">CreateWmInfoMapping</a>: The <b>WmInfoUint</b> return value from the CreateWmInfoMapping API.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123***</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// <para>Watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PureWebappInvisible</b>: Webpage watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureAppInvisible</b>: App watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureScreenInvisible</b>: Screen watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureDocument</b>: Document watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureImage</b>: Image watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureAudio</b>: Audio watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureVideo</b>: Video watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcWebappInvisible</b>: AIGC webpage watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcAppInvisible</b>: AIGC app watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcScreenInvisible</b>: AIGC screen watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcDocument</b>: AIGC document watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcImage</b>: AIGC image watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcAudio</b>: AIGC audio watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcVideo</b>: AIGC video watermark.</para>
        /// </description></item>
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
