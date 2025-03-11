// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1dd299c-10c6-11ea-bbbb-************</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies the description of the instance. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The description cannot contain the prefix http:// or https://.</description></item>
        /// <item><description>The description must start with a letter or a Chinese character, and can contain uppercase and lowercase letters, Chinese characters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The description must be 2 to 256 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies the purchase duration of the subscription instance.</para>
        /// <list type="bullet">
        /// <item><description>If the PricingCycle parameter is set to year, the value range of the Duration parameter is 1 to 3.</description></item>
        /// <item><description>If the PricingCycle parameter is set to month, the value range of the Duration parameter is 1 to 9.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter only takes effect when the PayType parameter is set to drdsPre.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Specifies the instance type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>drds.sn2.4c16g</b>: The instance is of the Starter Edition.</description></item>
        /// <item><description><b>drds.sn2.8c32g</b>: The instance is of the Standard Edition</description></item>
        /// <item><description><b>drds.sn2.16c64g</b>: The instance is of the Enterprise Edition.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds.sn2.4c16g</para>
        /// </summary>
        [NameInMap("InstanceSeries")]
        [Validation(Required=false)]
        public string InstanceSeries { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: If the PricingCycle parameter is set to month, the subscription is automatically renewed for one month. If the PricingCycle parameter is set to year, the subscription is automatically renewed for one year.</description></item>
        /// <item><description><b>false</b>: The auto-renewal feature is disabled for the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter only takes effect when the PayType parameter is set to drdsPre.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAutoRenew")]
        [Validation(Required=false)]
        public bool? IsAutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies the ID of the primary instance. This parameter is only required when you create a read-only instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds***********</para>
        /// </summary>
        [NameInMap("MasterInstId")]
        [Validation(Required=false)]
        public string MasterInstId { get; set; }

        /// <summary>
        /// <para>Specifies the MySQL version that is supported by the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>5</b>: The instance is fully compatible with MySQL 5.x. This value is the default value.</description></item>
        /// <item><description><b>8</b>: The instance is fully compatible with MySQL 8.0.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter only takes effect when you create a primary instance. By default, the MySQL version of the read-only instance is the same as that of the primary instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MySQLVersion")]
        [Validation(Required=false)]
        public int? MySQLVersion { get; set; }

        /// <summary>
        /// <para>Specifies the billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>drdsPre</b>: The instance uses the subscription billing method.</description></item>
        /// <item><description><b>drdsPost</b>: The instance uses the pay-as-you-go billing method.</description></item>
        /// <item><description><b>drdsRo</b>: By default, the pay-as-you-go billing method is used when you create read-only instances.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drdsPost</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Specifies the unit of the subscription duration of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>year</b>: The unit of the subscription duration is year.</description></item>
        /// <item><description><b>month</b>: The unit of the subscription duration is month.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if you set the PayType parameter to drdsPre.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>Specifies the number of instances to be created. You can set the value only to 1. The value specifies that you can create one instance each time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>Specifies the region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies the ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Specifies the specification code of the instance. The value consists of the instance type and the specified instance specification. For example, you can set the value to drds.sn2.4c16g.8c32g.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds.sn2.4c16g.8C32g</para>
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// <para>Specifies the type of the instance. Set the value to PRIVATE. The value PRIVATE specifies that the instance is a dedicated instance.</para>
        /// <remarks>
        /// <para> You can also set the value to 1 to specify that the instance is a dedicated instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specifies the ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-**********</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Specifies the ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-**********</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>Specifies the zone ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a high-availability instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isHa")]
        [Validation(Required=false)]
        public bool? IsHa { get; set; }

    }

}
