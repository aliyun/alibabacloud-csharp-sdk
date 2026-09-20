// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateServerlessClusterRequest : TeaModel {
        /// <summary>
        /// <para>The auto-renewal period of the instance. Unit: months.</para>
        /// <remarks>
        /// <list type="bullet"><item><description>The default value of the auto-renewal period is 0, which indicates that the instance is not automatically renewed after the instance expires.</description></item>
        /// </remarks>
        /// <item><description>For example, if the auto-renewal period is set to 2, the instance is automatically renewed for two months after the instance expires.</description></item></list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can be up to 64 ASCII characters in length and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The parameter that identifies the source of the creation request. For public cloud, leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serverless-name</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The disk type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: ultra cloud disk.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>local_hdd_pro</b>: local HDD.</description></item>
        /// <item><description><b>local_ssd_pro</b>: local SSD.</description></item>
        /// <item><description><b>cloud_essd_pl1</b>: ESSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The engine type of the HBase Serverless instance. Set the value to <b>serverlesshbase</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serverlesshbase</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The DPI engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription duration of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If PeriodUnit is set to year, valid values are <b>1</b> to <b>3</b>.</description></item>
        /// <item><description>If PeriodUnit is set to month, valid values are <b>1</b> to <b>9</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when the billing method of the instance is <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration for the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>year</b>: year.</description></item>
        /// <item><description><b>month</b>: month.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when the billing method of the instance is <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/144489.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-j4d53glb3****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The processing capability per unit. Unit: CU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ServerlessCapability")]
        [Validation(Required=false)]
        public int? ServerlessCapability { get; set; }

        /// <summary>
        /// <para>The specification type. Valid values: leave empty or <b>serverless.small</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serverless.small</para>
        /// </summary>
        [NameInMap("ServerlessSpec")]
        [Validation(Required=false)]
        public string ServerlessSpec { get; set; }

        /// <summary>
        /// <para>The storage size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ServerlessStorage")]
        [Validation(Required=false)]
        public int? ServerlessStorage { get; set; }

        /// <summary>
        /// <para>The vSwitch ID within the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp191ipotqj1ssyl*****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// <remarks>
        /// <para>If both this parameter and the VswitchId parameter are left empty, the network type of the instance is classic network.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp120k6ixs4eog****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID. You can call the <a href="https://help.aliyun.com/document_detail/144489.html">DescribeRegions</a> operation to query the zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
