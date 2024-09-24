// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RecoveryDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID. You can call the DescribeBackups operation to query the backup set ID.</para>
        /// <para>If you specify this parameter, you do not need to specify <b>DBInstanceId</b>.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>BackupId</b> or <b>RestoreTime</b> parameters.</para>
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
        /// <para>rds.mysql.s2.large</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The ID of the original instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify BackupId, you do not need to specify this parameter.</description></item>
        /// <item><description>If you specify RestoreTime, you must also specify this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-xxxxxxxx1</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage capacity of the new instance. Unit: GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
        /// <remarks>
        /// <para> You must set this parameter to a value that is greater than or equal to the storage capacity of the original instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd/ephemeral_ssd</b>: local SSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>cloud_essd</b>: enhanced SSD (ESSD)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>The name of the database. When you restore data to a new instance, the format of the database name is <c>Original database name 1,New database name 2</c>.</para>
        /// <remarks>
        /// <para> For more information about how to restore data to an existing instance, see <a href="https://help.aliyun.com/document_detail/2628854.html">CopyDatabaseBetweenInstances</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Restore databases to a new instance: test1,test2. Restore databases to an existing instance: {&quot;test1&quot;:&quot;newtest1&quot;,&quot;test2&quot;:&quot;newtest2&quot;}</para>
        /// </summary>
        [NameInMap("DbNames")]
        [Validation(Required=false)]
        public string DbNames { get; set; }

        /// <summary>
        /// <para>The network type of the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Classic</b></description></item>
        /// <item><description><b>VPC</b></description></item>
        /// </list>
        /// <para>By default, the new instance uses the same network type as the original instance.</para>
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
        /// <para>The unit that is used to calculate the billing cycle of the new instance. This parameter takes effect only when you select the subscription billing method for the new instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter must be specified when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The internal IP address of the new instance. The internal IP address must be within the CIDR block that is supported by the specified vSwitch. The system automatically assigns an internal IP address based on the values of the <b>VPCId</b> and <b>VSwitchId</b> parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XXX.XXX.69</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore data. The point in time must fall within the specified log backup retention period. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>If you specify this parameter, you must also specify <b>DBInstanceId</b>.</para>
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
        /// <para>The ID of the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("TargetDBInstanceId")]
        [Validation(Required=false)]
        public string TargetDBInstanceId { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when <b>Period</b> is set to <b>Year</b>: <b>1 to 3</b>.****</description></item>
        /// <item><description>Valid values when <b>Period</b> is set to <b>Month</b>: <b>1 to 9</b>.****</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter must be specified when PayType is set to <b>Prepaid</b>.</para>
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
        /// <para>vpc-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the new instance. If you specify more than one vSwitch ID, you must separate the IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
