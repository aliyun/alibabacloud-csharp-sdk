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
            /// <para>The asset binding list.</para>
            /// </summary>
            [NameInMap("AssetBindings")]
            [Validation(Required=false)]
            public List<VideoGenerationRequestInputAssetBindings> AssetBindings { get; set; }
            public class VideoGenerationRequestInputAssetBindings : TeaModel {
                /// <summary>
                /// <para>The asset index, such as 0, 1, 2, or 3, which must be consistent with the number of the image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssetIndex")]
                [Validation(Required=false)]
                public int? AssetIndex { get; set; }

                /// <summary>
                /// <para>The description of the image. Examples:   </para>
                /// <ol>
                /// <item><description>Description for look_reference: Front full-body outfit reference image of the person.   </description></item>
                /// <item><description>Description for scene_reference: Specified clothing display scene.   </description></item>
                /// <item><description>Description for garment_reference:<br>● Front of the top;<br>● Back of the bottom;<br>● Side of the shoes.</description></item>
                /// </ol>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Specifies the asset usage. Valid values:   </para>
                /// <list type="bullet">
                /// <item><description>look_reference: Corresponds to the full outfit effect image of the person wearing the clothes (overall visual).   </description></item>
                /// <item><description>scene_reference: Corresponds to the scene reference image (usually the cover main image).   </description></item>
                /// <item><description>garment_reference: Corresponds to all product detail images (including front, back, and side of clothes, shoes, skirts, and other partial close-ups).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
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
            /// <para>The list of product image URLs (1 to 8 images), which must be accessible over the Internet.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// <para>The product title. Only the first 60 characters are used.</para>
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
            /// <para>The delivery channel.</para>
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
            /// <para>Specifies the business goal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>camera_motion: Camera movement mode. Generates videos based on a fixed 360-degree camera movement logic.</para>
            /// </description></item>
            /// <item><description><para>scripted_video: Scripted mode. Provides a script or prompt, and the system generates the video according to the script.</para>
            /// </description></item>
            /// <item><description><para>auto_video: Unscripted mode. Does not provide a script, and the system automatically plans the script and generates the video.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>auto_video</para>
            /// </summary>
            [NameInMap("Goal")]
            [Validation(Required=false)]
            public string Goal { get; set; }

            /// <summary>
            /// <para>The script or prompt.</para>
            /// 
            /// <b>Example:</b>
            /// <para>【2. Shot Breakdown】<br>[0-1s]【Eye-level close-up, static camera】Summer commute trousers folded on a clean tabletop; one corner is quickly unfolded to reveal the solid-color fabric and crisp crease line. The frame focuses on the trouser leg\&quot;s surface smoothness and sharp appearance. [BGM/SFX: Upbeat, crisp commute-vibe background music begins]</para>
            /// <para>[1-2s]【Low-angle mid-shot, static camera】The full pair of trousers hangs freely in the air with a slight swing, showcasing the natural drape of the lightweight fabric and the complete straight-leg silhouette, then returns to a still, hanging state.</para>
            /// <para>[2-3s]【Eye-level mid-shot, static camera】A commute-styled model stands in a fitting area, holding the folded trousers at waist level with both hands, performing one up-and-down sizing gesture before holding them steady, displaying the overall proportions of the trousers in their folded state and the expected fit. [[Voiceover]: Who says wearing trousers in summer has to be stuffy? Most likely you just haven\&quot;t picked the right pair.]</para>
            /// <para>[3-5s]【Eye-level full shot, slight pullback】The commute-styled model, now wearing the trousers paired with a clean commute top, takes two steps forward in a modern office building corridor, dynamically showcasing the front straight-leg silhouette, trouser leg lines, and commute outfit coordination.</para>
            /// <para>[5-7s]【Low-angle mid-shot, static camera】The commute-styled model shifts to an angled side stance, one hand in the front pocket and the other in the back pocket, displaying the cut from waist and hip down to the knee, the solid-color surface, and the clean lateral lines.</para>
            /// <para>[7-9s]【Eye-level mid-shot, static camera】The commute-styled model lifts one foot onto a low step, one hand brushes down the lower-leg trouser fabric and lightly lifts the hem, briefly exposing the ankle, showcasing the hem edge, side-seam details, and the wearing state during movement. [[Voiceover]: These ice-skin trousers are lightweight and breathable, solid-color straight-leg — looking sharp and at ease even when walking around at work.]</para>
            /// <para>[9-11s]【Overhead close-up, static camera】The lens focuses closely on the waistband area; the commute-styled model presses both hands along the waistband contour and smooths it, then pauses to display the seams and actual wearing state, clearly presenting the waistband shape and structural details.</para>
            /// <para>[11-13s]【Eye-level close-up, static camera】The commute-styled model gently lifts the fabric on both sides of the thigh with both hands, then raises one knee with a slight lateral turn before returning to a natural stance, demonstrating the actual range of motion during knee-lift and side-turn, as well as how the straight-leg trouser recovers after the foot lands.</para>
            /// <para>[13-15s]【Eye-level close-up, static camera】The commute-styled model enters the frame from the rear side, places one hand in the back pocket, then lightly traces along the back pocket edge and rear waist seam, showcasing the back pocket contour, pocket opening edge, and rear waist seam details up close. [[Voiceover]: If you\&quot;re always on the move, there\&quot;s room for knee lifts and side turns — commuting just got easier.]</para>
            /// <para>[15-17s]【Eye-level mid-shot, static camera】The commute-styled model faces away to display the rear silhouette of the trousers, hands naturally in pockets with a slight weight shift, then turns slightly to an angled side view so both the rear and lateral trouser lines are visible, fully presenting the rear cut and the overall line from hip and thigh down to the hem.</para>
            /// <para>[17-19s]【Eye-level full shot, smooth follow】The commute-styled model first walks sideways to the right, then transitions into a forward stride to complete the full presentation, finishing in the modern office building corridor in full commute attire, clearly showing the front straight-leg silhouette, clean lines, and overall fit. [[Voiceover]: If you like this fit, go check out the details.]</para>
            /// <para>【3. Negative/Constraint Instructions】<br>The entire video centers on the summer commute trousers; no unrelated products or multi-person interactions are allowed.</para>
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
            /// <para>The video duration varies by Intent.goal: auto_video supports 5 to 15 seconds, scripted_video supports 5 to 30 seconds, and camera_motion generates a fixed 10-second video and returns two 5-second videos.</para>
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
            /// <para>The aspect ratio varies by Intent.goal: auto_video and scripted_video only support 9:16, and camera_motion only supports 3:4.</para>
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
