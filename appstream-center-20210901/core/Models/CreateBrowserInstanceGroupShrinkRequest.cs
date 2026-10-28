// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateBrowserInstanceGroupShrinkRequest : TeaModel {
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
        public string BrowserConfigShrink { get; set; }

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
        public string NetworkShrink { get; set; }

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
        public string NodePoolShrink { get; set; }

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
        public string PolicyShrink { get; set; }

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
        public string SecurityPolicyShrink { get; set; }

        /// <summary>
        /// <para>The user data storage configuration of the browser group.</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicyShrink { get; set; }

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
        public string TagShrink { get; set; }

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
        public string TimersShrink { get; set; }

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
        public string UserInfoShrink { get; set; }

        /// <summary>
        /// <para>The list of authorized users. You can specify up to 200 users. The users must be created in advance and match the account type.</para>
        /// <para><b>Limit:</b> This parameter cannot be specified together with a non-empty UserGroupIds parameter.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public string UsersShrink { get; set; }

    }

}
