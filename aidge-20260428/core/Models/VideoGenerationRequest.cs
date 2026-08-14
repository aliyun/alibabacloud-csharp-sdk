// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VideoGenerationRequest : TeaModel {
        /// <summary>
        /// <para>The product input.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public VideoGenerationRequestInput Input { get; set; }
        public class VideoGenerationRequestInput : TeaModel {
            /// <summary>
            /// <para>Specifies the purpose and description of images by asset index.</para>
            /// </summary>
            [NameInMap("AssetBindings")]
            [Validation(Required=false)]
            public List<VideoGenerationRequestInputAssetBindings> AssetBindings { get; set; }
            public class VideoGenerationRequestInputAssetBindings : TeaModel {
                /// <summary>
                /// <para>The asset index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssetIndex")]
                [Validation(Required=false)]
                public int? AssetIndex { get; set; }

                /// <summary>
                /// <para>The natural language description of the asset.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>look_reference: appearance reference.</description></item>
                /// <item><description>scene_reference: scene reference.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("Slot")]
                [Validation(Required=false)]
                public string Slot { get; set; }

            }

            /// <summary>
            /// <para>The extended information.</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extra { get; set; }

            /// <summary>
            /// <para>The list of product image URLs (1 to 6 images). The URLs must be publicly accessible.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// <para>The product title. A maximum of the first 60 characters are used.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026 New Slimming Women\&quot;s Summer Dress with Mid-Length Design, High-Quality Waist Definition for a Slender Look</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The intent parameters. Currently unavailable.</para>
        /// </summary>
        [NameInMap("Intent")]
        [Validation(Required=false)]
        public VideoGenerationRequestIntent Intent { get; set; }
        public class VideoGenerationRequestIntent : TeaModel {
            /// <summary>
            /// <para>The distribution channel.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The business goal.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Goal")]
            [Validation(Required=false)]
            public string Goal { get; set; }

            /// <summary>
            /// <para>Required when goal is set to scripted_video.</para>
            /// </summary>
            [NameInMap("Script")]
            [Validation(Required=false)]
            public string Script { get; set; }

        }

        /// <summary>
        /// <para>The output parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public VideoGenerationRequestOutput Output { get; set; }
        public class VideoGenerationRequestOutput : TeaModel {
            /// <summary>
            /// <para>The video duration in seconds. Currently supports integers between 5 and 15. More options will be available in the future.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The output resolution.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080p</para>
            /// </summary>
            [NameInMap("Quality")]
            [Validation(Required=false)]
            public string Quality { get; set; }

            /// <summary>
            /// <para>The video aspect ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9:16</para>
            /// </summary>
            [NameInMap("Ratio")]
            [Validation(Required=false)]
            public string Ratio { get; set; }

        }

    }

}
