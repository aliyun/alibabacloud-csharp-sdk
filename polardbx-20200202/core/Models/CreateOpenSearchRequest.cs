// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateOpenSearchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Keep the value unique for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test instance</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The node specification code of the PolarDB-X Search data node. Available specifications vary by region and sales configuration. Use a PolarDB-X Search node specification code that is available for purchase in the current region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opensearch.sn2ne.large.1</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The PolarDB-X Search engine version. The value is fixed to 3.0. If you do not specify this parameter, 3.0 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>A compatible parameter. This parameter does not take effect. Specify the node specification of the PolarDB-X Search data node by using DBNodeClass.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opensearch.sn2ne.large.1</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>The number of PolarDB-X Search data nodes. The value must be a positive integer and an integer multiple of the number of selected zones.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b>: Subscription.</description></item>
        /// <item><description><b>POSTPAY</b>: Pay-as-you-go.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle. For subscription instances, valid values are Year and Month. For pay-as-you-go instances, the default value is Hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. This parameter can be left empty. Resource groups are not currently supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-xxxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The storage space per node. Unit: GB. The value must be a positive integer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("StorageSpace")]
        [Validation(Required=false)]
        public int? StorageSpace { get; set; }

        /// <summary>
        /// <para>The storage type. Default value: cloud_auto.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The topology type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1azone</b>: Single zone.</description></item>
        /// <item><description><b>3azones</b>: Three-zone deployment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3azones</para>
        /// </summary>
        [NameInMap("TopologyType")]
        [Validation(Required=false)]
        public string TopologyType { get; set; }

        /// <summary>
        /// <para>Specifies the subscription duration in months or years.</para>
        /// <remarks>
        /// <para>If Period is set to Year, valid values for this parameter are 1, 2, and 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The secondary zone. This parameter is required when TopologyType is set to 3azones, and it cannot be the same as other zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("Zone2")]
        [Validation(Required=false)]
        public string Zone2 { get; set; }

        /// <summary>
        /// <para>The third zone. This parameter is required when TopologyType is set to 3azones, and it cannot be the same as other zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("Zone3")]
        [Validation(Required=false)]
        public string Zone3 { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
