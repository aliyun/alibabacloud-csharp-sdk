// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateBrowserInstanceGroupShrinkRequest : TeaModel {
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
        public string BrowserConfigShrink { get; set; }

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
        public string NetworkShrink { get; set; }

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
        public string NodePoolShrink { get; set; }

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
        public string PolicyShrink { get; set; }

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
        public string SecurityPolicyShrink { get; set; }

        /// <summary>
        /// <para>The user data storage configuration for the browser group.</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicyShrink { get; set; }

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
        public string TagShrink { get; set; }

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
        public string TimersShrink { get; set; }

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
        public string UserInfoShrink { get; set; }

        /// <summary>
        /// <para>The list of authorized users. A maximum of 200 users can be specified. Users must be created in advance and must match the account type.</para>
        /// <para><b>Restriction:</b> This parameter cannot be specified together with a non-empty <c>UserGroupIds</c>.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public string UsersShrink { get; set; }

    }

}
