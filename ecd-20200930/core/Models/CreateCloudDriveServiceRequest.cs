// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateCloudDriveServiceRequest : TeaModel {
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
        /// <para>Specifies whether to enable auto-renewal. This parameter takes effect and is optional only when CdsChargeType is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The billing method of the NAS drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("CdsChargeType")]
        [Validation(Required=false)]
        public string CdsChargeType { get; set; }

        /// <summary>
        /// <para>The instance ID of the Cloud Enterprise Network (CEN) associated with the AD office network. This parameter takes effect only when <c>OfficeSiteType</c> is set to <c>AD_CONNECTOR</c>. If <c>OfficeSiteId</c> is specified, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-g4ba1mkji8nj6****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The domain controller name of the AD office network. This parameter takes effect only when <c>OfficeSiteType</c> is set to <c>AD_CONNECTOR</c>. If <c>OfficeSiteId</c> is specified, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.local</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The list of user IDs.</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The Peak Volume of the NAS drive storage space.</para>
        /// <list type="bullet">
        /// <item><description>When you create a pay-as-you-go NAS drive, the unit is bytes.</description></item>
        /// <item><description>When you create an upfront NAS drive, the unit is GiB. For example, to create a 500 GiB upfront NAS drive, set this parameter to 500. To create a 2 TiB upfront NAS drive, set this parameter to 2048.</description></item>
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
        /// <para>The name of the enterprise NAS drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wuying-cds</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the office network. This parameter takes effect only when the network type is set to <c>AD_CONNECTOR</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-400695****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The network type of the office network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        /// <summary>
        /// <para>The subscription duration. The unit is specified by <c>PeriodUnit</c>. This parameter takes effect and is required only when <c>CdsChargeType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration for the subscription NAS drive. This parameter takes effect and is required only when <c>CdsChargeType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID for resource ownership in reseller pattern. You do not need to specify this parameter if you are not in reseller pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1422724566551XXX</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sol-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// <para>The maximum number of users for the subscription NAS drive. This parameter takes effect and is required only when <c>CdsChargeType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public long? UserCount { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity of a personal drive when you assign a personal drive to a user. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>104857600</para>
        /// </summary>
        [NameInMap("UserMaxSize")]
        [Validation(Required=false)]
        public long? UserMaxSize { get; set; }

    }

}
