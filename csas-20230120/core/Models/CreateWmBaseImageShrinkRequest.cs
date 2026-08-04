// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateWmBaseImageShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Height of the watermark image, in pixels. Valid values: 100 to 5000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>Image watermark control parameters.</para>
        /// </summary>
        [NameInMap("ImageControl")]
        [Validation(Required=false)]
        public string ImageControlShrink { get; set; }

        /// <summary>
        /// <para>Opacity of the watermark image. Valid values: 1 to 255. Higher values mean lower transparency.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255</para>
        /// </summary>
        [NameInMap("Opacity")]
        [Validation(Required=false)]
        public int? Opacity { get; set; }

        /// <summary>
        /// <para>Scaling factor of the watermark image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Scale")]
        [Validation(Required=false)]
        public int? Scale { get; set; }

        /// <summary>
        /// <para>Width of the watermark image, in pixels. Valid values: 100 to 5000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        /// <summary>
        /// <para>Base64-encoded watermark information. Length: 1 to 300 characters. Do not set this parameter if you set WmInfoUint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGVsbG8gc2F*****</para>
        /// </summary>
        [NameInMap("WmInfoBytesB64")]
        [Validation(Required=false)]
        public string WmInfoBytesB64 { get; set; }

        /// <summary>
        /// <para>Bit width of the watermark information. Default value: 32. This value must be the same during embedding and extraction. For example, if you use a 40-bit SDK to embed the watermark, set this value to 40 when extracting it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("WmInfoSize")]
        [Validation(Required=false)]
        public long? WmInfoSize { get; set; }

        /// <summary>
        /// <para>Decimal-form watermark information. Do not set this parameter if you set WmInfoBytesB64.</para>
        /// <para>The valid range depends on the WmInfoSize value:</para>
        /// <list type="bullet">
        /// <item><description><para>If WmInfoSize is <b>32</b>, the valid range is 1 to 4294967295.</para>
        /// </description></item>
        /// <item><description><para>If WmInfoSize is <b>40</b>, the valid range is 1 to 1099511627775.</para>
        /// </description></item>
        /// <item><description><para>If WmInfoSize is <b>64</b>, the valid range is 1 to 18446744073709551615.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>12*****</para>
        /// </summary>
        [NameInMap("WmInfoUint")]
        [Validation(Required=false)]
        public string WmInfoUint { get; set; }

        /// <summary>
        /// <para>Watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PureWebappInvisible</b>: Web watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureAppInvisible</b>: App watermark.</para>
        /// </description></item>
        /// <item><description><para><b>PureScreenInvisible</b>: Screen watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcWebappInvisible</b>: AIGC web watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcAppInvisible</b>: AIGC app watermark.</para>
        /// </description></item>
        /// <item><description><para><b>AigcScreenInvisible</b>: AIGC screen watermark.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PureWebappInvisible</para>
        /// </summary>
        [NameInMap("WmType")]
        [Validation(Required=false)]
        public string WmType { get; set; }

        /// <summary>
        /// <para>Comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

    }

}
