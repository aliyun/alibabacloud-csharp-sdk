// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRenewalPriceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. The value depends on the resource type (ResourceType) for which you want to query the renewal price:</para>
        /// <list type="bullet">
        /// <item><description>If <c>ResourceType</c> is set to <c>Desktop</c> (to query the renewal price of a cloud computer), set <c>InstanceId</c> to the cloud computer ID.</description></item>
        /// <item><description>If <c>ResourceType</c> is set to <c>DesktopGroup</c> (to query the renewal price of a cloud computer pool), set <c>InstanceId</c> to the cloud computer pool ID.</description></item>
        /// <item><description>If <c>ResourceType</c> is set to <c>Bandwidth</c> (to query the renewal price of premium Internet bandwidth), set <c>InstanceId</c> to the premium Internet bandwidth ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-6ldllk9zxcpfhs****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance IDs. The values depend on the resource type (ResourceType) for which you want to query the renewal price.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The renewal duration. Valid values of this parameter are determined by the value of <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Month</c>, valid values are 1, 2, 3, and 6.</description></item>
        /// <item><description>If <c>PeriodUnit</c> is set to <c>Year</c>, valid values are 1, 2, and 3.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the renewal duration, which is the unit of the <c>Period</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Wuying Workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the resource ownership user in reseller pattern. You do not need to specify this parameter in non-reseller pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017457975738750</para>
        /// </summary>
        [NameInMap("ResellerOwnerUid")]
        [Validation(Required=false)]
        public long? ResellerOwnerUid { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
