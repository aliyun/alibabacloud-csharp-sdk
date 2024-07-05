// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateWaterMarkTemplateResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the watermark template.
        /// </summary>
        [NameInMap("WaterMarkTemplate")]
        [Validation(Required=false)]
        public UpdateWaterMarkTemplateResponseBodyWaterMarkTemplate WaterMarkTemplate { get; set; }
        public class UpdateWaterMarkTemplateResponseBodyWaterMarkTemplate : TeaModel {
            /// <summary>
            /// The horizontal offset. Unit: pixel.
            /// </summary>
            [NameInMap("Dx")]
            [Validation(Required=false)]
            public string Dx { get; set; }

            /// <summary>
            /// The vertical offset. Unit: pixel.
            /// </summary>
            [NameInMap("Dy")]
            [Validation(Required=false)]
            public string Dy { get; set; }

            /// <summary>
            /// The height of the watermark image. Unit: pixel.
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// The ID of the watermark template. We recommend that you keep this ID for subsequent operation calls.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the watermark template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The values of the Height, Width, Dx, and Dy parameters relative to the reference edges. If the values of the Height, Width, Dx, and Dy parameters are decimals between 0 and 1, the values are calculated by referring to the following edges in sequence:
            /// 
            /// *   **Width**: the width edge.
            /// *   **Height**: the height edge.
            /// *   **Long**: the long edge.
            /// *   **Short**: the short edge.
            /// </summary>
            [NameInMap("RatioRefer")]
            [Validation(Required=false)]
            public UpdateWaterMarkTemplateResponseBodyWaterMarkTemplateRatioRefer RatioRefer { get; set; }
            public class UpdateWaterMarkTemplateResponseBodyWaterMarkTemplateRatioRefer : TeaModel {
                /// <summary>
                /// The horizontal offset of the watermark relative to the output video image. Default value: **0**. The default value indicates no offset. The value can be an integer or a decimal.
                /// 
                /// *   **Integer**: the vertical offset. This indicates the absolute position. Unit: pixel.
                /// *   **Decimal**: the ratio of the horizontal offset to the width of the output video. The ratio varies based on the size of the video. Four decimal places are supported, such as 0.9999. More decimal places are discarded.
                /// </summary>
                [NameInMap("Dx")]
                [Validation(Required=false)]
                public string Dx { get; set; }

                /// <summary>
                /// The vertical offset of the watermark relative to the output video image. Default value: **0**. The default value indicates no offset. The value can be an integer or a decimal.
                /// 
                /// *   **Integer**: the vertical offset. This indicates the absolute position. Unit: pixel.
                /// *   **Decimal**: the ratio of the vertical offset to the height of the output video. The ratio varies based on the size of the video. Four decimal places are supported, such as 0.9999. More decimal places are discarded.
                /// </summary>
                [NameInMap("Dy")]
                [Validation(Required=false)]
                public string Dy { get; set; }

                /// <summary>
                /// The height of the watermark image in the output video. The value can be an integer or a decimal.
                /// 
                /// *   **Integer**: the height of the watermark image. This indicates the absolute position. Unit: pixel.
                /// *   **Decimal**: the ratio of the height of the watermark image to the height of the output video. The ratio varies based on the size of the video. Four decimal places are supported, such as 0.9999. More decimal places are discarded.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// The width of the watermark image in the output video. The value can be an integer or a decimal.
                /// 
                /// *   **Integer**: the width of the watermark image. This indicates the absolute position. Unit: pixel.
                /// *   **Decimal**: the ratio of the width of the watermark image to the width of the output video. The ratio varies based on the size of the video. Four decimal places are supported, such as 0.9999. More decimal places are discarded.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// The position of the watermark. Valid values:
            /// 
            /// *   **TopRight**: the upper-right corner.
            /// *   **TopLeft**: the upper-left corner.
            /// *   **BottomRight**: the lower-right corner.
            /// *   **BottomLeft**: the lower-left corner.
            /// </summary>
            [NameInMap("ReferPos")]
            [Validation(Required=false)]
            public string ReferPos { get; set; }

            /// <summary>
            /// The status of the watermark template. Default value: **Normal**.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The timeline of the watermark.
            /// </summary>
            [NameInMap("Timeline")]
            [Validation(Required=false)]
            public UpdateWaterMarkTemplateResponseBodyWaterMarkTemplateTimeline Timeline { get; set; }
            public class UpdateWaterMarkTemplateResponseBodyWaterMarkTemplateTimeline : TeaModel {
                /// <summary>
                /// The display duration of the watermark. Default value: **ToEND**. The default value indicates that the watermark is displayed until the video ends.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The beginning of the time range during which the watermark is displayed.
                /// 
                /// *   Unit: seconds.
                /// *   Default value: **0**.
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// The type of the watermark. Valid values:
            /// 
            /// *   Image: an image watermark.
            /// *   Text: a text watermark.
            /// 
            /// > Only watermarks of the Image type are supported.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The width of the watermark image. Unit: pixel.
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

    }

}
