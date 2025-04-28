// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeRenewalPriceRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. The value you specify depends on the resource type (ResourceType) you\&quot;re querying the renewal price for.</para>
        /// <list type="bullet">
        /// <item><description>When <c>ResourceType</c> is set to <c>Desktop</c>, you must provide the cloud computer ID as the value of <c>InstanceId</c>.</description></item>
        /// <item><description>When <c>ResourceType</c> is set to <c>DesktopGroup</c>, you must provide the share ID as the value of <c>InstanceId</c>.</description></item>
        /// <item><description>When <c>ResourceType</c> is set to <c>Bandwidth</c>, you must provide the ID of the premium bandwidth plan as the value of <c>InstanceId</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-6ldllk9zxcpfhs****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance IDs. The value you specify depends on the resource type (ResourceType) you\&quot;re querying the renewal price for.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The renewal duration. The valid values for this parameter depend on the value of <c>PeriodUnit</c>.</para>
        /// <list type="bullet">
        /// <item><description>If you set <c>PeriodUnit</c> to <c>Month</c>, set the value of this parameter to 1, 2, 3, or 6.</description></item>
        /// <item><description>If you set <c>PeriodUnit</c> to <c>Year</c>, set the value of this parameter to 1, 2, or 3.</description></item>
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
        /// <para>The unit of the renewal duration specified by <c>Period</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month (default)</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the list of regions where Elastic Desktop Service (EDS) Enterprise is available.</para>
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
        /// <para>The resource type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Desktop (default): cloud computers.</description></item>
        /// <item><description>Bandwidth: premium bandwidth plans.</description></item>
        /// <item><description>DesktopGroup: cloud computer shares.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desktop</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
