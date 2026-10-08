// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RecoveryDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID. You can call the DescribeBackups operation to query backup sets.</para>
        /// <para>If you specify this parameter, the <b>DBInstanceId</b> parameter is optional.</para>
        /// <remarks>
        /// <para>You must specify at least one of <b>BackupId</b> and <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>29304****</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The instance type of the new instance. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mssql.x4.medium.s1</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance ID of the original instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you want to recover data by backup set (by specifying the BackupId parameter), this parameter is optional.</description></item>
        /// <item><description>If you want to recover data to a point in time (by specifying the RestoreTime parameter), this parameter is required.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp18****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The instance storage capacity of the new instance. Unit: GB. For details, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// <remarks>
        /// <para>The disk space of the new instance cannot be smaller than that of the original instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd/ephemeral_ssd</b>: local SSD.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD cloud disk.</description></item>
        /// <item><description><b>cloud_essd</b>: Enterprise SSD (ESSD) cloud disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The database name. To restore data to a new instance, use the following format: <c>Original database name 1,New database name 2</c>.</para>
        /// <remarks>
        /// <para>To restore data to an existing instance, see <a href="https://help.aliyun.com/document_detail/2628854.html">CopyDatabaseBetweenInstances</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1,test2</para>
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// <para>The network type of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Classic</b>: classic network.</description></item>
        /// <item><description><b>VPC</b>: virtual private cloud (VPC).</description></item>
        /// </list>
        /// <para>Default value: the network type of the original instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>The billing method of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: year.</description></item>
        /// <item><description><b>Month</b>: month.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The internal IP address of the new instance. The IP address must be within the IP address range of the specified vSwitch. By default, the system automatically assigns an IP address based on the values of <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.69</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Any point in time within the backup retention period. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <para>If you specify this parameter, the <b>DBInstanceId</b> parameter is required.</para>
        /// <remarks>
        /// <para>You must specify at least one of <b>BackupId</b> and <b>RestoreTime</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-11T16:00:00Z</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// <para>The instance ID of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp17****</para>
        /// </summary>
        [NameInMap("TargetDBInstanceId")]
        [Validation(Required=false)]
        public string TargetDBInstanceId { get; set; }

        /// <summary>
        /// <para>The subscription duration of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, the value of <b>UsedTime</b> ranges from <b>1 to 3</b>.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, the value of <b>UsedTime</b> ranges from <b>1 to 9</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID of the new instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the new instance. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
