// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyAppPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-ee2znjktwgxu2****</para>
        /// </summary>
        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: RDS Cloud App</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Displays the policy.</para>
        /// </summary>
        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public ModifyAppPolicyRequestVideoPolicy VideoPolicy { get; set; }
        public class ModifyAppPolicyRequestVideoPolicy : TeaModel {
            /// <summary>
            /// <para>The frame rate (FPS).</para>
            /// <para>Enumerated values:</para>
            /// <list type="bullet">
            /// <item><description>30: 30 FPS</description></item>
            /// <item><description>60: 60 FPS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public int? FrameRate { get; set; }

            /// <summary>
            /// <para>The height of the resolution, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("SessionResolutionHeight")]
            [Validation(Required=false)]
            public int? SessionResolutionHeight { get; set; }

            /// <summary>
            /// <para>The width of the resolution, in pixels.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1920</para>
            /// </summary>
            [NameInMap("SessionResolutionWidth")]
            [Validation(Required=false)]
            public int? SessionResolutionWidth { get; set; }

            /// <summary>
            /// <para>The stream mode. This parameter is used together with <c>Webrtc</c> to specify the protocol type.</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>Webrtc</c> to <c>true</c> and <c>StreamingMode</c> to <c>video</c>, Web Real-Time Communications (WebRTC) streams are used.</description></item>
            /// <item><description>If you set <c>Webrtc</c> to <c>false</c> and <c>StreamingMode</c> to <c>video</c>, video streams are used.</description></item>
            /// <item><description>If you set <c>Webrtc</c> to <c>false</c> and <c>StreamingMode</c> to <c>mix</c>, mixed streams are used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            /// <summary>
            /// <para>Whether to use adaptive resolution.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: The session resolution changes with the display area of the terminal. In this case, <c>SessionResolutionWidth</c> indicates the maximum resolution width and <c>SessionResolutionHeight</c> indicates the maximum resolution height.</description></item>
            /// <item><description><c>false</c>: The session resolution does not change with the display area of the terminal. In this case, <c>SessionResolutionWidth</c> specifies the fixed resolution width and <c>SessionResolutionHeight</c> specifies the fixed resolution height.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TerminalResolutionAdaptive")]
            [Validation(Required=false)]
            public bool? TerminalResolutionAdaptive { get; set; }

            /// <summary>
            /// <para>The image quality policy.</para>
            /// <para>Enumerated values:</para>
            /// <list type="bullet">
            /// <item><description>adaptive: adaptive.</description></item>
            /// <item><description>smooth: smooth first.</description></item>
            /// <item><description>quality: quality first.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>smooth</para>
            /// </summary>
            [NameInMap("VisualQualityStrategy")]
            [Validation(Required=false)]
            public string VisualQualityStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable WebRTC. This parameter is used together with <c>StreamingMode</c> to specify the protocol type.</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>Webrtc</c> to <c>true</c> and <c>StreamingMode</c> to <c>video</c>, WebRTC streams are used.</description></item>
            /// <item><description>If you set <c>Webrtc</c> to <c>false</c> and <c>StreamingMode</c> to <c>video</c>, video streams are used.</description></item>
            /// <item><description>If you set <c>Webrtc</c> to <c>false</c> and <c>StreamingMode</c> to <c>mix</c>, mixed streams are used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Webrtc")]
            [Validation(Required=false)]
            public bool? Webrtc { get; set; }

        }

    }

}
