// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyPolicyGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable local camera redirection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("CameraRedirect")]
        [Validation(Required=false)]
        public string CameraRedirect { get; set; }

        /// <summary>
        /// <para>The clipboard permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>readwrite</para>
        /// </summary>
        [NameInMap("Clipboard")]
        [Validation(Required=false)]
        public string Clipboard { get; set; }

        /// <summary>
        /// <para>The file transfer policy for the Wuying web client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("Html5FileTransfer")]
        [Validation(Required=false)]
        public string Html5FileTransfer { get; set; }

        /// <summary>
        /// <para>The local disk mapping permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LocalDrive")]
        [Validation(Required=false)]
        public string LocalDrive { get; set; }

        /// <summary>
        /// <para>Specifies whether to lock the resolution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("LockResolution")]
        [Validation(Required=false)]
        public string LockResolution { get; set; }

        /// <summary>
        /// <para>Network redirection.</para>
        /// </summary>
        [NameInMap("NetRedirectPolicy")]
        [Validation(Required=false)]
        public ModifyPolicyGroupRequestNetRedirectPolicy NetRedirectPolicy { get; set; }
        public class ModifyPolicyGroupRequestNetRedirectPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to manually configure a transparent proxy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("CustomProxy")]
            [Validation(Required=false)]
            public string CustomProxy { get; set; }

            /// <summary>
            /// <para>The IP address of the transparent proxy. The value must be an IPv4 address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX</para>
            /// </summary>
            [NameInMap("HostAddr")]
            [Validation(Required=false)]
            public string HostAddr { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable network redirection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("NetRedirect")]
            [Validation(Required=false)]
            public string NetRedirect { get; set; }

            /// <summary>
            /// <para>The port for the transparent proxy. The port number must be an integer from 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1145</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The password for the proxy. The password must be 1 to 256 characters in length and cannot contain Chinese characters or spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>password</para>
            /// </summary>
            [NameInMap("ProxyPassword")]
            [Validation(Required=false)]
            public string ProxyPassword { get; set; }

            /// <summary>
            /// <para>The proxy protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>socks5</para>
            /// </summary>
            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

            /// <summary>
            /// <para>The username for the proxy. The username must be 1 to 256 characters in length and cannot contain Chinese characters or spaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>username</para>
            /// </summary>
            [NameInMap("ProxyUserName")]
            [Validation(Required=false)]
            public string ProxyUserName { get; set; }

            /// <summary>
            /// <para>The proxy rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<ModifyPolicyGroupRequestNetRedirectPolicyRules> Rules { get; set; }
            public class ModifyPolicyGroupRequestNetRedirectPolicyRules : TeaModel {
                /// <summary>
                /// <para>The rule type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>domain</para>
                /// </summary>
                [NameInMap("RuleType")]
                [Validation(Required=false)]
                public string RuleType { get; set; }

                /// <summary>
                /// <para>The application package name or domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

            }

        }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-4bi18ebi9tfjh****</para>
        /// </summary>
        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default policy</para>
        /// </summary>
        [NameInMap("PolicyGroupName")]
        [Validation(Required=false)]
        public string PolicyGroupName { get; set; }

        /// <summary>
        /// <para>The height of the resolution. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1280</para>
        /// </summary>
        [NameInMap("ResolutionHeight")]
        [Validation(Required=false)]
        public int? ResolutionHeight { get; set; }

        /// <summary>
        /// <para>The width of the resolution. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("ResolutionWidth")]
        [Validation(Required=false)]
        public int? ResolutionWidth { get; set; }

        /// <summary>
        /// <para>The screen watermark.</para>
        /// </summary>
        [NameInMap("Watermark")]
        [Validation(Required=false)]
        public ModifyPolicyGroupRequestWatermark Watermark { get; set; }
        public class ModifyPolicyGroupRequestWatermark : TeaModel {
            /// <summary>
            /// <para>The font color of the watermark. Valid values: 0 to 16777215.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WatermarkColor")]
            [Validation(Required=false)]
            public int? WatermarkColor { get; set; }

            /// <summary>
            /// <para>The custom text for the watermark. The text can be up to 10 characters in length and cannot contain emoji characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom text</para>
            /// </summary>
            [NameInMap("WatermarkCustomText")]
            [Validation(Required=false)]
            public string WatermarkCustomText { get; set; }

            /// <summary>
            /// <para>The font size of the watermark. Valid values: 10 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("WatermarkFontSize")]
            [Validation(Required=false)]
            public int? WatermarkFontSize { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the screen watermark.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("WatermarkSwitch")]
            [Validation(Required=false)]
            public string WatermarkSwitch { get; set; }

            /// <summary>
            /// <para>The opacity of the watermark. A larger value makes the watermark more opaque. Valid values: 10 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("WatermarkTransparencyValue")]
            [Validation(Required=false)]
            public int? WatermarkTransparencyValue { get; set; }

            /// <summary>
            /// <para>The content of the screen watermark.</para>
            /// </summary>
            [NameInMap("WatermarkTypes")]
            [Validation(Required=false)]
            public List<string> WatermarkTypes { get; set; }

        }

    }

}
