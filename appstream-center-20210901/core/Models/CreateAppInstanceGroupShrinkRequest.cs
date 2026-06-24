// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateAppInstanceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application image ID. You can obtain the ID from the <b>O&amp;M</b> &gt; <b>Custom Images</b> or <b>System Images</b> page in the <a href="https://appstreaming.console.aliyun.com/">WUYING Cloud Application console</a>.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>办公应用</para>
        /// </summary>
        [NameInMap("AppInstanceGroupName")]
        [Validation(Required=false)]
        public string AppInstanceGroupName { get; set; }

        /// <summary>
        /// <para>The package type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>browser.package.5.250.appstreaming.general.basic</para>
        /// </summary>
        [NameInMap("AppPackageType")]
        [Validation(Required=false)]
        public string AppPackageType { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-0clfzcy0adpcf****</para>
        /// </summary>
        [NameInMap("AppPolicyId")]
        [Validation(Required=false)]
        public string AppPolicyId { get; set; }

        /// <summary>
        /// <para>The authorization mode of the delivery group.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The region ID of the delivery group. For information about supported regions, see <a href="https://help.aliyun.com/document_detail/426036.html">Limits</a>.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cls-d39iq73l5c0a8****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <remarks>
        /// <para>To use this parameter, submit a ticket.</para>
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
        /// <para>The subscription duration of the resource when <c>ChargeType</c> is set to <c>PrePaid</c>. This parameter is required. The unit is specified by <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Week</c>, valid values:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>6</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If <c>ChargeType</c> is set to <c>PostPaid</c>, set this parameter to 1.</para>
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
        /// <para>The unit of the subscription duration when <c>ChargeType</c> is set to <c>PrePaid</c>.</para>
        /// <remarks>
        /// <para>This parameter is case-sensitive. For example, <c>Week</c> is valid, but <c>week</c> is invalid.
        /// If the request parameters do not match the valid combinations, such as <c>2 Week</c>, the API call succeeds but an error occurs during the order placement.</para>
        /// </remarks>
        /// <remarks>
        /// <para>If <c>ChargeType</c> is set to <c>PostPaid</c>, set this parameter to <c>Month</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Week</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The pre-opened application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cag-b2ronxxd****</para>
        /// </summary>
        [NameInMap("PreOpenAppId")]
        [Validation(Required=false)]
        public string PreOpenAppId { get; set; }

        /// <summary>
        /// <para>The product type.</para>
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
        /// <para>The application recycling timeout period, in minutes. After an end user disconnects from a cloud application for a period of time, the cloud application process exits. This period is the application recycling timeout. Set this parameter to <c>-1</c> if you do not want the application to be recycled. Valid values: -1 and 3 to 300 (integer). Default value: <c>15</c>.</para>
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
        /// <para>The billing method subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>postPaid</para>
        /// </summary>
        [NameInMap("SubPayType")]
        [Validation(Required=false)]
        public string SubPayType { get; set; }

        /// <summary>
        /// <para>The user-defined policy.</para>
        /// </summary>
        [NameInMap("UserDefinePolicy")]
        [Validation(Required=false)]
        public string UserDefinePolicyShrink { get; set; }

        /// <summary>
        /// <para>The list of authorized user group IDs.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The user information of the users to be added to the delivery group. This field is required if the <c>Users</c> parameter is specified.</para>
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

        /// <summary>
        /// <para>The list of usernames to be added to the delivery group as assigned users.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// <para>The display policy.</para>
        /// </summary>
        [NameInMap("VideoPolicy")]
        [Validation(Required=false)]
        public string VideoPolicyShrink { get; set; }

    }

}
