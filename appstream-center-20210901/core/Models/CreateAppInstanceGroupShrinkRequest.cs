// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The image ID of the application. To obtain the image ID, log on to the <a href="https://appstreaming.console.aliyun.com/">App Streaming console</a>. In the left-side navigation pane, choose <b>Maintenance</b> &gt; <b>Custom Images</b> or Maintenance &gt; <b>System Images</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-8z4nztpaqvay4****</para>
        /// </summary>
        [NameInMap("AppCenterImageId")]
        [Validation(Required=false)]
        public string AppCenterImageId { get; set; }

        /// <summary>
        /// <para>The name of the delivery group.</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>Package type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser.package.5.250.appstreaming.general.basic</para>
        /// </summary>
        [NameInMap("AppPackageType")]
        [Validation(Required=false)]
        public string AppPackageType { get; set; }

        /// <summary>
        /// <para>Policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-0clfzcy0adpcf****</para>
        /// </summary>
        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <para>The authentication mode of the delivery group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>App</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AuthMode")]
        [Validation(Required=false)]
        public string AuthMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false: manual payment. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false: manual payment. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the region where the delivery group resides. For information about the supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// <item><description>cn-hangzhou: China (Hangzhou)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The sales mode.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Node: by resource</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Node</para>
        /// </summary>
        [NameInMap("ChargeResourceMode")]
        [Validation(Required=false)]
        public string ChargeResourceMode { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cls-d39iq73l5c0a8****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The network settings.</para>
        /// <remarks>
        /// <para> If you want to use this parameter, submit a ticket.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string NetworkShrink { get; set; }

        /// <summary>
        /// <para>The node pool object.</para>
        /// </summary>
        [NameInMap("NodePool")]
        [Validation(Required=false)]
        public string NodePoolShrink { get; set; }

        /// <summary>
        /// <para>The subscription duration of resources. This parameter is required if you set <c>ChargeType</c> to <c>PrePaid</c>. The unit of this parameter is specified by <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid value if you set <c>PeriodUnit</c> to <c>Week</c>:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values if you set <c>PeriodUnit</c> to <c>Month</c>:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Valid values if you set <c>PeriodUnit</c> to <c>Year</c>:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set <c>ChargeType</c> to <c>PostPaid</c>, set this parameter to 1.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is available if you set <c>ChargeType</c> to <c>PrePaid</c>.</para>
        /// <remarks>
        /// <para> The value of this parameter is case-insensitive. For example, <c>Week</c> is valid and <c>week</c> is invalid. If you specify an invalid value combination for Period and PeriodUnit, such as <c>2 Week</c>, the operation can still be called. However, an error occurs when you place the order.</para>
        /// </remarks>
        /// <remarks>
        /// <para> If you set <c>ChargeType</c> to <c>PostPaid</c>, set this parameter to <c>Month</c>.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// <item><description>Week</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the pre-open application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cag-b2ron*******</para>
        /// </summary>
        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The promotion ID. You can call the <a href="https://help.aliyun.com/document_detail/428503.html">GetResourcePrice</a> operation to obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The runtime policy.</para>
        /// </summary>
        [NameInMap("RuntimePolicy")]
        [Validation(Required=false)]
        public string RuntimePolicyShrink { get; set; }

        /// <summary>
        /// <para>The security policy.</para>
        /// </summary>
        [NameInMap("SecurityPolicy")]
        [Validation(Required=false)]
        public string SecurityPolicyShrink { get; set; }

        /// <summary>
        /// <para>The period of time during which the application can be recycled. The recycling period is the period of time between the time when the end user disconnects from the application and the time when processes exit the application. If you do not want to recycle the application, set this parameter to <c>-1</c>. Valid values:-1 and 3 to 300. The value must be an integer. Default value: <c>15</c>. Unit: minutes.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <para>The storage policy.</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicyShrink { get; set; }

        /// <summary>
        /// <para>Payment method subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postPaid</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The custom policy.</para>
        /// </summary>
        [NameInMap("UserDefinePolicy")]
        [Validation(Required=false)]
        public string UserDefinePolicyShrink { get; set; }

        /// <summary>
        /// <para>List of authorized user group IDs.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The information about the user that you want to add to the assigned user list of the delivery group. This parameter is required if you configure <c>Users</c>.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

        /// <summary>
        /// <para>The users that you want to add to the assigned user list of the delivery group.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// <para>Display policy.</para>
        /// </summary>
        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public string VideoPolicyShrink { get; set; }

    }

}
