// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyBrowserInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The browser settings.</para>
        /// </summary>
        [NameInMap("BrowserConfig")]
        [Validation(Required=false)]
        public ModifyBrowserInstanceGroupRequestBrowserConfig BrowserConfig { get; set; }
        public class ModifyBrowserInstanceGroupRequestBrowserConfig : TeaModel {
            /// <summary>
            /// <para>The bookmark.</para>
            /// </summary>
            [NameInMap("Bookmarks")]
            [Validation(Required=false)]
            public List<ModifyBrowserInstanceGroupRequestBrowserConfigBookmarks> Bookmarks { get; set; }
            public class ModifyBrowserInstanceGroupRequestBrowserConfigBookmarks : TeaModel {
                /// <summary>
                /// <para>The folder where the bookmark is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BookmarkFolder")]
                [Validation(Required=false)]
                public string BookmarkFolder { get; set; }

                /// <summary>
                /// <para>The ID of the bookmark. This parameter needs to be specified only to modify the bookmark.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bm-12345</para>
                /// </summary>
                [NameInMap("BookmarkId")]
                [Validation(Required=false)]
                public string BookmarkId { get; set; }

                /// <summary>
                /// <para>The name of the bookmark.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BookmarkName")]
                [Validation(Required=false)]
                public string BookmarkName { get; set; }

                /// <summary>
                /// <para>The URL of the bookmark.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("BookmarkURL")]
                [Validation(Required=false)]
                public string BookmarkURL { get; set; }

            }

            /// <summary>
            /// <para>The startup parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--incognito</para>
            /// </summary>
            [NameInMap("BrowserParam")]
            [Validation(Required=false)]
            public string BrowserParam { get; set; }

            /// <summary>
            /// <para>The home page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }

            /// <summary>
            /// <para>The removed bookmarks.</para>
            /// </summary>
            [NameInMap("RemoveBookmarks")]
            [Validation(Required=false)]
            public List<string> RemoveBookmarks { get; set; }

        }

        /// <summary>
        /// <para>The ID of the cloud browser to be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>big-0bz55ixxxxx9xi9w9</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the cloud browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BrowserTest</para>
        /// </summary>
        [NameInMap("CloudBrowserName")]
        [Validation(Required=false)]
        public string CloudBrowserName { get; set; }

        /// <summary>
        /// <para>The network configurations.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public ModifyBrowserInstanceGroupRequestNetwork Network { get; set; }
        public class ModifyBrowserInstanceGroupRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The type of the access control list.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>ALLOW_LIST: The whitelist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALLOW_LIST</para>
            /// </summary>
            [NameInMap("AccessRestriction")]
            [Validation(Required=false)]
            public string AccessRestriction { get; set; }

            /// <summary>
            /// <para>The domain names to be removed.</para>
            /// </summary>
            [NameInMap("RemoveRestrictedURLIds")]
            [Validation(Required=false)]
            public List<string> RemoveRestrictedURLIds { get; set; }

            /// <summary>
            /// <para>The domain restriction configurations.</para>
            /// </summary>
            [NameInMap("RestrictedURLs")]
            [Validation(Required=false)]
            public List<ModifyBrowserInstanceGroupRequestNetworkRestrictedURLs> RestrictedURLs { get; set; }
            public class ModifyBrowserInstanceGroupRequestNetworkRestrictedURLs : TeaModel {
                /// <summary>
                /// <para>The ID of the domain name. This parameter is required only when you want to modify the domain restriction configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ru-12345</para>
                /// </summary>
                [NameInMap("RestrictedURLId")]
                [Validation(Required=false)]
                public string RestrictedURLId { get; set; }

                /// <summary>
                /// <para>The restricted domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun.com</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

        }

        /// <summary>
        /// <para>The access policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public ModifyBrowserInstanceGroupRequestPolicy Policy { get; set; }
        public class ModifyBrowserInstanceGroupRequestPolicy : TeaModel {
            /// <summary>
            /// <para>The settings related to clipboard control.</para>
            /// </summary>
            [NameInMap("ClipboardPolicy")]
            [Validation(Required=false)]
            public ModifyBrowserInstanceGroupRequestPolicyClipboardPolicy ClipboardPolicy { get; set; }
            public class ModifyBrowserInstanceGroupRequestPolicyClipboardPolicy : TeaModel {
                /// <summary>
                /// <para>The clipboard policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>read: Allows copying from the local device to the cloud browser.</description></item>
                /// <item><description>readwrite: Allows copying in both directions.</description></item>
                /// <item><description>write: Allows copying from the cloud browser to the local device.</description></item>
                /// <item><description>off: Blocks copying in both directions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Clipboard")]
                [Validation(Required=false)]
                public string Clipboard { get; set; }

                /// <summary>
                /// <para>The maximum number of characters allowed when copying from the clipboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ClipboardReadLimit")]
                [Validation(Required=false)]
                public int? ClipboardReadLimit { get; set; }

                /// <summary>
                /// <para>The clipboard control scope.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>grained: fine-grained control</description></item>
                /// <item><description>global: global control</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("ClipboardScope")]
                [Validation(Required=false)]
                public string ClipboardScope { get; set; }

                [NameInMap("ClipboardSizeUnit")]
                [Validation(Required=false)]
                public string ClipboardSizeUnit { get; set; }

                /// <summary>
                /// <para>The maximum number of characters allowed when copying to the clipboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? ClipboardWriteLimit { get; set; }

                /// <summary>
                /// <para>The file clipboard policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>read: Allows copying from the local device to the cloud browser.</description></item>
                /// <item><description>readwrite: Allows copying in both directions.</description></item>
                /// <item><description>write: Allows copying from the cloud browser to the local device.</description></item>
                /// <item><description>off: Blocks copying in both directions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("FileClipboard")]
                [Validation(Required=false)]
                public string FileClipboard { get; set; }

                /// <summary>
                /// <para>The rich text clipboard policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>read: Allows copying from the local device to the cloud browser.</description></item>
                /// <item><description>readwrite: Allows copying in both directions.</description></item>
                /// <item><description>write: Allows copying from the cloud browser to the local device.</description></item>
                /// <item><description>off: Blocks copying in both directions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("RichTextClipboard")]
                [Validation(Required=false)]
                public string RichTextClipboard { get; set; }

                /// <summary>
                /// <para>The text clipboard policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>read: Allows copying from the local device to the cloud browser.</description></item>
                /// <item><description>readwrite: Allows copying in both directions.</description></item>
                /// <item><description>write: Allows copying from the cloud browser to the local device.</description></item>
                /// <item><description>off: Blocks copying in both directions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("TextClipboard")]
                [Validation(Required=false)]
                public string TextClipboard { get; set; }

            }

            /// <summary>
            /// <para>Defines what happens to a session when a user disconnects.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>customTime: The session will be terminated after a custom-defined timeout.</description></item>
            /// <item><description>persistent: The session will never be automatically terminated..</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>customTime</para>
            /// </summary>
            [NameInMap("DisconnectKeepSession")]
            [Validation(Required=false)]
            public string DisconnectKeepSession { get; set; }

            /// <summary>
            /// <para>The session persistence duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("DisconnectKeepSessionTime")]
            [Validation(Required=false)]
            public int? DisconnectKeepSessionTime { get; set; }

            /// <summary>
            /// <para>The file transfer policy on the web client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            [NameInMap("NoOperationDisconnect")]
            [Validation(Required=false)]
            public string NoOperationDisconnect { get; set; }

            [NameInMap("NoOperationDisconnectTime")]
            [Validation(Required=false)]
            public int? NoOperationDisconnectTime { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-12345</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The policy version.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Center: center policy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Center</para>
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            /// <summary>
            /// <para>The display policy.</para>
            /// </summary>
            [NameInMap("VideoPolicy")]
            [Validation(Required=false)]
            public ModifyBrowserInstanceGroupRequestPolicyVideoPolicy VideoPolicy { get; set; }
            public class ModifyBrowserInstanceGroupRequestPolicyVideoPolicy : TeaModel {
                /// <summary>
                /// <para>The frame rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("FrameRate")]
                [Validation(Required=false)]
                public int? FrameRate { get; set; }

            }

            /// <summary>
            /// <para>The watermark configuration.</para>
            /// </summary>
            [NameInMap("WatermarkPolicy")]
            [Validation(Required=false)]
            public ModifyBrowserInstanceGroupRequestPolicyWatermarkPolicy WatermarkPolicy { get; set; }
            public class ModifyBrowserInstanceGroupRequestPolicyWatermarkPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable the watermark.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>off</description></item>
                /// <item><description>on</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("WatermarkSwitch")]
                [Validation(Required=false)]
                public string WatermarkSwitch { get; set; }

                /// <summary>
                /// <para>The watermark types.</para>
                /// </summary>
                [NameInMap("WatermarkTypes")]
                [Validation(Required=false)]
                public List<string> WatermarkTypes { get; set; }

            }

        }

        /// <summary>
        /// <para>The timer.</para>
        /// </summary>
        [NameInMap("Timers")]
        [Validation(Required=false)]
        public List<ModifyBrowserInstanceGroupRequestTimers> Timers { get; set; }
        public class ModifyBrowserInstanceGroupRequestTimers : TeaModel {
            /// <summary>
            /// <para>The interval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The timer type:</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>SESSION_TIMEOUT: Defines the timeout period before a disconnected session is terminated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SESSION_TIMEOUT</para>
            /// </summary>
            [NameInMap("TimerType")]
            [Validation(Required=false)]
            public string TimerType { get; set; }

        }

    }

}
