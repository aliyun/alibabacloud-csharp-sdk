// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyBrowserInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The browser configuration.</para>
        /// </summary>
        [NameInMap("BrowserConfig")]
        [Validation(Required=false)]
        public ModifyBrowserInstanceGroupRequestBrowserConfig BrowserConfig { get; set; }
        public class ModifyBrowserInstanceGroupRequestBrowserConfig : TeaModel {
            /// <summary>
            /// <para>The bookmarks.</para>
            /// </summary>
            [NameInMap("Bookmarks")]
            [Validation(Required=false)]
            public List<ModifyBrowserInstanceGroupRequestBrowserConfigBookmarks> Bookmarks { get; set; }
            public class ModifyBrowserInstanceGroupRequestBrowserConfigBookmarks : TeaModel {
                /// <summary>
                /// <para>The folder to which the bookmark belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BookmarkFolder")]
                [Validation(Required=false)]
                public string BookmarkFolder { get; set; }

                /// <summary>
                /// <para>The bookmark ID. This parameter is required only for modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bm-12345</para>
                /// </summary>
                [NameInMap("BookmarkId")]
                [Validation(Required=false)]
                public string BookmarkId { get; set; }

                /// <summary>
                /// <para>The bookmark name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BookmarkName")]
                [Validation(Required=false)]
                public string BookmarkName { get; set; }

                /// <summary>
                /// <para>The bookmark URL.</para>
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
            /// <b>Example:</b>
            /// <para>cn-hangzhou/aig_upm/xxx/temp/BrowserBookmarks/浏览器书签模版.csv</para>
            /// </summary>
            [NameInMap("BookmarksFilePath")]
            [Validation(Required=false)]
            public string BookmarksFilePath { get; set; }

            /// <summary>
            /// <para>The startup parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--incognito</para>
            /// </summary>
            [NameInMap("BrowserParam")]
            [Validation(Required=false)]
            public string BrowserParam { get; set; }

            [NameInMap("CookiesSync")]
            [Validation(Required=false)]
            public bool? CookiesSync { get; set; }

            /// <summary>
            /// <para>The homepage.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }

            /// <summary>
            /// <para>The list of bookmarks to remove.</para>
            /// </summary>
            [NameInMap("RemoveBookmarks")]
            [Validation(Required=false)]
            public List<string> RemoveBookmarks { get; set; }

        }

        /// <summary>
        /// <para>The ID of the cloud browser to modify.</para>
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
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxAmount")]
        [Validation(Required=false)]
        public int? MaxAmount { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public ModifyBrowserInstanceGroupRequestNetwork Network { get; set; }
        public class ModifyBrowserInstanceGroupRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The access restriction type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALLOW_LIST</para>
            /// </summary>
            [NameInMap("AccessRestriction")]
            [Validation(Required=false)]
            public string AccessRestriction { get; set; }

            /// <summary>
            /// <para>The list of domain names to remove.</para>
            /// </summary>
            [NameInMap("RemoveRestrictedURLIds")]
            [Validation(Required=false)]
            public List<string> RemoveRestrictedURLIds { get; set; }

            /// <summary>
            /// <para>The restricted domain name configurations.</para>
            /// </summary>
            [NameInMap("RestrictedURLs")]
            [Validation(Required=false)]
            public List<ModifyBrowserInstanceGroupRequestNetworkRestrictedURLs> RestrictedURLs { get; set; }
            public class ModifyBrowserInstanceGroupRequestNetworkRestrictedURLs : TeaModel {
                /// <summary>
                /// <para>The ID of the domain name configuration. This parameter is required only for modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ru-12345</para>
                /// </summary>
                [NameInMap("RestrictedURLId")]
                [Validation(Required=false)]
                public string RestrictedURLId { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun.com</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou/aig_upm/xxx/temp/BrowserRestrictionUrls/URL白名单模版.csv</para>
            /// </summary>
            [NameInMap("RestrictedURLsFilePath")]
            [Validation(Required=false)]
            public string RestrictedURLsFilePath { get; set; }

        }

        /// <summary>
        /// <para>The access policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public ModifyBrowserInstanceGroupRequestPolicy Policy { get; set; }
        public class ModifyBrowserInstanceGroupRequestPolicy : TeaModel {
            /// <summary>
            /// <para>The clipboard policy settings.</para>
            /// </summary>
            [NameInMap("ClipboardPolicy")]
            [Validation(Required=false)]
            public ModifyBrowserInstanceGroupRequestPolicyClipboardPolicy ClipboardPolicy { get; set; }
            public class ModifyBrowserInstanceGroupRequestPolicyClipboardPolicy : TeaModel {
                /// <summary>
                /// <para>The clipboard policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("Clipboard")]
                [Validation(Required=false)]
                public string Clipboard { get; set; }

                /// <summary>
                /// <para>The maximum length for clipboard read operations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ClipboardReadLimit")]
                [Validation(Required=false)]
                public int? ClipboardReadLimit { get; set; }

                /// <summary>
                /// <para>The clipboard control scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>global</para>
                /// </summary>
                [NameInMap("ClipboardScope")]
                [Validation(Required=false)]
                public string ClipboardScope { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>B</para>
                /// </summary>
                [NameInMap("ClipboardSizeUnit")]
                [Validation(Required=false)]
                public string ClipboardSizeUnit { get; set; }

                /// <summary>
                /// <para>The maximum length for clipboard write operations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("ClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? ClipboardWriteLimit { get; set; }

                /// <summary>
                /// <para>The file clipboard policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("FileClipboard")]
                [Validation(Required=false)]
                public string FileClipboard { get; set; }

                /// <summary>
                /// <para>The rich text clipboard policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("RichTextClipboard")]
                [Validation(Required=false)]
                public string RichTextClipboard { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RichTextClipboardLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RichTextClipboardReadLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardReadLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("RichTextClipboardReadSizeUnit")]
                [Validation(Required=false)]
                public string RichTextClipboardReadSizeUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>B</para>
                /// </summary>
                [NameInMap("RichTextClipboardSizeUnit")]
                [Validation(Required=false)]
                public string RichTextClipboardSizeUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RichTextClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardWriteLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("RichTextClipboardWriteSizeUnit")]
                [Validation(Required=false)]
                public string RichTextClipboardWriteSizeUnit { get; set; }

                /// <summary>
                /// <para>The text clipboard policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("TextClipboard")]
                [Validation(Required=false)]
                public string TextClipboard { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TextClipboardReadLimit")]
                [Validation(Required=false)]
                public int? TextClipboardReadLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("TextClipboardReadSizeUnit")]
                [Validation(Required=false)]
                public string TextClipboardReadSizeUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TextClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? TextClipboardWriteLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("TextClipboardWriteSizeUnit")]
                [Validation(Required=false)]
                public string TextClipboardWriteSizeUnit { get; set; }

            }

            /// <summary>
            /// <para>The data retention policy for sessions after disconnection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customTime</para>
            /// </summary>
            [NameInMap("DisconnectKeepSession")]
            [Validation(Required=false)]
            public string DisconnectKeepSession { get; set; }

            /// <summary>
            /// <para>The session retention duration after disconnection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("DisconnectKeepSessionTime")]
            [Validation(Required=false)]
            public int? DisconnectKeepSessionTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("FileManager")]
            [Validation(Required=false)]
            public string FileManager { get; set; }

            /// <summary>
            /// <para>The file transfer policy for the web client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// <para>The policy for disconnecting sessions after no operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("NoOperationDisconnect")]
            [Validation(Required=false)]
            public string NoOperationDisconnect { get; set; }

            /// <summary>
            /// <para>The idle timeout period before disconnection, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("NoOperationDisconnectTime")]
            [Validation(Required=false)]
            public int? NoOperationDisconnectTime { get; set; }

            /// <summary>
            /// <para>The policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-12345</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The policy version.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("WatermarkSwitch")]
                [Validation(Required=false)]
                public string WatermarkSwitch { get; set; }

                /// <summary>
                /// <para>The list of watermark types.</para>
                /// </summary>
                [NameInMap("WatermarkTypes")]
                [Validation(Required=false)]
                public List<string> WatermarkTypes { get; set; }

            }

        }

        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public ModifyBrowserInstanceGroupRequestStoragePolicy StoragePolicy { get; set; }
        public class ModifyBrowserInstanceGroupRequestStoragePolicy : TeaModel {
            [NameInMap("UserProfile")]
            [Validation(Required=false)]
            public ModifyBrowserInstanceGroupRequestStoragePolicyUserProfile UserProfile { get; set; }
            public class ModifyBrowserInstanceGroupRequestStoragePolicyUserProfile : TeaModel {
                [NameInMap("UserProfileSwitch")]
                [Validation(Required=false)]
                public bool? UserProfileSwitch { get; set; }

            }

        }

        /// <summary>
        /// <para>The timers.</para>
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
            /// <para>The timer type.</para>
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
