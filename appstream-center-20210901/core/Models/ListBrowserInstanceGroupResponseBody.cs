// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListBrowserInstanceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of browser instance groups on the current page.</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupModels")]
        [Validation(Required=false)]
        public List<ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModels> BrowserInstanceGroupModels { get; set; }
        public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModels : TeaModel {
            /// <summary>
            /// <para>Specifies whether notification emails for authorization and revocation are enabled. A value of <c>true</c> indicates that the feature is enabled. A value of <c>false</c> indicates that the feature is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthNotificationEnabled")]
            [Validation(Required=false)]
            public bool? AuthNotificationEnabled { get; set; }

            /// <summary>
            /// <para>The statistics of authorized users for the browser instance group.</para>
            /// </summary>
            [NameInMap("AuthorizedUserInfo")]
            [Validation(Required=false)]
            public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsAuthorizedUserInfo AuthorizedUserInfo { get; set; }
            public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsAuthorizedUserInfo : TeaModel {
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
            /// <para>The business region where the browser instance group is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("BizRegionId")]
            [Validation(Required=false)]
            public string BizRegionId { get; set; }

            /// <summary>
            /// <para>The current configuration of the browser.</para>
            /// </summary>
            [NameInMap("BrowserConfig")]
            [Validation(Required=false)]
            public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsBrowserConfig BrowserConfig { get; set; }
            public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsBrowserConfig : TeaModel {
                /// <summary>
                /// <para>The browser startup parameters. For example, <c>--incognito</c> specifies an incognito window.</para>
                /// 
                /// <b>Example:</b>
                /// <para>--incognito</para>
                /// </summary>
                [NameInMap("BrowserParam")]
                [Validation(Required=false)]
                public string BrowserParam { get; set; }

                /// <summary>
                /// <para>The cookie synchronization configuration. A value of <c>true</c> indicates that synchronization is enabled. A value of <c>false</c> indicates that synchronization is disabled.</para>
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
            /// <para>The ID of the cloud browser instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>big-0c7loey7fzjq****</para>
            /// </summary>
            [NameInMap("BrowserInstanceGroupId")]
            [Validation(Required=false)]
            public string BrowserInstanceGroupId { get; set; }

            /// <summary>
            /// <para>The name of the cloud browser instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office browser</para>
            /// </summary>
            [NameInMap("BrowserInstanceGroupName")]
            [Validation(Required=false)]
            public string BrowserInstanceGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the browser instance group set to which the group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>set-3jm9d0abc00example</para>
            /// </summary>
            [NameInMap("BrowserInstanceGroupSetId")]
            [Validation(Required=false)]
            public string BrowserInstanceGroupSetId { get; set; }

            /// <summary>
            /// <para>The billing method. In the MAU scenario, <c>PostPaid</c> is returned, which indicates pay-as-you-go.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The default access URL of the browser instance group. Use the actual URL returned by the API operation. Replace the resource ID in the example.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://wuying.aliyun.com/integration?appId=browser&appInstanceGroupId=big-0c7loey7fzjq">https://wuying.aliyun.com/integration?appId=browser&amp;appInstanceGroupId=big-0c7loey7fzjq</a>****</para>
            /// </summary>
            [NameInMap("DefaultAccessUrl")]
            [Validation(Required=false)]
            public string DefaultAccessUrl { get; set; }

            /// <summary>
            /// <para>The package duration information. This parameter is not applicable to the MAU scenario and may return an empty object.</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsDuration Duration { get; set; }
            public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsDuration : TeaModel {
                /// <summary>
                /// <para>The current payment stage of the package. This parameter is not applicable to the MAU scenario.</para>
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
                /// <para>The end time of the package cycle. This parameter is not applicable to the MAU scenario and is not returned.</para>
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
                /// <para>The start time of the package cycle. This parameter is not applicable to the MAU scenario and is not returned.</para>
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
                /// <para>The total duration of the package, in seconds. This parameter is not applicable to the MAU scenario.</para>
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
                /// <para>The used duration of the package, in seconds. This parameter is not applicable to the MAU scenario.</para>
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
            /// <para>The expiration time of the browser instance group. This parameter is not applicable to the MAU scenario and is not returned.</para>
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
            /// <para>The creation time of the browser instance group. The time follows the RFC 3339 standard in the <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss.SSSXXX</c> format, which includes milliseconds and time zone offset. The actual POP response uses the UTC offset <c>+00:00</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-21T07:00:39.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The homepage URL of the browser instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Homepage")]
            [Validation(Required=false)]
            public string Homepage { get; set; }

            /// <summary>
            /// <para>The ID of the image used by the browser instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-070qhs8oeju4****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The instance type used by the browser instance group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstreaming.general.basic</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The office network and website access restriction configurations.</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsNetwork Network { get; set; }
            public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsNetwork : TeaModel {
                /// <summary>
                /// <para>The website access restriction mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>ALLOW_ALL</c>: Allows all domain names.</description></item>
                /// <item><description><c>ALLOW_LIST</c>: Allows only websites in the whitelist.</description></item>
                /// </list>
                /// <para>The returned value reflects the existing configuration of the browser instance group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALLOW_ALL</para>
                /// </summary>
                [NameInMap("AccessRestriction")]
                [Validation(Required=false)]
                public string AccessRestriction { get; set; }

                /// <summary>
                /// <para>The ID of the office network to which the browser instance group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou+dir-843734****</para>
                /// </summary>
                [NameInMap("OfficeSiteId")]
                [Validation(Required=false)]
                public string OfficeSiteId { get; set; }

                /// <summary>
                /// <para>The list of vSwitch IDs used by the browser instance group. This parameter is available for scenarios where a custom network is configured.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

            }

            /// <summary>
            /// <para>The operating system type of the browser instance group. The current MAU product scenario uses Windows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The policy configuration returned for the browser instance group. The policy fields are used to view existing settings and do not indicate that all corresponding creation parameters are configurable.</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicy Policy { get; set; }
            public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicy : TeaModel {
                /// <summary>
                /// <para>The screen capture prevention switch. Valid values:</para>
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
                /// <para>The IP address whitelist rules for client access.</para>
                /// </summary>
                [NameInMap("AuthorizeAccessPolicyRules")]
                [Validation(Required=false)]
                public List<ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyAuthorizeAccessPolicyRules> AuthorizeAccessPolicyRules { get; set; }
                public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyAuthorizeAccessPolicyRules : TeaModel {
                    /// <summary>
                    /// <para>The source CIDR block of the client that is allowed to access.</para>
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
                    /// <para>The action of the client access rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>allow</c>: Allows access.</description></item>
                    /// <item><description><c>deny</c>: Denies access.</description></item>
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
                public List<ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyClientTypes> ClientTypes { get; set; }
                public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyClientTypes : TeaModel {
                    /// <summary>
                    /// <para>The client type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>windows</c>: Windows client.</description></item>
                    /// <item><description><c>macos</c>: macOS client.</description></item>
                    /// <item><description><c>html5</c>: Web client.</description></item>
                    /// <item><description><c>linux</c>: Linux client.</description></item>
                    /// <item><description><c>android</c>: Android client.</description></item>
                    /// <item><description><c>ios</c>: iOS client.</description></item>
                    /// </list>
                    /// <para>This field reflects the existing access configurations and does not indicate that all clients are currently available for the product.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>windows</para>
                    /// </summary>
                    [NameInMap("ClientType")]
                    [Validation(Required=false)]
                    public string ClientType { get; set; }

                    /// <summary>
                    /// <para>The access policy switch for the client type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>on</c>: Allows access from this type of client.</description></item>
                    /// <item><description><c>off</c>: Denies access from this type of client.</description></item>
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
                /// <para>Sets the clipboard transfer direction, content type, and size limit. <c>read</c> indicates transfer from the local PC to the cloud browser, and <c>write</c> indicates transfer from the cloud browser to the local PC.</para>
                /// </summary>
                [NameInMap("ClipboardPolicy")]
                [Validation(Required=false)]
                public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyClipboardPolicy ClipboardPolicy { get; set; }
                public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyClipboardPolicy : TeaModel {
                    /// <summary>
                    /// <para>The clipboard transfer direction. The value is not case-sensitive. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>off</c>: Prohibits transfer in both directions.</description></item>
                    /// <item><description><c>read</c>: Allows copy and paste from the local PC to the cloud browser.</description></item>
                    /// <item><description><c>write</c>: Allows copy and paste from the cloud browser to the local PC.</description></item>
                    /// <item><description><c>readwrite</c>: Allows transfer in both directions.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>readwrite</para>
                    /// </summary>
                    [NameInMap("Clipboard")]
                    [Validation(Required=false)]
                    public string Clipboard { get; set; }

                }

                /// <summary>
                /// <para>The dual-screen switch for the cloud browser.</para>
                /// 
                /// <b>Example:</b>
                /// <para>off</para>
                /// </summary>
                [NameInMap("MultiScreen")]
                [Validation(Required=false)]
                public string MultiScreen { get; set; }

                /// <summary>
                /// <para>The video display policy for browser sessions.</para>
                /// </summary>
                [NameInMap("VideoPolicy")]
                [Validation(Required=false)]
                public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyVideoPolicy VideoPolicy { get; set; }
                public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyVideoPolicy : TeaModel {
                    /// <summary>
                    /// <para>The frame rate for browser sessions.</para>
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
                public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyWatermarkPolicy WatermarkPolicy { get; set; }
                public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsPolicyWatermarkPolicy : TeaModel {
                    /// <summary>
                    /// <para>The watermark switch. The value is case-insensitive. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>ON</c>: Enables the watermark.</description></item>
                    /// <item><description><c>OFF</c>: Disables the watermark.</description></item>
                    /// </list>
                    /// <para>If the watermark is disabled, the watermark content type list is not used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ON</para>
                    /// </summary>
                    [NameInMap("WatermarkSwitch")]
                    [Validation(Required=false)]
                    public string WatermarkSwitch { get; set; }

                    /// <summary>
                    /// <para>The list of watermark content types. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><c>EndUserId</c>: The user identifier.</description></item>
                    /// <item><description><c>InstanceGroupId</c>: The delivery group identifier.</description></item>
                    /// <item><description><c>ClientTime</c>: The current time of the client.</description></item>
                    /// </list>
                    /// <para>Use the watermark types supported by the browser and the client.</para>
                    /// </summary>
                    [NameInMap("WatermarkTypes")]
                    [Validation(Required=false)]
                    public List<string> WatermarkTypes { get; set; }

                }

            }

            /// <summary>
            /// <para>The status of the browser group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>DEPLOYING</c>: Deploying.</description></item>
            /// <item><description><c>PUBLISHED</c>: Published.</description></item>
            /// <item><description><c>FAILED</c>: Failed.</description></item>
            /// <item><description><c>EXPIRED</c>: Expired.</description></item>
            /// <item><description><c>CEASED</c>: Suspended due to overdue payment.</description></item>
            /// <item><description><c>MAINTAINING</c>: Updating.</description></item>
            /// <item><description><c>MAINTAIN_FAILED</c>: Update failed.</description></item>
            /// <item><description><c>DELETING</c>: Deleting.</description></item>
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
            /// <para>The sub-billing method. In the MAU scenario, <c>mau</c> is returned, which indicates billing by monthly active users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mau</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

            /// <summary>
            /// <para>Indicates whether mixed authorization of users and user groups is supported. A value of <c>true</c> indicates that it is supported, and a value of <c>false</c> indicates that it is not supported. Evaluate this parameter based on the current authorization mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SupportUserGroupMixedAuth")]
            [Validation(Required=false)]
            public bool? SupportUserGroupMixedAuth { get; set; }

            /// <summary>
            /// <para>The list of resource tags returned.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsTags> Tags { get; set; }
            public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usage</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>office</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The version of the browser. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>Basic</c>: Basic Edition.</description></item>
            /// <item><description><c>Pro</c>: Premium Edition.</description></item>
            /// </list>
            /// <para>In the MAU scenario, the value is <c>Pro</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pro</para>
            /// </summary>
            [NameInMap("Tier")]
            [Validation(Required=false)]
            public string Tier { get; set; }

            /// <summary>
            /// <para>The session timer configuration returned. This is used to view the effective settings and does not indicate that the create operation supports configuring this parameter.</para>
            /// </summary>
            [NameInMap("Timers")]
            [Validation(Required=false)]
            public List<ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsTimers> Timers { get; set; }
            public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsTimers : TeaModel {
                /// <summary>
                /// <para>The session retention duration after disconnection, in minutes. A value of <c>-1</c> indicates that the session is not unbound due to the timeout of this duration, but is still affected by authorization and other session release policies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                /// <summary>
                /// <para>The timer configuration type. A value of <c>SESSION_TIMEOUT</c> indicates the session retention duration after disconnection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SESSION_TIMEOUT</para>
                /// </summary>
                [NameInMap("TimerType")]
                [Validation(Required=false)]
                public string TimerType { get; set; }

            }

            /// <summary>
            /// <para>The current authorization mode. Valid values:</para>
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
            public ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsUserLimit UserLimit { get; set; }
            public class ListBrowserInstanceGroupResponseBodyBrowserInstanceGroupModelsUserLimit : TeaModel {
                /// <summary>
                /// <para>The number of user quotas.</para>
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
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A0C2ED-95F2-1A37-9FC6-4A395179****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of browser groups that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
