// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateBrowserInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The package identifier.</para>
        /// <para>You do not need to specify this parameter.</para>
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
        /// <para>Specifies whether to send notification emails for authorization and deauthorization.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Sends notification emails.</description></item>
        /// <item><description><c>false</c>: Does not send notification emails.</description></item>
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
        /// <para>You do not need to specify this parameter.</para>
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
        /// <para>You do not need to specify this parameter.</para>
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
        /// <para>The identifier of the business region. This parameter is required.</para>
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
            /// <para>The list of browser bookmarks.
            /// <b>Limits:</b> This parameter cannot be specified together with a non-empty BookmarksFilePath parameter, and bookmark URLs cannot be duplicated.</para>
            /// </summary>
            [NameInMap("Bookmarks")]
            [Validation(Required=false)]
            public List<CreateBrowserInstanceGroupRequestBrowserConfigBookmarks> Bookmarks { get; set; }
            public class CreateBrowserInstanceGroupRequestBrowserConfigBookmarks : TeaModel {
                /// <summary>
                /// <para>The folder where the bookmark is located. The length cannot exceed 64 characters after leading and trailing spaces are removed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Work portal</para>
                /// </summary>
                [NameInMap("BookmarkFolder")]
                [Validation(Required=false)]
                public string BookmarkFolder { get; set; }

                /// <summary>
                /// <para>The bookmark name. This parameter is required and cannot be empty when you create a bookmark. The length cannot exceed 64 characters after leading and trailing spaces are removed.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud website</para>
                /// </summary>
                [NameInMap("BookmarkName")]
                [Validation(Required=false)]
                public string BookmarkName { get; set; }

                /// <summary>
                /// <para>The URL of the bookmark. This parameter is required when you create a bookmark. The length cannot exceed 1024 characters after leading and trailing spaces are removed.</para>
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
            /// <para>The path of the uploaded bookmark file. This parameter cannot be specified together with a non-empty Bookmarks parameter.
            /// <b>File format:</b> A CSV file without a header. Specify the following four columns in order:</para>
            /// <ol>
            /// <item><description>Bookmark name.</description></item>
            /// <item><description>URL.</description></item>
            /// <item><description>Folder.</description></item>
            /// <item><description>Root directory type: <c>bookmark_bar</c> indicates the bookmarks bar, and <c>other</c> indicates other bookmarks.
            /// <b>Limits:</b></description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Fields are separated by commas. Field content cannot contain commas or line breaks, and quote escaping is not supported.</description></item>
            /// <item><description>The file path must belong to the upload directory specified for the current account and cannot contain <c>..</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou/aig_upm/xxx/temp/BrowserBookmarks/BrowserBookmarkTemplate.csv</para>
            /// </summary>
            [NameInMap("BookmarksFilePath")]
            [Validation(Required=false)]
            public string BookmarksFilePath { get; set; }

            /// <summary>
            /// <para>The browser startup parameters. For example, --incognito indicates that an incognito window is used.</para>
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
            /// <para>The homepage URL opened when the browser starts. The URL must conform to the URI syntax.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }

        }

        /// <summary>
        /// <para>The resource billing method.
        /// <b>For MAU scenarios:</b> Set this parameter to <c>AppInstance</c>, which indicates billing by instance resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppInstance</para>
        /// </summary>
        [NameInMap("ChargeResourceMode")]
        [Validation(Required=false)]
        public string ChargeResourceMode { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para><b>For MAU scenarios:</b> Set this parameter to PostPaid, which indicates pay-as-you-go.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The name of the cloud browser group. This parameter cannot be empty. It is used to distinguish different browser groups in business management scenarios.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business office browser</para>
        /// </summary>
        [NameInMap("CloudBrowserName")]
        [Validation(Required=false)]
        public string CloudBrowserName { get; set; }

        /// <summary>
        /// <para>The image ID used by the cloud browser. The image must be compatible with the operating system.
        /// If this parameter is omitted, the default image available for the account is used. If no default image is available, the creation may fail.
        /// <b>Usage conditions:</b> When CookiesSync is enabled, explicitly specify an image that supports cookie synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The instance type identifier. Select an instance type that matches the target region, operating system, and inventory conditions.
        /// If this parameter is omitted, the default instance type is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstreaming.general.basic</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The capacity configuration in MAU billing scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxAmount")]
        [Validation(Required=false)]
        public int? MaxAmount { get; set; }

        /// <summary>
        /// <para>The configurations for the office network and website access restrictions. The selected office network must belong to the current account and reside in the region specified by BizRegionId.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestNetwork Network { get; set; }
        public class CreateBrowserInstanceGroupRequestNetwork : TeaModel {
            /// <summary>
            /// <para>The website access restriction mode.</para>
            /// <list type="bullet">
            /// <item><description>ALLOW_ALL: Allows access to all domain names.</description></item>
            /// <item><description>ALLOW_LIST: Allows access only to websites in the whitelist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALLOW_ALL</para>
            /// </summary>
            [NameInMap("AccessRestriction")]
            [Validation(Required=false)]
            public string AccessRestriction { get; set; }

            /// <summary>
            /// <para>The identifier of the created office network. The office network must belong to the current account and reside in the target region specified by BizRegionId. You can view the office network ID on the Network &amp; Storage &gt; Office Networks page in the Elastic Desktop Service Enterprise Edition console, or call the DescribeOfficeSites operation of Elastic Desktop Service Enterprise Edition to query the ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-643067****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The list of websites that are allowed for access. This parameter is used in ALLOW_LIST mode.</para>
            /// <para><b>Limits:</b></para>
            /// <list type="bullet">
            /// <item><description>You can specify up to 20 URLs directly. To specify more than 20 URLs, use RestrictedURLsFilePath to import them from a file.</description></item>
            /// <item><description>This parameter cannot be specified together with RestrictedURLsFilePath.</description></item>
            /// <item><description>The URLs in the list cannot be duplicated.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("RestrictedURLs")]
            [Validation(Required=false)]
            public List<CreateBrowserInstanceGroupRequestNetworkRestrictedURLs> RestrictedURLs { get; set; }
            public class CreateBrowserInstanceGroupRequestNetworkRestrictedURLs : TeaModel {
                /// <summary>
                /// <para>The URL of the website that is allowed for access.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun.com</para>
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// <para>The path of the uploaded website whitelist file. This parameter is used in ALLOW_LIST mode.</para>
            /// <para>If you need to specify more than 20 URLs, import them from a file. By default, you can configure up to 1,000 URLs.</para>
            /// <para>This parameter cannot be specified together with RestrictedURLs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou/aig_upm/xxx/temp/BrowserRestrictionUrls/URL_whitelist_template.csv</para>
            /// </summary>
            [NameInMap("RestrictedURLsFilePath")]
            [Validation(Required=false)]
            public string RestrictedURLsFilePath { get; set; }

            /// <summary>
            /// <para>The list of vSwitch identifiers.</para>
            /// <para><b>Usage condition:</b> This parameter is required only when you use a custom office network. Do not specify this parameter for other types of office networks.</para>
            /// <para>Select vSwitches that match the target business region and the custom office network.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The node pool configuration.
        /// You do not need to specify this parameter.</para>
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
            /// <para>The number of nodes.
            /// You do not need to specify this parameter.</para>
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
            /// <para>The identity of the node specifications.</para>
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
            /// <para>The node scaling policy.
            /// You do not need to specify this parameter.</para>
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
        /// <para>The operating system type. This parameter is required.
        /// Only <c>Windows</c> is supported. Other operating systems are not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The number of billing cycles for the purchase.</para>
        /// <para>You do not need to specify this parameter.</para>
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
        /// <para>The unit of the billing cycle for the purchase.</para>
        /// <para>You do not need to specify this parameter.</para>
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
        /// <para>Configures policies for the clipboard, video, watermark, session, and client access.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestPolicy Policy { get; set; }
        public class CreateBrowserInstanceGroupRequestPolicy : TeaModel {
            /// <summary>
            /// <para>The screen capture prevention switch.</para>
            /// <list type="bullet">
            /// <item><description>on: Enables screen capture prevention.</description></item>
            /// <item><description>off: Disables screen capture prevention.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AppContentProtection")]
            [Validation(Required=false)]
            public string AppContentProtection { get; set; }

            /// <summary>
            /// <para>The client access IP address whitelist, which is used to restrict the source IP addresses of clients that can access the cloud browser.</para>
            /// </summary>
            [NameInMap("AuthorizeAccessPolicyRules")]
            [Validation(Required=false)]
            public List<CreateBrowserInstanceGroupRequestPolicyAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
            public class CreateBrowserInstanceGroupRequestPolicyAuthorizeAccessPolicyRules : TeaModel {
                /// <summary>
                /// <para>The source CIDR block of the client that is allowed to access the cloud browser. Use the CIDR format.</para>
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
                /// <para>Office network access</para>
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
                /// <para>The type of the client for which you want to configure an access policy.</para>
                /// <list type="bullet">
                /// <item><description>windows: Windows client.</description></item>
                /// <item><description>macos: macOS client.</description></item>
                /// <item><description>html5: Web client.</description></item>
                /// <item><description>android: Android client.</description></item>
                /// <item><description>ios: iOS client.</description></item>
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
                /// <item><description>on: Allows access from this type of client.</description></item>
                /// <item><description>off: Denies access from this type of client.</description></item>
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
            /// <para>Specifies the clipboard transfer direction, content types, and size limits. read indicates transfer from the local PC to the cloud browser, and write indicates transfer from the cloud browser to the local PC.</para>
            /// </summary>
            [NameInMap("ClipboardPolicy")]
            [Validation(Required=false)]
            public CreateBrowserInstanceGroupRequestPolicyClipboardPolicy ClipboardPolicy { get; set; }
            public class CreateBrowserInstanceGroupRequestPolicyClipboardPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies the clipboard transfer direction. The value is not case-sensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>off</c>: Prohibits bidirectional transfer.</description></item>
                /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                /// <item><description><c>readwrite</c>: Allows bidirectional copy and paste.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>readwrite</para>
                /// </summary>
                [NameInMap("Clipboard")]
                [Validation(Required=false)]
                public string Clipboard { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size limit for inbound transfer (from the local PC to the cloud browser).</para>
                /// <para><b>Value range:</b> 1 to 102400. The unit is specified by ClipboardSizeUnit.</para>
                /// <para>This value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ClipboardReadLimit")]
                [Validation(Required=false)]
                public int? ClipboardReadLimit { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard control granularity.</para>
                /// <list type="bullet">
                /// <item><description><c>global</c>: Unified control.</description></item>
                /// <item><description><c>grained</c>: Separate control for text, rich text, and files.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>grained</para>
                /// </summary>
                [NameInMap("ClipboardScope")]
                [Validation(Required=false)]
                public string ClipboardScope { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size unit.</para>
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
                /// <para>Specifies the clipboard size limit for outbound transfer (from the cloud browser to the local PC).</para>
                /// <para><b>Value range:</b> 1 to 102400. The unit is specified by ClipboardSizeUnit.</para>
                /// <para>This value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("ClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? ClipboardWriteLimit { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard transfer direction. The value is not case-sensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>off</c>: Prohibits bidirectional transfer.</description></item>
                /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                /// <item><description><c>readwrite</c>: Allows bidirectional copy and paste.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("FileClipboard")]
                [Validation(Required=false)]
                public string FileClipboard { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard transfer direction. The value is not case-sensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>off</c>: Prohibits bidirectional transfer.</description></item>
                /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                /// <item><description><c>readwrite</c>: Allows bidirectional copy and paste.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("RichTextClipboard")]
                [Validation(Required=false)]
                public string RichTextClipboard { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size limit for rich text.</para>
                /// <para><b>Value range:</b> 1 to 204800. The unit is specified by RichTextClipboardSizeUnit.</para>
                /// <para>This value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("RichTextClipboardLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardLimit { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size limit for inbound transfer (from the local PC to the cloud browser).</para>
                /// <para><b>Value range:</b> 1 to 204800. The unit is specified by RichTextClipboardReadSizeUnit.</para>
                /// <para>This value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RichTextClipboardReadLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardReadLimit { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size unit.</para>
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
                /// <para>Specifies the clipboard size unit.</para>
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
                /// <para>Specifies the clipboard size limit for outbound transfer (from the cloud browser to the local PC).</para>
                /// <para><b>Value range:</b> 1 to 204800. The unit is specified by RichTextClipboardWriteSizeUnit.</para>
                /// <para>This value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RichTextClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? RichTextClipboardWriteLimit { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size unit.</para>
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
                /// <para>Specifies the clipboard transfer direction. The value is not case-sensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>off</c>: Prohibits bidirectional transfer.</description></item>
                /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                /// <item><description><c>readwrite</c>: Allows bidirectional copy and paste.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>readwrite</para>
                /// </summary>
                [NameInMap("TextClipboard")]
                [Validation(Required=false)]
                public string TextClipboard { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size limit for inbound transfer (from the local PC to the cloud browser).</para>
                /// <para><b>Value range:</b> 1 to 102400. The unit is specified by TextClipboardReadSizeUnit.</para>
                /// <para>This value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TextClipboardReadLimit")]
                [Validation(Required=false)]
                public int? TextClipboardReadLimit { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size unit.</para>
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
                /// <para>Specifies the clipboard size limit for outbound transfer (from the cloud browser to the local PC).</para>
                /// <para><b>Value range:</b> 1 to 102400. The unit is specified by TextClipboardWriteSizeUnit.</para>
                /// <para>This value range does not change with unit conversion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TextClipboardWriteLimit")]
                [Validation(Required=false)]
                public int? TextClipboardWriteLimit { get; set; }

                /// <summary>
                /// <para>Specifies the clipboard size unit.</para>
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
            /// <para>Specifies the data retention policy for sessions after disconnection.</para>
            /// <list type="bullet">
            /// <item><description><c>customTime</c>: Retains the session according to the data retention policy. Custom duration through <c>DisconnectKeepSessionTime</c> is not supported.</description></item>
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
            /// <para>This parameter is not supported and does not need to be specified.</para>
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
            /// <para>Specifies whether to enable the file manager floating button.</para>
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
            /// <para>Specifies the file transfer policy for the web client.</para>
            /// <list type="bullet">
            /// <item><description><c>off</c>: Prohibits file transfer.</description></item>
            /// <item><description><c>upload</c>: Allows upload only.</description></item>
            /// <item><description><c>download</c>: Allows download only.</description></item>
            /// <item><description><c>full</c>: Allows both upload and download.</description></item>
            /// </list>
            /// <para>Configure this parameter in conjunction with the clipboard policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>full</para>
            /// </summary>
            [NameInMap("Html5FileTransfer")]
            [Validation(Required=false)]
            public string Html5FileTransfer { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the dual-screen mode for the cloud browser.</para>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("MultiScreen")]
            [Validation(Required=false)]
            public string MultiScreen { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic disconnection on inactivity. The value is not case-sensitive.</para>
            /// <list type="bullet">
            /// <item><description><c>on</c>: Enabled.</description></item>
            /// <item><description><c>off</c>: Disabled.</description></item>
            /// </list>
            /// <para>When enabled, use <c>NoOperationDisconnectTime</c> to set the idle timeout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("NoOperationDisconnect")]
            [Validation(Required=false)]
            public string NoOperationDisconnect { get; set; }

            /// <summary>
            /// <para>Specifies the idle timeout in seconds before automatic disconnection is triggered.</para>
            /// <para><b>Prerequisite:</b> When <c>NoOperationDisconnect</c> is enabled, you must specify a value greater than 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("NoOperationDisconnectTime")]
            [Validation(Required=false)]
            public int? NoOperationDisconnectTime { get; set; }

            /// <summary>
            /// <para>Specifies the policy version. The value is not case-sensitive.</para>
            /// <list type="bullet">
            /// <item><description><c>DEFAULT</c>: Legacy policy.</description></item>
            /// <item><description><c>CENTER</c>: Centralized policy.</description></item>
            /// </list>
            /// <para><b>Default value:</b> <c>DEFAULT</c>. The effective policy version is subject to the policy configuration available for the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CENTER</para>
            /// </summary>
            [NameInMap("PolicyVersion")]
            [Validation(Required=false)]
            public string PolicyVersion { get; set; }

            /// <summary>
            /// <para>Specifies the video display policy for the browser session.</para>
            /// </summary>
            [NameInMap("VideoPolicy")]
            [Validation(Required=false)]
            public CreateBrowserInstanceGroupRequestPolicyVideoPolicy VideoPolicy { get; set; }
            public class CreateBrowserInstanceGroupRequestPolicyVideoPolicy : TeaModel {
                /// <summary>
                /// <para>Specifies the frame rate for the browser session.</para>
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
                /// <item><description><c>OFF</c>: Disables the watermark.
                /// The watermark content type list is not used when the watermark is disabled.</description></item>
                /// </list>
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
                /// <item><description><c>ClientTime</c>: The current time of the client.
                /// Use the watermark types supported by the browser and the client.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("WatermarkTypes")]
                [Validation(Required=false)]
                public List<string> WatermarkTypes { get; set; }

            }

        }

        /// <summary>
        /// <para>The promotion identifier, which is used to specify the promotional offer applied to the order.</para>
        /// <para>Applicability and specific discounts are subject to the promotion rules. You do not need to specify this parameter if no promotional offer is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The connection security policy of the browser group.</para>
        /// </summary>
        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestSecurityPolicy SecurityPolicy { get; set; }
        public class CreateBrowserInstanceGroupRequestSecurityPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether to skip the user authorization check when connecting to the application.</para>
            /// <list type="bullet">
            /// <item><description><c>true</c>: Skips the check.</description></item>
            /// <item><description><c>false</c>: Performs the check.
            /// If SecurityPolicy is configured but this field is omitted, the user authorization check is performed.
            /// <b>Note:</b> This field cannot be used to skip OpenAPI authentication and RAM permission verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipUserAuthCheck")]
            [Validation(Required=false)]
            public bool? SkipUserAuthCheck { get; set; }

        }

        /// <summary>
        /// <para>The user data storage configuration of the browser group.</para>
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
                /// <para>The size of the user data roaming disk, in GB.</para>
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
                /// <item><description><c>true</c>: Enables user data roaming.</description></item>
                /// <item><description><c>false</c>: Disables user data roaming.
                /// In Windows scenarios, if this parameter is explicitly specified, the specified value is used. If this parameter is omitted, the user roaming configuration of the current account is used.</description></item>
                /// </list>
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
        /// <para>The billing sub-type.</para>
        /// <para><b>You must explicitly set this parameter to mau, which indicates billing by monthly active users (MAUs).</b> Omitting this parameter does not enable MAU billing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mau</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>This parameter is not supported and does not need to be specified.</para>
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
            /// <para>This parameter is not supported and does not need to be specified.</para>
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
            /// <para>This parameter is not supported and does not need to be specified.</para>
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
        /// <para>This parameter is not supported and does not need to be specified.</para>
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
            /// <para>This parameter is not supported and does not need to be specified.</para>
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
            /// <para>This parameter is not supported and does not need to be specified.</para>
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
        /// <para>The list of authorized user group IDs. You can specify up to 10 IDs. The user groups must belong to the current account and match the account type of the office network.
        /// <b>Limits:</b> This parameter cannot be specified together with a non-empty Users parameter.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The authorized user account information. The information must match the user and office network types.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateBrowserInstanceGroupRequestUserInfo UserInfo { get; set; }
        public class CreateBrowserInstanceGroupRequestUserInfo : TeaModel {
            /// <summary>
            /// <para>The account type of the authorized user.</para>
            /// <list type="bullet">
            /// <item><description><c>simple</c>: Convenience account.</description></item>
            /// <item><description><c>ad</c>: AD domain account.
            /// The account type must match the account types of the user and the office network.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>simple</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of authorized users. You can specify up to 200 users. The users must be created in advance and match the account type.</para>
        /// <para><b>Limit:</b> This parameter cannot be specified together with a non-empty UserGroupIds parameter.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<CreateBrowserInstanceGroupRequestUsers> Users { get; set; }
        public class CreateBrowserInstanceGroupRequestUsers : TeaModel {
            /// <summary>
            /// <para>The identity of the authorized user for authorization.</para>
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
