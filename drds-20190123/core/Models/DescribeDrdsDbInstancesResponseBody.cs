// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates information about the ApsaraDB RDS for MySQL instances that are used to store the data of the specified database.</para>
        /// </summary>
        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribeDrdsDbInstancesResponseBodyDbInstances DbInstances { get; set; }
        public class DescribeDrdsDbInstancesResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstance : TeaModel {
                /// <summary>
                /// <para>Indicates the endpoint that is used to connect to an ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp1t1mk5a5b******.mysql.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectUrl")]
                [Validation(Required=false)]
                public string ConnectUrl { get; set; }

                /// <summary>
                /// <para>Indicates the ID of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp1t1mk5a5bdj****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>Indicates the state of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The ApsaraDB RDS for MySQL instance is being created.</description></item>
                /// <item><description><b>1</b>: The ApsaraDB RDS for MySQL instance is running.</description></item>
                /// <item><description><b>3</b>: The ApsaraDB RDS for MySQL instance is being deleted.</description></item>
                /// <item><description><b>5</b>: The ApsaraDB RDS for MySQL instance is being restarted.</description></item>
                /// <item><description><b>6</b>: The ApsaraDB RDS for MySQL instance is being upgraded or downgraded.</description></item>
                /// <item><description><b>7</b>: The ApsaraDB RDS for MySQL instance is being backed up.</description></item>
                /// <item><description><b>8</b>: The network type of the ApsaraDB RDS for MySQL instance is being changed.</description></item>
                /// <item><description><b>9</b>: The ApsaraDB RDS for MySQL instance is being migrated.</description></item>
                /// <item><description><b>11</b>: The data of the ApsaraDB RDS for MySQL instance is being migrated.</description></item>
                /// <item><description><b>12</b>: A disaster-recovery instance is being generated.</description></item>
                /// <item><description><b>13</b>: Data is being imported to the ApsaraDB RDS for MySQL instance.</description></item>
                /// <item><description><b>14</b>: Data is being imported to the ApsaraDB RDS for MySQL instance from an another ApsaraDB RDS for MySQL instance.</description></item>
                /// <item><description><b>15</b>: A failover is being performed.</description></item>
                /// <item><description><b>16</b>: A temporary instance is being created.</description></item>
                /// <item><description><b>17</b>: A network is being created for the ApsaraDB RDS for MySQL instance.</description></item>
                /// <item><description><b>18</b>: The ApsaraDB RDS for MySQL instance is being cloned.</description></item>
                /// <item><description><b>19</b>: The link is being changed.</description></item>
                /// <item><description><b>20</b>: The read-only instances of the ApsaraDB RDS for MySQL instance are being migrated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>Indicates the type of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. The value is set to RDS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RDS</para>
                /// </summary>
                [NameInMap("DbInstType")]
                [Validation(Required=false)]
                public string DbInstType { get; set; }

                /// <summary>
                /// <para>Indicates the ID of a resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dm-hbgau1zp****</para>
                /// </summary>
                [NameInMap("DmInstanceId")]
                [Validation(Required=false)]
                public string DmInstanceId { get; set; }

                /// <summary>
                /// <para>Indicates the engine of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>Indicates the engine version of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>Indicates the point in time when the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1237486127634</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates the network type of the ApsaraDB RDS for MySQL instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>Indicates the billing method of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>drdsPre</b>: The instance uses the subscription billing method.</description></item>
                /// <item><description><b>drdsPost</b>: The instance uses the pay-as-you-go billing method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>Indicates the port that is used to connect to the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>Indicates whether the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database is a primary instance or a read-only instance.</para>
                /// <list type="bullet">
                /// <item><description><b>Primary</b>: The instance is a primary instance.</description></item>
                /// <item><description><b>Readonly</b>: The instance is a read-only instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Primary</para>
                /// </summary>
                [NameInMap("RdsInstType")]
                [Validation(Required=false)]
                public string RdsInstType { get; set; }

                /// <summary>
                /// <para>Indicates information about the read-only instances of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                /// </summary>
                [NameInMap("ReadOnlyInstances")]
                [Validation(Required=false)]
                public DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstances ReadOnlyInstances { get; set; }
                public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstances : TeaModel {
                    [NameInMap("ReadOnlyInstance")]
                    [Validation(Required=false)]
                    public List<DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstancesReadOnlyInstance> ReadOnlyInstance { get; set; }
                    public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstancesReadOnlyInstance : TeaModel {
                        /// <summary>
                        /// <para>Indicates the endpoint that is used to connect to the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rm-bp1t1mk5a5b******.mysql.rds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ConnectUrl")]
                        [Validation(Required=false)]
                        public string ConnectUrl { get; set; }

                        /// <summary>
                        /// <para>Indicates the state of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>0</b>: The ApsaraDB RDS for MySQL instance is being created.</description></item>
                        /// <item><description><b>1</b>: The ApsaraDB RDS for MySQL instance is running.</description></item>
                        /// <item><description><b>3</b>: The ApsaraDB RDS for MySQL instance is being deleted.</description></item>
                        /// <item><description><b>5</b>: The ApsaraDB RDS for MySQL instance is being restarted.</description></item>
                        /// <item><description><b>6</b>: The ApsaraDB RDS for MySQL instance is being upgraded or downgraded.</description></item>
                        /// <item><description><b>7</b>: The ApsaraDB RDS for MySQL instance is being backed up.</description></item>
                        /// <item><description><b>8</b>: The network type of the ApsaraDB RDS for MySQL instance is being changed.</description></item>
                        /// <item><description><b>9</b>: The ApsaraDB RDS for MySQL instance is being migrated.</description></item>
                        /// <item><description><b>11</b>: The data of the ApsaraDB RDS for MySQL instance is being migrated.</description></item>
                        /// <item><description><b>12</b>: A disaster-recovery instance is being generated.</description></item>
                        /// <item><description><b>13</b>: Data is being imported to the ApsaraDB RDS for MySQL instance.</description></item>
                        /// <item><description><b>14</b>: Data is being imported to the ApsaraDB RDS for MySQL instance from an another ApsaraDB RDS for MySQL instance.</description></item>
                        /// <item><description><b>15</b>: A failover is being performed.</description></item>
                        /// <item><description><b>16</b>: A temporary instance is being created.</description></item>
                        /// <item><description><b>17</b>: A network is being created for the ApsaraDB RDS for MySQL instance.</description></item>
                        /// <item><description><b>18</b>: The ApsaraDB RDS for MySQL instance is being cloned.</description></item>
                        /// <item><description><b>19</b>: The link is being changed.</description></item>
                        /// <item><description><b>20</b>: The read-only instances of the ApsaraDB RDS for MySQL instance are being migrated.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("DBInstanceStatus")]
                        [Validation(Required=false)]
                        public string DBInstanceStatus { get; set; }

                        /// <summary>
                        /// <para>Indicates the type of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database. The value is set to RDS.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RDS</para>
                        /// </summary>
                        [NameInMap("DbInstType")]
                        [Validation(Required=false)]
                        public string DbInstType { get; set; }

                        /// <summary>
                        /// <para>Indicates the ID of a resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dm-hbgau1zp****</para>
                        /// </summary>
                        [NameInMap("DmInstanceId")]
                        [Validation(Required=false)]
                        public string DmInstanceId { get; set; }

                        /// <summary>
                        /// <para>Indicates the engine of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MySQL</para>
                        /// </summary>
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        /// <summary>
                        /// <para>Indicates the engine version of the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5.7</para>
                        /// </summary>
                        [NameInMap("EngineVersion")]
                        [Validation(Required=false)]
                        public string EngineVersion { get; set; }

                        /// <summary>
                        /// <para>Indicates the timestamp when the ApsaraDB RDS for MySQL instance that is used to store the data of the specified database expires.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>123421352351234</para>
                        /// </summary>
                        [NameInMap("ExpireTime")]
                        [Validation(Required=false)]
                        public string ExpireTime { get; set; }

                        /// <summary>
                        /// <para>Indicates the name of a read-only instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>**</para>
                        /// </summary>
                        [NameInMap("InstanceName")]
                        [Validation(Required=false)]
                        public string InstanceName { get; set; }

                        /// <summary>
                        /// <para>Indicates the network type of the read-only instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>VPC</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>Indicates the billing method of the read-only instance.</para>
                        /// <list type="bullet">
                        /// <item><description><b>drdsPre</b>: The instance uses the subscription billing method.</description></item>
                        /// <item><description><b>drdsPost</b>: The instance uses the pay-as-you-go billing method.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Postpaid</para>
                        /// </summary>
                        [NameInMap("PayType")]
                        [Validation(Required=false)]
                        public string PayType { get; set; }

                        /// <summary>
                        /// <para>Indicates the port that is used to connect to the read-only instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3306</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>Indicates the type of the read-only instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RDS</para>
                        /// </summary>
                        [NameInMap("RdsInstType")]
                        [Validation(Required=false)]
                        public string RdsInstType { get; set; }

                        /// <summary>
                        /// <para>Indicates the read weight of the read-only instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>70</para>
                        /// </summary>
                        [NameInMap("ReadWeight")]
                        [Validation(Required=false)]
                        public int? ReadWeight { get; set; }

                        /// <summary>
                        /// <para>Indicates the number of remaining days before the read-only instance expires.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("RemainDays")]
                        [Validation(Required=false)]
                        public int? RemainDays { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates the read weight of the read-only instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("ReadWeight")]
                [Validation(Required=false)]
                public int? ReadWeight { get; set; }

                /// <summary>
                /// <para>Indicates the number of remaining days before a subscription instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RemainDays")]
                [Validation(Required=false)]
                public int? RemainDays { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates the page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>Indicates the number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Indicates the ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F7F8080-9132-4279-85D0-B7E5C4305162</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Indicates the number of primary ApsaraDB RDS for MySQL instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
