// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class TransformToEcsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal cycle. Unit: month. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>6</b>, and <b>12</b>.</para>
        /// <remarks>
        /// <para>This parameter is required if you set <b>AutoRenew</b> to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public long? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The billing method of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PostPaid</b>: pay-as-you-go</para>
        /// </description></item>
        /// <item><description><para><b>PrePaid</b>: subscription. If you set this parameter to PrePaid, you must also specify the <b>Period</b> parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run to check the request. The check items include the required parameters, request format, service limits, and available resources. If the check fails, the corresponding error is returned. If the check passes, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request and creates an instance after the request passes the check.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The time when to switch the database after data migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Immediately</b>: The database is immediately switched after the migration is complete.</para>
        /// </description></item>
        /// <item><description><para><b>MaintainTime</b>: The database is switched within the maintenance window.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>Immediately</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The Redis-compatible version of the instance. Valid values: <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The instance type of the target cloud-native instance. For more information, see <a href="https://help.aliyun.com/document_detail/26350.html">Instance types</a>.</para>
        /// <remarks>
        /// <para>If you want to convert a cluster instance, you must specify the corresponding cloud-native cluster instance type that includes .with.proxy in its name and specify the ShardCount parameter.</para>
        /// <list type="bullet">
        /// <item><description>For a cluster instance, you must provide the corresponding cloud-native cluster specification that includes <c>.proxy</c>. You must also specify the number of shards by using the <c>ShardCount</c> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tair.rdb.1g
        /// tair.rdb.with.proxy.1g</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the classic instance that you want to convert.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to deploy the instance across availability zones. This feature is supported only for cluster instances.</para>
        /// </summary>
        [NameInMap("IsAcrossZone")]
        [Validation(Required=false)]
        public bool? IsAcrossZone { get; set; }

        /// <summary>
        /// <para>The ID of the availability zone.</para>
        /// </summary>
        [NameInMap("IzNo")]
        [Validation(Required=false)]
        public string IzNo { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: month. Valid values: <b>1</b>, <b>2</b>, <b>3</b>, <b>4</b>, <b>5</b>, 6, 7, 8, 9, 12, 24, and 36.</para>
        /// <remarks>
        /// <para>This parameter is available and required only if you set the <b>ChargeType</b> parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary availability zone.</para>
        /// </summary>
        [NameInMap("SecondaryIzNo")]
        [Validation(Required=false)]
        public string SecondaryIzNo { get; set; }

        /// <summary>
        /// <para>The number of data shards in the cloud-native cluster instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public long? ShardCount { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
