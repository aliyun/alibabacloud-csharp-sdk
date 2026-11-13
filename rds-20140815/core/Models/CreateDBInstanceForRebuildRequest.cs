// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceForRebuildRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the target instance. The name must be 2 to 256 characters in length. It must start with a Chinese character or an English letter and can contain digits, Chinese characters, English letters, underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>The name cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The network connection type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: public network connection.</description></item>
        /// <item><description><b>Intranet</b>: internal network connection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// <para>The network type of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC.</description></item>
        /// <item><description><b>Classic</b>: classic network.</description></item>
        /// </list>
        /// <para>By default, instances of the classic network type are created.</para>
        /// <remarks>
        /// <para>You must specify this parameter and set it to <b>VPC</b> when the instance is a cloud disk instance. When this parameter is set to <b>VPC</b>, you must also specify the <b>VpcId</b> and <b>VSwitchId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription period of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly subscription.</description></item>
        /// <item><description><b>Month</b>: monthly subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this parameter when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. This parameter can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP whitelist</a> of the instance. Separate multiple entries with commas (,). Entries must be unique. A maximum of 1,000 entries are supported. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP address format, such as 10.10.XX.XX.</description></item>
        /// <item><description>CIDR format, such as 10.10.XX.XX/24. In Classless Inter-Domain Routing (CIDR), 24 indicates the prefix length of the address, which ranges from 1 to 32.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, the IP whitelist of the default group of the original instance is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>When the <b>Period</b> parameter is set to <b>Year</b>, the value of <b>UsedTime</b> ranges from <b>1</b> to <b>5</b>.</description></item>
        /// <item><description>When the <b>Period</b> parameter is set to <b>Month</b>, the value of <b>UsedTime</b> ranges from <b>1</b> to <b>11</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify this parameter when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID of the target instance. You must specify this parameter when <b>InstanceNetworkType</b> is set to <b>VPC</b>.</para>
        /// <remarks>
        /// <para>If you specify this parameter, you must also specify the <b>ZoneId</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6f7l4fg90****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. The zone of the vSwitch must match the zone ID specified in the <b>ZoneId</b> parameter.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The network type <b>InstanceNetworkType</b> must be set to <b>VPC</b>.</description></item>
        /// <item><description>If you specify the ZoneIdSlave1 parameter (secondary zone ID), you must specify two vSwitch IDs and separate them with a comma (,).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6adz52c2p****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary node. You can call the DescribeRegions operation to query zone IDs.</para>
        /// <remarks>
        /// <para>If you specify a VPC and a vSwitch, you must specify this parameter to match the zone of the vSwitch.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The ID of secondary zone 1.</para>
        /// <remarks>
        /// <para>You must specify this parameter for instances that are not of the Basic Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The ID of secondary zone 2.</para>
        /// <remarks>
        /// <para>You can specify this parameter only for instances of the RDS Enterprise Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
