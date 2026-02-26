// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class WebofficeWatermark : TeaModel {
        /// <summary>
        /// <para>The color and transparency of the text watermark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgba(192, 192, 192, 0.6)</para>
        /// </summary>
        [NameInMap("FillStyle")]
        [Validation(Required=false)]
        public string FillStyle { get; set; }

        /// <summary>
        /// <para>The font of the text watermark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bold 20px Serif</para>
        /// </summary>
        [NameInMap("Font")]
        [Validation(Required=false)]
        public string Font { get; set; }

        /// <summary>
        /// <para>The horizontal spacing of the text watermark. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Horizontal")]
        [Validation(Required=false)]
        public long? Horizontal { get; set; }

        /// <summary>
        /// <para>The rotation of the text watermark. Unit: radian.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-0.7853982</para>
        /// </summary>
        [NameInMap("Rotate")]
        [Validation(Required=false)]
        public float? Rotate { get; set; }

        /// <summary>
        /// <para>The watermark type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no watermark.</description></item>
        /// <item><description>1: text watermark.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

        /// <summary>
        /// <para>The watermark text.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if you set the Type parameter to 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>The vertical spacing of the text watermark. Unit: pixel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Vertical")]
        [Validation(Required=false)]
        public long? Vertical { get; set; }

    }

}
