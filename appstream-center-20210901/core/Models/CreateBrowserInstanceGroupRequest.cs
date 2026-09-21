// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateBrowserInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The plan identifier.</para>
        /// <para>Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AppPackageType")]
        [Validation(Required=false)]
        public string AppPackageType { get; set; }

        /// <summary>
        /// <para>Specifies whether to send authorization and deauthorization notification emails.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Sends the notification.</description></item>
        /// <item><description><c>false</c>: Does not send the notification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthNotificationEnabled")]
        [Validation(Required=false)]
        public bool? AuthNotificationEnabled { get; set; }

        /// <summary>
        /// <para>The automatic payment parameter.</para>
        /// <para>Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The auto-renewal parameter.</para>
        /// <para>Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The business region ID. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The browser configuration.</para>
        /// </summary>
        [NameInMap("BrowserConfig")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestBrowserConfig BrowserConfig { get; set; }
        public class CreateBrowserInstanceGroupRequestBrowserConfig : TeaModel {
            /// <summary>
            /// <para>The list of browser bookmarks.</para>
            /// <para><b>Limit:</b> Cannot be specified together with a non-empty <c>BookmarksFilePath</c>. Bookmark URLs must be unique.</para>
            /// </summary>
            [NameInMap("Bookmarks")]
            [Validation(Required=false)]
            public List<CreateBrowserInstanceGroupRequestBrowserConfigBookmarks> Bookmarks { get; set; }
            public class CreateBrowserInstanceGroupRequestBrowserConfigBookmarks : TeaModel {
                /// <summary>
                /// <para>The folder in which the bookmark is located. The length after trimming leading and trailing whitespace cannot exceed 64 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Work Portal</para>
                /// </summary>
                [NameInMap("BookmarkFolder")]
                [Validation(Required=false)]
                public string BookmarkFolder { get; set; }

                /// <summary>
                /// <para>The bookmark name. This parameter is required and cannot be empty when you create a bookmark. The length after trimming leading and trailing whitespace cannot exceed 64 characters.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud Official Website</para>
                /// </summary>
                [NameInMap("BookmarkName")]
                [Validation(Required=false)]
                public string BookmarkName { get; set; }

                /// <summary>
                /// <para>The URL of the bookmark. This parameter is required when you create a bookmark. The length after trimming leading and trailing whitespace cannot exceed 1024 characters.</para>
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
            /// <para>The path of the uploaded bookmark file. Cannot be specified together with a non-empty <c>Bookmarks</c>.</para>
            /// <para><b>File format:</b> A headerless CSV file with four columns in the following order:</para>
            /// <ol>
            /// <item><description>Bookmark name.</description></item>
            /// <item><description>URL.</description></item>
            /// <item><description>Folder.</description></item>
            /// <item><description>Root directory type: <c>bookmark_bar</c> indicates the bookmarks bar, and <c>other</c> indicates other bookmarks.</description></item>
            /// </ol>
            /// <para><b>Limits:</b></para>
            /// <list type="bullet">
            /// <item><description>Fields are separated by commas. Field values cannot contain commas or line breaks. Quote escaping is not supported.</description></item>
            /// <item><description>The file path must belong to the upload directory specified for the current account and cannot contain <c>..</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou/aig_upm/xxx/temp/BrowserBookmarks/浏览器书签模版.csv</para>
            /// </summary>
            [NameInMap("BookmarksFilePath")]
            [Validation(Required=false)]
            public string BookmarksFilePath { get; set; }

            /// <summary>
            /// <para>The browser startup parameters. For example, --incognito opens the browser in incognito mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--incognito</para>
            /// </summary>
            [NameInMap("BrowserParam")]
            [Validation(Required=false)]
            public string BrowserParam { get; set; }

            /// <summary>
            /// <para>Specifies whether to synchronize cookies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CookiesSync")]
            [Validation(Required=false)]
            public bool? CookiesSync { get; set; }

            /// <summary>
            /// <para>The homepage URL that opens when the browser starts. The value must conform to URI syntax.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }

        }

        /// <summary>
        /// <para>The resource billing mode.</para>
        /// <para><b>For MAU scenarios:</b> Set this parameter to <c>AppInstance</c> to bill by instance resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppInstance</para>
        /// </summary>
        [NameInMap("ChargeResourceMode")]
        [Validation(Required=false)]
        public string ChargeResourceMode { get; set; }

        /// <summary>
        /// <para>The billing type.</para>
        /// <para><b>For MAU scenarios:</b> Set this parameter to <c>PostPaid</c>, which indicates pay-as-you-go billing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The name of the cloud browser group. This parameter cannot be empty. The name is used to distinguish different browser groups in business management scenarios.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BusinessOfficeBrowser</para>
        /// </summary>
        [NameInMap("CloudBrowserName")]
        [Validation(Required=false)]
        public string CloudBrowserName { get; set; }

        /// <summary>
        /// <para>The image identifier used by the cloud browser. The image must be compatible with the operating system.</para>
        /// <para>If this parameter is omitted, the default image available for the account is used. If no default image is available, the creation may fail.</para>
        /// <para><b>Usage condition:</b> When <c>CookiesSync</c> is enabled, explicitly specify an image that supports cookie synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance type identifier. Select an instance type that matches the target region, operating system, and inventory conditions.</para>
        /// <para>If this parameter is omitted, the default instance type is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.general.basic</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The capacity configuration for the MAU billing scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxAmount")]
        [Validation(Required=false)]
        public int? MaxAmount { get; set; }

        /// <summary>
        /// <para>The office network and website access restriction configurations. The selected office network must belong to the current account and be located in the region specified by <c>BizRegionId</c>.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestNetwork Network { get; set; }
        public class CreateBrowserInstanceGroupRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The website access restriction mode.</para>
            /// <list type="bullet">
            /// <item><description><c>ALLOW_ALL</c>: Allows access to all domain names.</description></item>
            /// <item><description><c>ALLOW_LIST</c>: Allows access only to websites in the allowlist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALLOW_ALL</para>
            /// </summary>
            [NameInMap("AccessRestriction")]
            [Validation(Required=false)]
            public string AccessRestriction { get; set; }

            /// <summary>
            /// <para>The ID of the office network that has been created. The office network must belong to the current account and be located in the target region specified by BizRegionId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-643067****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The list of allowed websites. This parameter is used in <c>ALLOW_LIST</c> mode.</para>
            /// <para><b>Restrictions:</b></para>
            /// <list type="bullet">
            /// <item><description>A maximum of 20 URLs can be specified directly. If more than 20 URLs are required, use <c>RestrictedURLsFilePath</c> to import them from a file.</description></item>
            /// <item><description>This parameter cannot be specified together with <c>RestrictedURLsFilePath</c>.</description></item>
            /// <item><description>URLs in the list cannot be duplicated.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RestrictedURLs")]
            [Validation(Required=false)]
            public List<CreateBrowserInstanceGroupRequestNetworkRestrictedURLs> RestrictedURLs { get; set; }
            public class CreateBrowserInstanceGroupRequestNetworkRestrictedURLs : TeaModel {
                /// <summary>
                /// <para>The URL of the allowed website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun.com</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The path of the uploaded website allowlist file. This parameter is used in <c>ALLOW_LIST</c> mode.</para>
            /// <para>If more than 20 URLs are required, use file import. A maximum of 1,000 URLs can be configured by default.</para>
            /// <para>This parameter cannot be specified together with <c>RestrictedURLs</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou/aig_upm/xxx/temp/BrowserRestrictionUrls/URL白名单模版.csv</para>
            /// </summary>
            [NameInMap("RestrictedURLsFilePath")]
            [Validation(Required=false)]
            public string RestrictedURLsFilePath { get; set; }

            /// <summary>
            /// <para>The list of vSwitch IDs.</para>
            /// <para><b>Usage condition:</b> Specify this parameter only when you use a custom office network. Do not specify this parameter for other types of office networks.</para>
            /// <para>Select vSwitches that match the target business region and the custom office network.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The node pool configuration.</para>
        /// <para>You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestNodePool NodePool { get; set; }
        public class CreateBrowserInstanceGroupRequestNodePool : TeaModel {
            /// <summary>
            /// <para>The number of nodes.</para>
            /// <para>You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("NodeAmount")]
            [Validation(Required=false)]
            public int? NodeAmount { get; set; }

            /// <summary>
            /// <para>The node specifications identity.</para>
            /// <para>You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public string NodeInstanceType { get; set; }

            /// <summary>
            /// <para>The node scaling policy.</para>
            /// <para>You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("StrategyType")]
            [Validation(Required=false)]
            public string StrategyType { get; set; }

        }

        /// <summary>
        /// <para>The operating system type. This parameter is required.</para>
        /// <para>Only <c>Windows</c> is supported. Other operating systems are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The number of subscription periods.</para>
        /// <para>Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period.</para>
        /// <para>Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The clipboard, video, watermark, session, and client access policy configurations.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestPolicy Policy { get; set; }
        public class CreateBrowserInstanceGroupRequestPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable screen capture prevention.</para>
            /// <list type="bullet">
            /// <item><description><c>on</c>: Enables screen capture prevention.</description></item>
            /// <item><description><c>off</c>: Disables screen capture prevention.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// <para>The client access IP address whitelist. This parameter is used to restrict the source IP addresses of clients that can access the cloud browser.</para>
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<CreateBrowserInstanceGroupRequestPolicyAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class CreateBrowserInstanceGroupRequestPolicyAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// <para>The source CIDR block of clients that are allowed to access the cloud browser.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.0/24</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The description of the client access IP address whitelist rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OfficeNetworkAccess</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

            }

            /// <summary>
            /// <para>The client access control list.</para>
            /// </summary>
            [NameInMap("ClientTypes")]
            [Validation(Required=false)]
            public List<CreateBrowserInstanceGroupRequestPolicyClientTypes> ClientTypes { get; set; }
            public class CreateBrowserInstanceGroupRequestPolicyClientTypes : TeaModel {
                /// <summary>
                /// <para>The client type for which you want to configure an access policy.</para>
                /// <list type="bullet">
                /// <item><description><c>windows</c>: Windows client.</description></item>
                /// <item><description><c>macos</c>: macOS client.</description></item>
                /// <item><description><c>html5</c>: Web client.</description></item>
                /// <item><description><c>android</c>: Android client.</description></item>
                /// <item><description><c>ios</c>: iOS client.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>windows</para>
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                /// <summary>
                /// <para>The access policy switch for the client type.</para>
                /// <list type="bullet">
                /// <item><description><c>on</c>: Allows access from this client type.</description></item>
                /// <item><description><c>off</c>: Denies access from this client type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Specifies the clipboard transfer direction, content type, and size limit. read indicates transfer from the local PC to the cloud browser. write indicates transfer from the cloud browser to the local PC.</para>
            /// </summary>
            [NameInMap("ClipboardPolicy")]
            [Validation(Required=false)]
            public CreateBrowserInstanceGroupRequestPolicyClipboardPolicy ClipboardPolicy { get; set; }
            public class CreateBrowserInstanceGroupRequestPolicyClipboardPolicy : TeaModel {
                /// <summary>
                /// <para>The clipboard transfer direction. The value is case-insensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>off</c>: Bidirectional transfer is disabled.</description></item>
                /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                /// <item><description><c>readwrite</c>: Bidirectional transfer is allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>readwrite</para>
                /// </summary>
                [NameInMap("Clipboard")]
                [Validation(Required=false)]
                public string Clipboard { get; set; }

                /// <summary>
                /// <para>The clipboard size limit for inbound transfer (from the local PC to the cloud browser).</para>
                /// <para><b>Value range:</b> 1 to 102400. The unit is specified by ClipboardSizeUnit.</para>
                /// <para>The value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ClipboardReadLimit")]
                [Validation(Required=false)]
                public int? ClipboardReadLimit { get; set; }

                /// <summary>
                /// <para>The clipboard control granularity.</para>
                /// <list type="bullet">
                /// <item><description><c>global</c>: Unified control.</description></item>
                /// <item><description><c>grained</c>: Separate control by text, rich text, and file.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>grained</para>
                /// </summary>
                [NameInMap("ClipboardScope")]
                [Validation(Required=false)]
                public string ClipboardScope { get; set; }

                /// <summary>
                /// <para>The clipboard size unit.</para>
                /// <list type="bullet">
                /// <item><description><c>B</c>: Bytes.</description></item>
                /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("ClipboardSizeUnit")]
                [Validation(Required=false)]
                public string ClipboardSizeUnit { get; set; }

                /// <summary>
                /// <para>The clipboard size limit for outbound transfer (from the cloud browser to the local PC).</para>
                /// <para><b>Value range:</b> 1 to 102400. The unit is specified by ClipboardSizeUnit.</para>
                /// <para>The value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? ClipboardWriteLimit { get; set; }

                /// <summary>
                /// <para>The clipboard transfer direction. The value is case-insensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>off</c>: Bidirectional transfer is disabled.</description></item>
                /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                /// <item><description><c>readwrite</c>: Bidirectional transfer is allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("FileClipboard")]
                [Validation(Required=false)]
                public string FileClipboard { get; set; }

                /// <summary>
                /// <para>The clipboard transfer direction. The value is case-insensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>off</c>: Bidirectional transfer is disabled.</description></item>
                /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                /// <item><description><c>readwrite</c>: Bidirectional transfer is allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("RichTextClipboard")]
                [Validation(Required=false)]
                public string RichTextClipboard { get; set; }

                /// <summary>
                /// <para>The rich text clipboard size limit.</para>
                /// <para><b>Value range:</b> 1 to 204800. The unit is specified by RichTextClipboardSizeUnit.</para>
                /// <para>The value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("RichTextClipboardLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardLimit { get; set; }

                /// <summary>
                /// <para>The clipboard size limit for inbound transfer (from the local PC to the cloud browser).</para>
                /// <para><b>Value range:</b> 1 to 204800. The unit is specified by RichTextClipboardReadSizeUnit.</para>
                /// <para>The value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RichTextClipboardReadLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardReadLimit { get; set; }

                /// <summary>
                /// <para>The clipboard size unit.</para>
                /// <list type="bullet">
                /// <item><description><c>B</c>: Bytes.</description></item>
                /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                /// </list>
                /// <para><b>Default value:</b> <c>KB</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("RichTextClipboardReadSizeUnit")]
                [Validation(Required=false)]
                public string RichTextClipboardReadSizeUnit { get; set; }

                /// <summary>
                /// <para>The clipboard size unit.</para>
                /// <list type="bullet">
                /// <item><description><c>B</c>: Bytes.</description></item>
                /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("RichTextClipboardSizeUnit")]
                [Validation(Required=false)]
                public string RichTextClipboardSizeUnit { get; set; }

                /// <summary>
                /// <para>The clipboard size limit for outbound transfer (from the cloud browser to the local PC).</para>
                /// <para><b>Value range:</b> 1 to 204800. The unit is specified by RichTextClipboardWriteSizeUnit.</para>
                /// <para>The value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RichTextClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardWriteLimit { get; set; }

                /// <summary>
                /// <para>The clipboard size unit.</para>
                /// <list type="bullet">
                /// <item><description><c>B</c>: Bytes.</description></item>
                /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                /// </list>
                /// <para><b>Default value:</b> <c>KB</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("RichTextClipboardWriteSizeUnit")]
                [Validation(Required=false)]
                public string RichTextClipboardWriteSizeUnit { get; set; }

                /// <summary>
                /// <para>The clipboard transfer direction. The value is case-insensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>off</c>: Bidirectional transfer is disabled.</description></item>
                /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                /// <item><description><c>readwrite</c>: Bidirectional transfer is allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>readwrite</para>
                /// </summary>
                [NameInMap("TextClipboard")]
                [Validation(Required=false)]
                public string TextClipboard { get; set; }

                /// <summary>
                /// <para>The clipboard size limit for inbound transfer (from the local PC to the cloud browser).</para>
                /// <para><b>Value range:</b> 1 to 102400. The unit is specified by TextClipboardReadSizeUnit.</para>
                /// <para>The value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TextClipboardReadLimit")]
                [Validation(Required=false)]
                public int? TextClipboardReadLimit { get; set; }

                /// <summary>
                /// <para>The clipboard size unit.</para>
                /// <list type="bullet">
                /// <item><description><c>B</c>: Bytes.</description></item>
                /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                /// </list>
                /// <para><b>Default value:</b> <c>KB</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("TextClipboardReadSizeUnit")]
                [Validation(Required=false)]
                public string TextClipboardReadSizeUnit { get; set; }

                /// <summary>
                /// <para>The clipboard size limit for outbound transfer (from the cloud browser to the local PC).</para>
                /// <para><b>Value range:</b> 1 to 102400. The unit is specified by TextClipboardWriteSizeUnit.</para>
                /// <para>The value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TextClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? TextClipboardWriteLimit { get; set; }

                /// <summary>
                /// <para>The clipboard size unit.</para>
                /// <list type="bullet">
                /// <item><description><c>B</c>: Bytes.</description></item>
                /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                /// </list>
                /// <para><b>Default value:</b> <c>KB</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("TextClipboardWriteSizeUnit")]
                [Validation(Required=false)]
                public string TextClipboardWriteSizeUnit { get; set; }

            }

            /// <summary>
            /// <para>The session data retention policy after disconnection.</para>
            /// <list type="bullet">
            /// <item><description><c>customTime</c>: Retains the session based on the session data retention policy. Customizing the duration through <c>DisconnectKeepSessionTime</c> is not supported.</description></item>
            /// <item><description><c>persistent</c>: The session is not subject to automatic release based on disconnection duration.</description></item>
            /// </list>
            /// <para><b>Note:</b> <c>persistent</c> is still subject to authorization and other release policies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customTime</para>
            /// </summary>
            [NameInMap("DisconnectKeepSession")]
            [Validation(Required=false)]
            public string DisconnectKeepSession { get; set; }

            /// <summary>
            /// <para>Not supported. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DisconnectKeepSessionTime")]
            [Validation(Required=false)]
            public int? DisconnectKeepSessionTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the floating ball file manager.</para>
            /// <list type="bullet">
            /// <item><description><c>on</c>: Enabled.</description></item>
            /// <item><description><c>off</c>: Disabled.</description></item>
            /// </list>
            /// <para><b>Default value:</b> <c>off</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("FileManager")]
            [Validation(Required=false)]
            public string FileManager { get; set; }

            /// <summary>
            /// <para>The file transfer policy for the web client.</para>
            /// <list type="bullet">
            /// <item><description><c>off</c>: File transfer is disabled.</description></item>
            /// <item><description><c>upload</c>: Only upload is allowed.</description></item>
            /// <item><description><c>download</c>: Only download is allowed.</description></item>
            /// <item><description><c>full</c>: Both upload and download are allowed.</description></item>
            /// </list>
            /// <para>Configure this parameter together with the clipboard policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic disconnection on inactivity. The value is case-insensitive.</para>
            /// <list type="bullet">
            /// <item><description><c>on</c>: Enabled.</description></item>
            /// <item><description><c>off</c>: Disabled.</description></item>
            /// </list>
            /// <para>When enabled, set the wait duration through <c>NoOperationDisconnectTime</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("NoOperationDisconnect")]
            [Validation(Required=false)]
            public string NoOperationDisconnect { get; set; }

            /// <summary>
            /// <para>The wait duration before disconnection is triggered after user inactivity. Unit: seconds.</para>
            /// <para><b>Prerequisite:</b> When <c>NoOperationDisconnect</c> is enabled, specify a value greater than 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("NoOperationDisconnectTime")]
            [Validation(Required=false)]
            public int? NoOperationDisconnectTime { get; set; }

            /// <summary>
            /// <para>The policy version. The value is case-insensitive.</para>
            /// <list type="bullet">
            /// <item><description><c>DEFAULT</c>: Legacy policy.</description></item>
            /// <item><description><c>CENTER</c>: Centralized policy.</description></item>
            /// </list>
            /// <para><b>Default value:</b> <c>DEFAULT</c>. The actual effective policy version depends on the policy configuration available for the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CENTER</para>
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            /// <summary>
            /// <para>The video display policy for the browser session.</para>
            /// </summary>
            [NameInMap("VideoPolicy")]
            [Validation(Required=false)]
            public CreateBrowserInstanceGroupRequestPolicyVideoPolicy VideoPolicy { get; set; }
            public class CreateBrowserInstanceGroupRequestPolicyVideoPolicy : TeaModel {
                /// <summary>
                /// <para>The frame rate of the browser session.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("FrameRate")]
                [Validation(Required=false)]
                public int? FrameRate { get; set; }

            }

            /// <summary>
            /// <para>The watermark display configuration for browser sessions.</para>
            /// </summary>
            [NameInMap("WatermarkPolicy")]
            [Validation(Required=false)]
            public CreateBrowserInstanceGroupRequestPolicyWatermarkPolicy WatermarkPolicy { get; set; }
            public class CreateBrowserInstanceGroupRequestPolicyWatermarkPolicy : TeaModel {
                /// <summary>
                /// <para>The watermark switch. The value is case-insensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>ON</c>: Enables the watermark.</description></item>
                /// <item><description><c>OFF</c>: Disables the watermark.</description></item>
                /// </list>
                /// <para>When disabled, the watermark content type list is not used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ON</para>
                /// </summary>
                [NameInMap("WatermarkSwitch")]
                [Validation(Required=false)]
                public string WatermarkSwitch { get; set; }

                /// <summary>
                /// <para>The list of watermark content types.</para>
                /// <list type="bullet">
                /// <item><description><c>EndUserId</c>: The user identifier.</description></item>
                /// <item><description><c>InstanceGroupId</c>: The delivery group identifier.</description></item>
                /// <item><description><c>ClientTime</c>: The current time on the client.</description></item>
                /// </list>
                /// <para>Use watermark types supported by the browser and client.</para>
                /// </summary>
                [NameInMap("WatermarkTypes")]
                [Validation(Required=false)]
                public List<string> WatermarkTypes { get; set; }

            }

        }

        /// <summary>
        /// <para>The promotion ID. Specifies the promotional campaign to apply to the order.</para>
        /// <para>Whether the promotion is applicable depends on the campaign rules. Do not specify this parameter if no promotional campaign is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The connection security policy for the browser group.</para>
        /// </summary>
        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestSecurityPolicy SecurityPolicy { get; set; }
        public class CreateBrowserInstanceGroupRequestSecurityPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to skip the user authorization check when connecting to the application.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Skips the check.</description></item>
            /// <item><description><c>false</c>: Performs the check.</description></item>
            /// </list>
            /// <para>If this field is omitted when <c>SecurityPolicy</c> is configured, the user authorization check is performed.</para>
            /// <para><b>Note:</b> This field cannot be used to skip OpenAPI identity authentication or RAM permission verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// <para>The user data storage configuration for the browser group.</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestStoragePolicy StoragePolicy { get; set; }
        public class CreateBrowserInstanceGroupRequestStoragePolicy : TeaModel {
            /// <summary>
            /// <para>The user data roaming configuration, which is used to retain user configuration data.</para>
            /// </summary>
            [NameInMap("UserProfile")]
            [Validation(Required=false)]
            public CreateBrowserInstanceGroupRequestStoragePolicyUserProfile UserProfile { get; set; }
            public class CreateBrowserInstanceGroupRequestStoragePolicyUserProfile : TeaModel {
                /// <summary>
                /// <para>The size of the user data roaming cloud disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("UserProfileSize")]
                [Validation(Required=false)]
                public long? UserProfileSize { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable user data roaming.</para>
                /// <list type="bullet">
                /// <item><description><c>true</c>: Enabled.</description></item>
                /// <item><description><c>false</c>: Disabled.</description></item>
                /// </list>
                /// <para>In Windows scenarios, if this field is explicitly specified, the specified value is used. If this field is omitted, the user roaming configuration of the current account is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UserProfileSwitch")]
                [Validation(Required=false)]
                public bool? UserProfileSwitch { get; set; }

            }

        }

        /// <summary>
        /// <para>The billing subtype.</para>
        /// <para><b>Set this parameter to <c>mau</c> explicitly, which indicates billing by monthly active users.</b> Omitting this field does not enable MAU billing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mau</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>Not supported. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateBrowserInstanceGroupRequestTag> Tag { get; set; }
        public class CreateBrowserInstanceGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>Not supported. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Not supported. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Not supported. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Timers")]
        [Validation(Required=false)]
        public List<CreateBrowserInstanceGroupRequestTimers> Timers { get; set; }
        public class CreateBrowserInstanceGroupRequestTimers : TeaModel {
            /// <summary>
            /// <para>Not supported. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>Not supported. You do not need to specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("TimerType")]
            [Validation(Required=false)]
            public string TimerType { get; set; }

        }

        /// <summary>
        /// <para>The list of authorized user group identifiers. A maximum of 10 items are supported. The user groups must belong to the current account and match the workspace network account type.</para>
        /// <para><b>Limit:</b> Cannot be specified together with a non-empty <c>Users</c>.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The authorized user account information. The value must match the user and workspace network type.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestUserInfo UserInfo { get; set; }
        public class CreateBrowserInstanceGroupRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The account type of the authorized user.</para>
            /// <list type="bullet">
            /// <item><description><c>simple</c>: Convenience account.</description></item>
            /// <item><description><c>ad</c>: AD domain account.</description></item>
            /// </list>
            /// <para>The value must match the account type of the user and workspace network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of authorized users. A maximum of 200 users can be specified. Users must be created in advance and must match the account type.</para>
        /// <para><b>Restriction:</b> This parameter cannot be specified together with a non-empty <c>UserGroupIds</c>.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<CreateBrowserInstanceGroupRequestUsers> Users { get; set; }
        public class CreateBrowserInstanceGroupRequestUsers : TeaModel {
            /// <summary>
            /// <para>The identity of the authorized user to be granted authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

        }

    }

}
