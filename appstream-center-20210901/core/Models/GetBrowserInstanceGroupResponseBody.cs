// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetBrowserInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the browser group.</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupModel")]
        [Validation(Required=false)]
        public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModel BrowserInstanceGroupModel { get; set; }
        public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModel : TeaModel {
            /// <summary>
            /// <para>Indicates whether authorization and deauthorization notification emails are enabled. <c>true</c> indicates that the feature is enabled. <c>false</c> indicates that the feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthNotificationEnabled")]
            [Validation(Required=false)]
            public bool? AuthNotificationEnabled { get; set; }

            /// <summary>
            /// <para>The statistics of authorized users for the browser group.</para>
            /// </summary>
            [NameInMap("AuthorizedUserInfo")]
            [Validation(Required=false)]
            public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelAuthorizedUserInfo AuthorizedUserInfo { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelAuthorizedUserInfo : TeaModel {
                /// <summary>
                /// <para>The total number of authorized users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                /// <summary>
                /// <para>The total number of authorized user groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalUserGroupCount")]
                [Validation(Required=false)]
                public int? TotalUserGroupCount { get; set; }

            }

            /// <summary>
            /// <para>The business region where the browser group resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("BizRegionId")]
            [Validation(Required=false)]
            public string BizRegionId { get; set; }

            /// <summary>
            /// <para>The current browser configuration.</para>
            /// </summary>
            [NameInMap("BrowserConfig")]
            [Validation(Required=false)]
            public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelBrowserConfig BrowserConfig { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelBrowserConfig : TeaModel {
                /// <summary>
                /// <para>The list of browser bookmarks. A maximum of 20 entries are returned. To query the complete bookmark list, call <c>ListBrowserBookmarks</c>.</para>
                /// </summary>
                [NameInMap("Bookmarks")]
                [Validation(Required=false)]
                public List<GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelBrowserConfigBookmarks> Bookmarks { get; set; }
                public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelBrowserConfigBookmarks : TeaModel {
                    /// <summary>
                    /// <para>The folder in which the bookmark resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Work Portal</para>
                    /// </summary>
                    [NameInMap("BookmarkFolder")]
                    [Validation(Required=false)]
                    public string BookmarkFolder { get; set; }

                    /// <summary>
                    /// <para>The bookmark ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bm-12345</para>
                    /// </summary>
                    [NameInMap("BookmarkId")]
                    [Validation(Required=false)]
                    public string BookmarkId { get; set; }

                    /// <summary>
                    /// <para>The bookmark name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alibaba Cloud Official Website</para>
                    /// </summary>
                    [NameInMap("BookmarkName")]
                    [Validation(Required=false)]
                    public string BookmarkName { get; set; }

                    /// <summary>
                    /// <para>The URL of the bookmark.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("BookmarkURL")]
                    [Validation(Required=false)]
                    public string BookmarkURL { get; set; }

                }

                /// <summary>
                /// <para>The browser startup parameters. For example, <c>--incognito</c> specifies the incognito window mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>--incognito</para>
                /// </summary>
                [NameInMap("BrowserParam")]
                [Validation(Required=false)]
                public string BrowserParam { get; set; }

                /// <summary>
                /// <para>The cookie synchronization configuration. The string <c>true</c> indicates that synchronization is enabled. The string <c>false</c> indicates that synchronization is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CookiesSync")]
                [Validation(Required=false)]
                public string CookiesSync { get; set; }

                /// <summary>
                /// <para>The homepage URL that opens when the browser starts.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("Homepage")]
                [Validation(Required=false)]
                public string Homepage { get; set; }

            }

            /// <summary>
            /// <para>The cloud browser group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>big-0c7loey7fzjq****</para>
            /// </summary>
            [NameInMap("BrowserInstanceGroupId")]
            [Validation(Required=false)]
            public string BrowserInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The cloud browser group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office Browser</para>
            /// </summary>
            [NameInMap("BrowserInstanceGroupName")]
            [Validation(Required=false)]
            public string BrowserInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the browser group set to which the browser group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>set-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("BrowserInstanceGroupSetId")]
            [Validation(Required=false)]
            public string BrowserInstanceGroupSetId { get; set; }

            /// <summary>
            /// <para>The billing type. In MAU scenarios, <c>PostPaid</c> is returned, which indicates the pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The default access URL of the browser group. Use the URL returned by the API to access the browser group. Replace the resource ID in the example with your actual value.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://wuying.aliyun.com/integration?appId=browser&appInstanceGroupId=big-0c7loey7fzjq">https://wuying.aliyun.com/integration?appId=browser&amp;appInstanceGroupId=big-0c7loey7fzjq</a>****</para>
            /// </summary>
            [NameInMap("DefaultAccessUrl")]
            [Validation(Required=false)]
            public string DefaultAccessUrl { get; set; }

            /// <summary>
            /// <para>The plan duration information. In MAU scenarios, plan duration does not apply, and an empty object may be returned.</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelDuration Duration { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelDuration : TeaModel {
                /// <summary>
                /// <para>The current payment stage of the plan. This field does not apply to MAU scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("CurrentPayStage")]
                [Validation(Required=false)]
                public string CurrentPayStage { get; set; }

                /// <summary>
                /// <para>The end time of the plan period. This field does not apply to MAU scenarios and is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("PeriodEndTime")]
                [Validation(Required=false)]
                public string PeriodEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the plan period. This field does not apply to MAU scenarios and is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("PeriodStartTime")]
                [Validation(Required=false)]
                public string PeriodStartTime { get; set; }

                /// <summary>
                /// <para>The total duration of the plan, in seconds. This field does not apply to MAU scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public int? TotalDuration { get; set; }

                /// <summary>
                /// <para>The used duration of the plan, in seconds. This field does not apply to MAU scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("UsedDuration")]
                [Validation(Required=false)]
                public int? UsedDuration { get; set; }

            }

            /// <summary>
            /// <para>The expiration time of the browser group. This field does not apply to MAU scenarios and is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <para>The creation time of the browser group. The value is an RFC 3339 time string in the <c>yyyy-MM-ddTHH:mm:ss.SSSXXX</c> format, which includes milliseconds and a time zone offset. The <c>+00:00</c> in the example indicates the UTC time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-21T07:00:39.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The homepage URL of the browser group.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }

            /// <summary>
            /// <para>The image ID used by the browser group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-070qhs8oeju4****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance type used by the browser group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.general.basic</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum number of instances configured for the MAU scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxAmount")]
            [Validation(Required=false)]
            public int? MaxAmount { get; set; }

            /// <summary>
            /// <para>The office network and website access restriction configuration.</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelNetwork Network { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelNetwork : TeaModel {
                /// <summary>
                /// <para>The website access restriction mode.</para>
                /// <list type="bullet">
                /// <item><description><c>ALLOW_ALL</c>: All domain names are allowed.</description></item>
                /// <item><description><c>ALLOW_LIST</c>: Only websites in the allowlist are allowed.</description></item>
                /// </list>
                /// <para>The returned value reflects the current configuration of the browser group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALLOW_ALL</para>
                /// </summary>
                [NameInMap("AccessRestriction")]
                [Validation(Required=false)]
                public string AccessRestriction { get; set; }

                /// <summary>
                /// <para>The office network ID to which the browser group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+dir-843734****</para>
                /// </summary>
                [NameInMap("OfficeSiteId")]
                [Validation(Required=false)]
                public string OfficeSiteId { get; set; }

                /// <summary>
                /// <para>The website access restriction list. A maximum of 20 entries are returned. To query the complete list, call <c>ListBrowserRestrictedURLs</c>.</para>
                /// </summary>
                [NameInMap("RestrictedURLs")]
                [Validation(Required=false)]
                public List<GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelNetworkRestrictedURLs> RestrictedURLs { get; set; }
                public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelNetworkRestrictedURLs : TeaModel {
                    /// <summary>
                    /// <para>The ID of the website access restriction entry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ru-12345</para>
                    /// </summary>
                    [NameInMap("RestrictedURLId")]
                    [Validation(Required=false)]
                    public string RestrictedURLId { get; set; }

                    /// <summary>
                    /// <para>The website URL in the access restriction entry.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.com</para>
                    /// </summary>
                    [NameInMap("URL")]
                    [Validation(Required=false)]
                    public string URL { get; set; }

                }

                /// <summary>
                /// <para>The list of vSwitch IDs used by the browser group. This is available for scenarios with custom network configurations.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

            }

            /// <summary>
            /// <para>The node specifications information. This field does not apply to MAU scenarios.</para>
            /// </summary>
            [NameInMap("NodeInstanceType")]
            [Validation(Required=false)]
            public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelNodeInstanceType NodeInstanceType { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelNodeInstanceType : TeaModel {
                /// <summary>
                /// <para>The CPU configuration of the node. This field does not apply to MAU scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <para>The memory configuration of the node. This field does not apply to MAU scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

            }

            /// <summary>
            /// <para>The list of node pool information. In MAU scenarios, this field does not apply and an empty list may be returned.</para>
            /// </summary>
            [NameInMap("NodePool")]
            [Validation(Required=false)]
            public List<GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelNodePool> NodePool { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelNodePool : TeaModel {
                /// <summary>
                /// <para>The total number of nodes. This field does not apply to MAU scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("NodeAmount")]
                [Validation(Required=false)]
                public string NodeAmount { get; set; }

                /// <summary>
                /// <para>The number of used nodes. This field does not apply to MAU scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("NodeUsed")]
                [Validation(Required=false)]
                public string NodeUsed { get; set; }

            }

            /// <summary>
            /// <para>The operating system type of the browser group. The current MAU product scenario uses Windows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The policy configuration returned for the browser group. The policy fields are used to view existing settings and do not indicate that all corresponding creation parameters are configurable.</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicy Policy { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicy : TeaModel {
                /// <summary>
                /// <para>The screenshot protection switch.</para>
                /// <list type="bullet">
                /// <item><description><c>on</c>: Screenshot protection is enabled.</description></item>
                /// <item><description><c>off</c>: Screenshot protection is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AppContentProtection")]
                [Validation(Required=false)]
                public string AppContentProtection { get; set; }

                /// <summary>
                /// <para>The client access IP address whitelist rules.</para>
                /// </summary>
                [NameInMap("AuthorizeAccessPolicyRules")]
                [Validation(Required=false)]
                public List<GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
                public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyAuthorizeAccessPolicyRules : TeaModel {
                    /// <summary>
                    /// <para>The client source CIDR block that is allowed to access the browser group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.1.0/24</para>
                    /// </summary>
                    [NameInMap("CidrIp")]
                    [Validation(Required=false)]
                    public string CidrIp { get; set; }

                    /// <summary>
                    /// <para>The description of the client access rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Office network access</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The action of the client access rule.</para>
                    /// <list type="bullet">
                    /// <item><description><c>allow</c>: Access is allowed.</description></item>
                    /// <item><description><c>deny</c>: Access is denied.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>allow</para>
                    /// </summary>
                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                }

                /// <summary>
                /// <para>The list of client access control configurations.</para>
                /// </summary>
                [NameInMap("ClientTypes")]
                [Validation(Required=false)]
                public List<GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyClientTypes> ClientTypes { get; set; }
                public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyClientTypes : TeaModel {
                    /// <summary>
                    /// <para>The client type.</para>
                    /// <list type="bullet">
                    /// <item><description><c>windows</c>: Windows client.</description></item>
                    /// <item><description><c>macos</c>: macOS client.</description></item>
                    /// <item><description><c>html5</c>: Web client.</description></item>
                    /// <item><description><c>linux</c>: Linux client.</description></item>
                    /// <item><description><c>android</c>: Android client.</description></item>
                    /// <item><description><c>ios</c>: iOS client.</description></item>
                    /// </list>
                    /// <para>This field reflects the existing access configuration and does not indicate that all client types are available for the current product.</para>
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
                    /// <item><description><c>on</c>: Access from this client type is allowed.</description></item>
                    /// <item><description><c>off</c>: Access from this client type is denied.</description></item>
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
                /// <para>The clipboard transfer direction, content type, and size limit settings. read indicates transfer from the local PC to the cloud browser. write indicates transfer from the cloud browser to the local PC.</para>
                /// </summary>
                [NameInMap("ClipboardPolicy")]
                [Validation(Required=false)]
                public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyClipboardPolicy ClipboardPolicy { get; set; }
                public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyClipboardPolicy : TeaModel {
                    /// <summary>
                    /// <para>The clipboard transfer direction. The value is case-insensitive.</para>
                    /// <list type="bullet">
                    /// <item><description><c>off</c>: Bidirectional transfer is denied.</description></item>
                    /// <item><description><c>read</c>: Copy and paste from the local PC to the cloud browser is allowed.</description></item>
                    /// <item><description><c>write</c>: Copy and paste from the cloud browser to the local PC is allowed.</description></item>
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
                    /// <para>The unit of the clipboard size.</para>
                    /// <list type="bullet">
                    /// <item><description><c>B</c>: bytes.</description></item>
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
                    /// <item><description><c>off</c>: Bidirectional transfer is denied.</description></item>
                    /// <item><description><c>read</c>: Copy and paste from the local PC to the cloud browser is allowed.</description></item>
                    /// <item><description><c>write</c>: Copy and paste from the cloud browser to the local PC is allowed.</description></item>
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
                    /// <item><description><c>off</c>: Bidirectional transfer is denied.</description></item>
                    /// <item><description><c>read</c>: Copy and paste from the local PC to the cloud browser is allowed.</description></item>
                    /// <item><description><c>write</c>: Copy and paste from the cloud browser to the local PC is allowed.</description></item>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("RichTextClipboardLimit")]
                    [Validation(Required=false)]
                    public int? RichTextClipboardLimit { get; set; }

                    /// <summary>
                    /// <para>The clipboard size limit for inbound transfer (from the local PC to the cloud browser).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RichTextClipboardReadLimit")]
                    [Validation(Required=false)]
                    public int? RichTextClipboardReadLimit { get; set; }

                    /// <summary>
                    /// <para>The unit of the clipboard size.</para>
                    /// <list type="bullet">
                    /// <item><description><c>B</c>: bytes.</description></item>
                    /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KB</para>
                    /// </summary>
                    [NameInMap("RichTextClipboardReadSizeUnit")]
                    [Validation(Required=false)]
                    public string RichTextClipboardReadSizeUnit { get; set; }

                    /// <summary>
                    /// <para>The unit of the clipboard size.</para>
                    /// <list type="bullet">
                    /// <item><description><c>B</c>: bytes.</description></item>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RichTextClipboardWriteLimit")]
                    [Validation(Required=false)]
                    public int? RichTextClipboardWriteLimit { get; set; }

                    /// <summary>
                    /// <para>The unit of the clipboard size.</para>
                    /// <list type="bullet">
                    /// <item><description><c>B</c>: bytes.</description></item>
                    /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                    /// </list>
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
                    /// <item><description><c>off</c>: Bidirectional transfer is denied.</description></item>
                    /// <item><description><c>read</c>: Copy and paste from the local PC to the cloud browser is allowed.</description></item>
                    /// <item><description><c>write</c>: Copy and paste from the cloud browser to the local PC is allowed.</description></item>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TextClipboardReadLimit")]
                    [Validation(Required=false)]
                    public int? TextClipboardReadLimit { get; set; }

                    /// <summary>
                    /// <para>The unit of the clipboard size.</para>
                    /// <list type="bullet">
                    /// <item><description><c>B</c>: bytes.</description></item>
                    /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KB</para>
                    /// </summary>
                    [NameInMap("TextClipboardReadSizeUnit")]
                    [Validation(Required=false)]
                    public string TextClipboardReadSizeUnit { get; set; }

                    /// <summary>
                    /// <para>The clipboard size limit for outbound transfer (from the cloud browser to the local PC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TextClipboardWriteLimit")]
                    [Validation(Required=false)]
                    public int? TextClipboardWriteLimit { get; set; }

                    /// <summary>
                    /// <para>The unit of the clipboard size.</para>
                    /// <list type="bullet">
                    /// <item><description><c>B</c>: bytes.</description></item>
                    /// <item><description><c>KB</c>: 1024 bytes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>KB</para>
                    /// </summary>
                    [NameInMap("TextClipboardWriteSizeUnit")]
                    [Validation(Required=false)]
                    public string TextClipboardWriteSizeUnit { get; set; }

                }

                /// <summary>
                /// <para>The data retention policy for sessions after disconnection.</para>
                /// <list type="bullet">
                /// <item><description><c>customTime</c>: The session is retained for the duration specified by <c>DisconnectKeepSessionTime</c>.</description></item>
                /// <item><description><c>persistent</c>: The session is not subject to automatic release based on disconnection duration.</description></item>
                /// </list>
                /// <para><b>Note:</b> The <c>persistent</c> option is still subject to authorization and other release policies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customTime</para>
                /// </summary>
                [NameInMap("DisconnectKeepSession")]
                [Validation(Required=false)]
                public string DisconnectKeepSession { get; set; }

                /// <summary>
                /// <para>The session retention duration after disconnection. Unit: seconds. This value is for viewing the configuration only and does not indicate that this parameter can be set through the create operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1800</para>
                /// </summary>
                [NameInMap("DisconnectKeepSessionTime")]
                [Validation(Required=false)]
                public int? DisconnectKeepSessionTime { get; set; }

                /// <summary>
                /// <para>The floating ball file manager switch.</para>
                /// <list type="bullet">
                /// <item><description><c>on</c>: Enabled.</description></item>
                /// <item><description><c>off</c>: Disabled.</description></item>
                /// </list>
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
                /// <item><description><c>off</c>: Transfer is denied.</description></item>
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
                /// <para>The switch for automatic disconnection upon no operation. The value is case-insensitive.</para>
                /// <list type="bullet">
                /// <item><description><c>on</c>: Enabled.</description></item>
                /// <item><description><c>off</c>: Disabled.</description></item>
                /// </list>
                /// <para>When enabled, use <c>NoOperationDisconnectTime</c> to set the wait duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("NoOperationDisconnect")]
                [Validation(Required=false)]
                public string NoOperationDisconnect { get; set; }

                /// <summary>
                /// <para>The wait duration before disconnection is triggered after no operation, in seconds. Whether this feature is enabled is indicated by <c>NoOperationDisconnect</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("NoOperationDisconnectTime")]
                [Validation(Required=false)]
                public int? NoOperationDisconnectTime { get; set; }

                /// <summary>
                /// <para>The ID of the policy associated with the browser instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pg-0bf5d87epuq5****</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <para>The policy version.</para>
                /// <list type="bullet">
                /// <item><description><c>DEFAULT</c>: Legacy policy.</description></item>
                /// <item><description><c>CENTER</c>: Centralized policy.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CENTER</para>
                /// </summary>
                [NameInMap("PolicyVersion")]
                [Validation(Required=false)]
                public string PolicyVersion { get; set; }

                /// <summary>
                /// <para>The video display policy for browser sessions.</para>
                /// </summary>
                [NameInMap("VideoPolicy")]
                [Validation(Required=false)]
                public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyVideoPolicy VideoPolicy { get; set; }
                public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyVideoPolicy : TeaModel {
                    /// <summary>
                    /// <para>The frame rate of browser sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
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
                public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyWatermarkPolicy WatermarkPolicy { get; set; }
                public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelPolicyWatermarkPolicy : TeaModel {
                    /// <summary>
                    /// <para>The watermark switch. The value is case-insensitive.</para>
                    /// <list type="bullet">
                    /// <item><description><c>ON</c>: Watermark enabled.</description></item>
                    /// <item><description><c>OFF</c>: Watermark disabled.</description></item>
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
                    /// <item><description><c>EndUserId</c>: User ID.</description></item>
                    /// <item><description><c>InstanceGroupId</c>: Delivery group ID.</description></item>
                    /// <item><description><c>ClientTime</c>: Current time on the client.</description></item>
                    /// </list>
                    /// <para>Use watermark types supported by the browser and client.</para>
                    /// </summary>
                    [NameInMap("WatermarkTypes")]
                    [Validation(Required=false)]
                    public List<string> WatermarkTypes { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the browser instance group.</para>
            /// <list type="bullet">
            /// <item><description><c>DEPLOYING</c>: Being deployed.</description></item>
            /// <item><description><c>PUBLISHED</c>: Deployed.</description></item>
            /// <item><description><c>FAILED</c>: Deployment failed.</description></item>
            /// <item><description><c>EXPIRED</c>: Expired.</description></item>
            /// <item><description><c>CEASED</c>: Suspended due to overdue payment.</description></item>
            /// <item><description><c>MAINTAINING</c>: Being updated.</description></item>
            /// <item><description><c>MAINTAIN_FAILED</c>: Update failed.</description></item>
            /// <item><description><c>DELETING</c>: Being deleted.</description></item>
            /// <item><description><c>UNAVAILABLE</c>: Unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLISHED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The sub-billing type. In MAU scenarios, the actual returned value is <c>mau</c>, which indicates billing by monthly active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mau</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

            /// <summary>
            /// <para>Indicates whether mixed authorization of users and user groups is supported. <c>true</c> indicates supported, and <c>false</c> indicates not supported. Evaluate this value based on the current authorization mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportUserGroupMixedAuth")]
            [Validation(Required=false)]
            public bool? SupportUserGroupMixedAuth { get; set; }

            /// <summary>
            /// <para>The version of the browser.</para>
            /// <list type="bullet">
            /// <item><description><c>Basic</c>: Basic Edition.</description></item>
            /// <item><description><c>Pro</c>: Premium Edition.</description></item>
            /// </list>
            /// <para>In MAU scenarios, the value is <c>Pro</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pro</para>
            /// </summary>
            [NameInMap("Tier")]
            [Validation(Required=false)]
            public string Tier { get; set; }

            /// <summary>
            /// <para>The session timer configurations currently returned. These are for viewing the effective settings and do not indicate that the creation API supports setting this parameter.</para>
            /// </summary>
            [NameInMap("Timers")]
            [Validation(Required=false)]
            public List<GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelTimers> Timers { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelTimers : TeaModel {
                /// <summary>
                /// <para>The session retention duration after disconnection, in minutes. A value of <c>-1</c> indicates that the session is not unbound due to this timeout, but is still subject to authorization and other session release policies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The timer configuration type. <c>SESSION_TIMEOUT</c> indicates the session retention duration after disconnection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SESSION_TIMEOUT</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

            /// <summary>
            /// <para>The current authorization mode.</para>
            /// <list type="bullet">
            /// <item><description><c>Mixed</c>: Mixed authorization of users and user groups.</description></item>
            /// <item><description><c>User</c>: User authorization.</description></item>
            /// <item><description><c>UserGroup</c>: User group authorization.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Mixed</para>
            /// </summary>
            [NameInMap("UserGroupAuthMode")]
            [Validation(Required=false)]
            public string UserGroupAuthMode { get; set; }

            /// <summary>
            /// <para>The user quota information.</para>
            /// </summary>
            [NameInMap("UserLimit")]
            [Validation(Required=false)]
            public GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelUserLimit UserLimit { get; set; }
            public class GetBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelUserLimit : TeaModel {
                /// <summary>
                /// <para>The user quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("UserQuota")]
                [Validation(Required=false)]
                public int? UserQuota { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID, which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A0C2ED-95F2-1A37-9FC6-4A395179****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
