// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveServiceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the auto-payment feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the auto-payment feature. Ensure your Alibaba Cloud account has sufficient balance. Insufficient balance may result in abnormal orders.</description></item>
        /// <item><description>false (default): disables the auto-payment feature. The order is generated, but payment must be made manually. You can log on to the Alibaba Cloud Management Console and complete the payment based on the order ID on the Orders page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Optional. Specifies whether to enable the auto-renewal feature. This parameter takes effect only if you set CdsChargeType to <c>Prepaid</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The billing method of the enterprise drive.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// <item><description>PrePaid: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("CdsChargeType")]
        [Validation(Required=false)]
        public string CdsChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance. This parameter takes effect only if you set <c>OfficeSiteType</c> to <c>AD_CONNECTOR</c>. If you have configured <c>OfficeSiteId</c>, you can leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-g4ba1mkji8nj6****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The domain name of the enterprise AD office network. This parameter takes effect only if you set <c>OfficeSiteType</c> to <c>AD_CONNECTOR</c>. If you have configured <c>OfficeSiteId</c>, you can leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.local</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The user IDs.</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity of the enterprise drive.</para>
        /// <list type="bullet">
        /// <item><description>For a pay-as-you-go enterprise drive, the unit is bytes.</description></item>
        /// <item><description>For a subscription enterprise drive, the unit is GiB. For example, to create a 500 GiB subscription drive, set the value to 500 GiB. To create a 2 TiB subscription drive, set the value to 2048 GiB.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536870912000</para>
        /// </summary>
        [NameInMap("MaxSize")]
        [Validation(Required=false)]
        public long? MaxSize { get; set; }

        /// <summary>
        /// <para>The name of the enterprise drive</para>
        /// 
        /// <b>Example:</b>
        /// <para>wuying-pds</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the office network. This parameter takes effect only if you set OfficeSiteType to <c>AD_CONNECTOR</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-400695****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The type of the office network.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SIMPLE: convenience office network.</description></item>
        /// <item><description>AD_CONNECTOR: enterprise Active Directory (AD) office network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        /// <summary>
        /// <para>The subscription duration. The unit is specified by <c>PeriodUnit</c>. This parameter takes effect only if you set <c>CdsChargeType</c> to <c>PrePaid</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>Required. The unit of the subscription duration. This parameter takes effect only if you set <c>CdsChargeType</c> to <c>PrePaid</c>.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Year</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the list of regions where Enterprise Drive Service is available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>co-0esnf8kb8zpfbqmvt</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// <para>Required. The maximum number of users allowed on the enterprise drive. This parameter takes effect only if you set <c>CdsChargeType</c> to <c>PrePaid</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5 when the value of MaxSize is 500 GiB.</description></item>
        /// <item><description>20 when the value of MaxSize is 2048 GiB.</description></item>
        /// <item><description>50 when the value of MaxSize is 5120 GiB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public long? UserCount { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity of the user\&quot;s personal disk when allocated. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024000</para>
        /// </summary>
        [NameInMap("UserMaxSize")]
        [Validation(Required=false)]
        public long? UserMaxSize { get; set; }

    }

}
