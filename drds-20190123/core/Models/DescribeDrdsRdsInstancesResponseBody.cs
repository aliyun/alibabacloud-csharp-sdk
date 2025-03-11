// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsRdsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the custom ApsaraDB RDS for MySQL instances at the storage layer.</para>
        /// </summary>
        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribeDrdsRdsInstancesResponseBodyDbInstances DbInstances { get; set; }
        public class DescribeDrdsRdsInstancesResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<DescribeDrdsRdsInstancesResponseBodyDbInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDrdsRdsInstancesResponseBodyDbInstancesDbInstance : TeaModel {
                /// <summary>
                /// <para>The internal endpoint of the custom ApsaraDB RDS for MySQL instance at the storage layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-***************.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectUrl")]
                [Validation(Required=false)]
                public string ConnectUrl { get; set; }

                /// <summary>
                /// <para>The number of CPU cores of the custom ApsaraDB RDS for MySQL instance at the storage layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DBInstanceCPU")]
                [Validation(Required=false)]
                public string DBInstanceCPU { get; set; }

                /// <summary>
                /// <para>The instance family of the custom ApsaraDB RDS for MySQL instance at the storage layer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>x</b>: general-purpose instance family</description></item>
                /// <item><description><b>d</b>: dedicated instance family</description></item>
                /// <item><description><b>h</b>: dedicated host instance family</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>x</para>
                /// </summary>
                [NameInMap("DBInstanceClassType")]
                [Validation(Required=false)]
                public string DBInstanceClassType { get; set; }

                /// <summary>
                /// <para>The ID of the custom ApsaraDB RDS for MySQL instance at the storage layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-*****************</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The memory size of the custom ApsaraDB RDS for MySQL instance at the storage layer. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("DBInstanceMemory")]
                [Validation(Required=false)]
                public long? DBInstanceMemory { get; set; }

                /// <summary>
                /// <para>The status of the custom ApsaraDB RDS for MySQL instance at the storage layer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The instance is being created.</description></item>
                /// <item><description>1: The instance is running.</description></item>
                /// <item><description>3: The instance is being deleted.</description></item>
                /// <item><description>5: The instance is being restarted.</description></item>
                /// <item><description>6: The instance is being upgraded or downgraded.</description></item>
                /// <item><description>7: The instance is being backed up.</description></item>
                /// <item><description>8: The network type of the instance is being changed.</description></item>
                /// <item><description>9: The instance is being migrated.</description></item>
                /// <item><description>11: The data stored on the instance is being migrated.</description></item>
                /// <item><description>12: A disaster recovery instance is being generated.</description></item>
                /// <item><description>13: Data is being imported to the instance.</description></item>
                /// <item><description>14: Data is being imported from another RDS instance to the instance.</description></item>
                /// <item><description>15: A switchover is being performed.</description></item>
                /// <item><description>16: A temporary instance is being created.</description></item>
                /// <item><description>17: The network of the instance is being created.</description></item>
                /// <item><description>18: The instance is being cloned.</description></item>
                /// <item><description>19: The link is being changed.</description></item>
                /// <item><description>20: The read-only RDS instances of the instance are being migrated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The storage space of the custom ApsaraDB RDS for MySQL instance at the storage layer. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public long? DBInstanceStorage { get; set; }

                /// <summary>
                /// <para>The type of the instance at the storage layer. The value is RDS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("DbInstType")]
                [Validation(Required=false)]
                public string DbInstType { get; set; }

                /// <summary>
                /// <para>The ID of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dm-*************</para>
                /// </summary>
                [NameInMap("DmInstanceId")]
                [Validation(Required=false)]
                public string DmInstanceId { get; set; }

                /// <summary>
                /// <para>The engine type of the custom ApsaraDB RDS for MySQL instance at the storage layer. The value is MySQL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The engine version of the custom ApsaraDB RDS for MySQL instance at the storage layer. The value is 8.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The lock mode of the RDS instance. Valid values:</para>
                /// <para>0: The instance is not locked.</para>
                /// <para>1: The instance is manually locked.</para>
                /// <para>2: The instance is automatically locked if the instance expires.</para>
                /// <para>3: The instance is automatically locked if the instance is rolled back.</para>
                /// <para>4: The instance is automatically locked if the storage space of the instance reaches the upper limit.</para>
                /// <para>5: The instance is automatically locked if the storage space of the read-only instances reaches the upper limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public int? LockMode { get; set; }

                /// <summary>
                /// <para>The reason why the RDS instance is locked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Manually Locked</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>The network type of the custom ApsaraDB RDS for MySQL instance at the storage layer. The value is VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The billing method of the custom ApsaraDB RDS for MySQL instance at the storage layer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Postpaid: pay-as-you-go</description></item>
                /// <item><description>Prepaid: subscription</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The port used to connect to the instance over an internal network.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The type of the custom ApsaraDB RDS for MySQL instance at the storage layer. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Primary: primary instance</description></item>
                /// <item><description>Readonly: read-only instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("RdsInstType")]
                [Validation(Required=false)]
                public string RdsInstType { get; set; }

                /// <summary>
                /// <para>The read and write weights of the custom ApsaraDB RDS for MySQL instance at the storage layer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReadWeight")]
                [Validation(Required=false)]
                public int? ReadWeight { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123DB16B-02F2-45F7-A571-843991******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
