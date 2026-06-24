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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The display policy.</para>
        /// </summary>
        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public ModifyAppPolicyRequestVideoPolicy VideoPolicy { get; set; }
        public class ModifyAppPolicyRequestVideoPolicy : TeaModel {
            /// <summary>
            /// <para>The frame rate (FPS).</para>
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
            /// <para>The streaming mode. This parameter is used together with the Webrtc parameter to specify the protocol type.</para>
            /// <list type="bullet">
            /// <item><description>Webrtc=<c>true</c> and StreamingMode=<c>video</c>: WebRTC stream.</description></item>
            /// <item><description>Webrtc=<c>false</c> and StreamingMode=<c>video</c>: video stream.</description></item>
            /// <item><description>Webrtc=<c>false</c> and StreamingMode=<c>mix</c>: mixed stream.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("StreamingMode")]
            [Validation(Required=false)]
            public string StreamingMode { get; set; }

            /// <summary>
            /// <para>Specifies whether to use adaptive resolution.</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The session resolution follows changes in the terminal display area. In this case, SessionResolutionWidth and SessionResolutionHeight specify the maximum resolution values.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The session resolution does not follow changes in the terminal display area. In this case, the resolution is fixed to the values of SessionResolutionWidth and SessionResolutionHeight.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TerminalResolutionAdaptive")]
            [Validation(Required=false)]
            public bool? TerminalResolutionAdaptive { get; set; }

            /// <summary>
            /// <para>The visual quality strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>smooth</para>
            /// </summary>
            [NameInMap("VisualQualityStrategy")]
            [Validation(Required=false)]
            public string VisualQualityStrategy { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable WebRTC. This parameter is used together with the StreamingMode parameter to specify the protocol type.</para>
            /// <list type="bullet">
            /// <item><description>Webrtc=<c>true</c> and StreamingMode=<c>video</c>: WebRTC stream.</description></item>
            /// <item><description>Webrtc=<c>false</c> and StreamingMode=<c>video</c>: video stream.</description></item>
            /// <item><description>Webrtc=<c>false</c> and StreamingMode=<c>mix</c>: mixed stream.</description></item>
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
