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
        /// <para>Specifies whether to enable auto-renewal. This parameter applies only when <c>CdsChargeType</c> is set to <c>PrePaid</c>.</para>
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
        /// <para>null</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The billing method of the cloud drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("CdsChargeType")]
        [Validation(Required=false)]
        public string CdsChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance. This parameter is required when <c>OfficeSiteType</c> is set to <c>AD_CONNECTOR</c> and you do not specify <c>OfficeSiteId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-g4ba1mkji8nj6****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The name of the domain controller. This parameter is required when <c>OfficeSiteType</c> is set to <c>AD_CONNECTOR</c> and you do not specify <c>OfficeSiteId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.local</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>A list of user IDs.</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The total capacity of the cloud drive.</para>
        /// <list type="bullet">
        /// <item><description><para>For pay-as-you-go cloud drives, the unit is bytes.</para>
        /// </description></item>
        /// <item><description><para>For subscription cloud drives, the unit is GiB. For example, set the value to 500 for 500 GiB, or to 2048 for 2 TiB.</para>
        /// </description></item>
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
        /// <para>The name of the cloud drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wuying-cds</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the office site. This parameter applies only when <c>OfficeSiteType</c> is set to <c>AD_CONNECTOR</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-400695****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The type of the office site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("OfficeSiteType")]
        [Validation(Required=false)]
        public string OfficeSiteType { get; set; }

        /// <summary>
        /// <para>The subscription duration. The unit is specified by <c>PeriodUnit</c>. This parameter is required only when <c>CdsChargeType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. This parameter is required only when <c>CdsChargeType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to query the regions supported by Elastic Desktop Service.</para>
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
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

        /// <summary>
        /// <para>The maximum number of users for a subscription cloud drive. This parameter is required only when <c>CdsChargeType</c> is set to <c>PrePaid</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public long? UserCount { get; set; }

        /// <summary>
        /// <para>The maximum size of the personal disk for each user, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>104857600</para>
        /// </summary>
        [NameInMap("UserMaxSize")]
        [Validation(Required=false)]
        public long? UserMaxSize { get; set; }

    }

}
