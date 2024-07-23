// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddWaterMarkTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54BB917F-DD35-4F32-BABA-E60E31B21W63</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the watermark template.</para>
        /// </summary>
        [NameInMap("WaterMarkTemplate")]
        [Validation(Required=false)]
        public AddWaterMarkTemplateResponseBodyWaterMarkTemplate WaterMarkTemplate { get; set; }
        public class AddWaterMarkTemplateResponseBodyWaterMarkTemplate : TeaModel {
            /// <summary>
            /// <para>The horizontal offset. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Dx")]
            [Validation(Required=false)]
            public string Dx { get; set; }

            /// <summary>
            /// <para>The vertical offset. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Dy")]
            [Validation(Required=false)]
            public string Dy { get; set; }

            /// <summary>
            /// <para>The height of the watermark image. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// <para>The ID of the watermark template. We recommend that you keep this ID for subsequent operation calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3780bd69b2b74540bc7b1096f564****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the watermark template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-watermark-****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The values of the Height, Width, Dx, and Dy parameters relative to the reference edges. If the values of the Height, Width, Dx, and Dy parameters are decimals between 0 and 1, the values are calculated by referring to the following edges in sequence:</para>
            /// <list type="bullet">
            /// <item><description><b>Width</b>: the width edge.</description></item>
            /// <item><description><b>Height</b>: the height edge.</description></item>
            /// <item><description><b>Long</b>: the long edge.</description></item>
            /// <item><description><b>Short</b>: the short edge.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RatioRefer")]
            [Validation(Required=false)]
            public AddWaterMarkTemplateResponseBodyWaterMarkTemplateRatioRefer RatioRefer { get; set; }
            public class AddWaterMarkTemplateResponseBodyWaterMarkTemplateRatioRefer : TeaModel {
                /// <summary>
                /// <para>The horizontal offset of the watermark relative to the output video image. Default value: <b>0</b>. The default value indicates no offset. The value can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description><b>Integer</b>: the vertical offset. This indicates the absolute position. Unit: pixel.</description></item>
                /// <item><description><b>Decimal</b>: the ratio of the horizontal offset to the width of the output video. The ratio varies based on the size of the video. Four decimal places are supported, such as 0.9999. More decimal places are discarded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0.51</para>
                /// </summary>
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public string Dx { get; set; }

                /// <summary>
                /// <para>The vertical offset of the watermark relative to the output video image. Default value: <b>0</b>. The default value indicates no offset. The value can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description><b>Integer</b>: the vertical offset. This indicates the absolute position. Unit: pixel.</description></item>
                /// <item><description><b>Decimal</b>: the ratio of the vertical offset to the height of the output video. The ratio varies based on the size of the video. Four decimal places are supported, such as 0.9999. More decimal places are discarded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0.28</para>
                /// </summary>
                [NameInMap("Dy")]
                [Validation(Required=false)]
                public string Dy { get; set; }

                /// <summary>
                /// <para>The height of the watermark image in the output video. The value can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description><b>Integer</b>: the height of the watermark image. This indicates the absolute position. Unit: pixel.</description></item>
                /// <item><description><b>Decimal</b>: the ratio of the height of the watermark image to the height of the output video. The ratio varies based on the size of the video. Four decimal places are supported, such as 0.9999. More decimal places are discarded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0.33</para>
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// <para>The width of the watermark image in the output video. The value can be an integer or a decimal.</para>
                /// <list type="bullet">
                /// <item><description><b>Integer</b>: the width of the watermark image. This indicates the absolute position. Unit: pixel.</description></item>
                /// <item><description><b>Decimal</b>: the ratio of the width of the watermark image to the width of the output video. The ratio varies based on the size of the video. Four decimal places are supported, such as 0.9999. More decimal places are discarded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0.36</para>
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// <para>The position of the watermark. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TopRight</b>: the upper-right corner.</description></item>
            /// <item><description><b>TopLeft</b>: the upper-left corner.</description></item>
            /// <item><description><b>BottomRight</b>: the lower-right corner.</description></item>
            /// <item><description><b>BottomLeft</b>: the lower-left corner.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TopRight</para>
            /// </summary>
            [NameInMap("ReferPos")]
            [Validation(Required=false)]
            public string ReferPos { get; set; }

            /// <summary>
            /// <para>The status of the watermark template.</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: The watermark template is normal.</description></item>
            /// <item><description><b>Deleted</b>: The watermark template is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The timeline of the watermark.</para>
            /// </summary>
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public AddWaterMarkTemplateResponseBodyWaterMarkTemplateTimeline Timeline { get; set; }
            public class AddWaterMarkTemplateResponseBodyWaterMarkTemplateTimeline : TeaModel {
                /// <summary>
                /// <para>The display duration of the watermark. Default value: <b>ToEND</b>. The default value indicates that the watermark is displayed until the video ends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ToEND</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which the watermark is displayed.</para>
                /// <list type="bullet">
                /// <item><description>Unit: seconds.</description></item>
                /// <item><description>Default value: <b>0</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>The type of the watermark. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Image: an image watermark.</description></item>
            /// <item><description>Text: a text watermark.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The width of the watermark image. Unit: pixel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

    }

}
