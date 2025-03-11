// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the returned custom ApsaraDB RDS for MySQL instance.</para>
        /// </summary>
        [NameInMap("DbInstance")]
        [Validation(Required=false)]
        public DescribeDrdsDbInstanceResponseBodyDbInstance DbInstance { get; set; }
        public class DescribeDrdsDbInstanceResponseBodyDbInstance : TeaModel {
            /// <summary>
            /// <para>The URL used to connect to the custom ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-***************.mysql.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ConnectUrl")]
            [Validation(Required=false)]
            public string ConnectUrl { get; set; }

            /// <summary>
            /// <para>The ID of the ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-***************</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The state of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DBInstanceStatus")]
            [Validation(Required=false)]
            public string DBInstanceStatus { get; set; }

            /// <summary>
            /// <para>The role of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Primary</b>: The instance is a primary instance.</description></item>
            /// <item><description><b>ReadOnly</b>: The instance is a read-only instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Primary</para>
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
            /// <para>The engine of the database that is run on the instance. Valid value: <b>MySQL</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The engine version of the database that is run on the instance. Valid values: <b>5.7</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The time when the custom ApsaraDB RDS for MySQL instance expires. The value of this parameter is a UNIX timestamp. Unit: seconds.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the custom ApsaraDB RDS for MySQL instance is a subscription instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>12341434315</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The type of the network. Valid values: <b>VPC</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The billing method of the custom ApsaraDB RDS for MySQL instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Prepaid</b>: subscription</description></item>
            /// <item><description><b>Postaid</b>: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The port used to connect to the custom ApsaraDB RDS for MySQL instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("RdsInstType")]
            [Validation(Required=false)]
            public string RdsInstType { get; set; }

            /// <summary>
            /// <para>The list of read-only ApsaraDB RDS for MySQL instances.</para>
            /// </summary>
            [NameInMap("ReadOnlyInstances")]
            [Validation(Required=false)]
            public DescribeDrdsDbInstanceResponseBodyDbInstanceReadOnlyInstances ReadOnlyInstances { get; set; }
            public class DescribeDrdsDbInstanceResponseBodyDbInstanceReadOnlyInstances : TeaModel {
                [NameInMap("ReadOnlyInstance")]
                [Validation(Required=false)]
                public List<DescribeDrdsDbInstanceResponseBodyDbInstanceReadOnlyInstancesReadOnlyInstance> ReadOnlyInstance { get; set; }
                public class DescribeDrdsDbInstanceResponseBodyDbInstanceReadOnlyInstancesReadOnlyInstance : TeaModel {
                    /// <summary>
                    /// <para>The URL used to connect to the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-bp1ub71ct9skc3yxx.mysql.rds.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("ConnectUrl")]
                    [Validation(Required=false)]
                    public string ConnectUrl { get; set; }

                    /// <summary>
                    /// <para>The ID of the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-bp1ub71ct9skc****</para>
                    /// </summary>
                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                    /// <summary>
                    /// <para>The state of the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DBInstanceStatus")]
                    [Validation(Required=false)]
                    public string DBInstanceStatus { get; set; }

                    /// <summary>
                    /// <para>The role of the read-only instance.</para>
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
                    /// <para>The engine of the database that is run on the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// <para>The engine version of the database that is run on the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.7</para>
                    /// </summary>
                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    /// <summary>
                    /// <para>The timestamp that indicates when the read-only instance expires.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1823487328173</para>
                    /// </summary>
                    [NameInMap("ExpireTime")]
                    [Validation(Required=false)]
                    public string ExpireTime { get; set; }

                    /// <summary>
                    /// <para>The network type of the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// <para>The billing method of the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Postpaid</para>
                    /// </summary>
                    [NameInMap("PayType")]
                    [Validation(Required=false)]
                    public string PayType { get; set; }

                    /// <summary>
                    /// <para>The port used to connect to the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The type of the ApsaraDB RDS for MySQL instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RDS</para>
                    /// </summary>
                    [NameInMap("RdsInstType")]
                    [Validation(Required=false)]
                    public string RdsInstType { get; set; }

                    /// <summary>
                    /// <para>The read ratio of the read-only instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("ReadWeight")]
                    [Validation(Required=false)]
                    public int? ReadWeight { get; set; }

                    /// <summary>
                    /// <para>The number of remaining days before the read-only instance expires.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("RemainDays")]
                    [Validation(Required=false)]
                    public string RemainDays { get; set; }

                    /// <summary>
                    /// <para>This parameter is unavailable for read-only instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("VersionAction")]
                    [Validation(Required=false)]
                    public int? VersionAction { get; set; }

                }

            }

            /// <summary>
            /// <para>The read ratio of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("ReadWeight")]
            [Validation(Required=false)]
            public int? ReadWeight { get; set; }

            /// <summary>
            /// <para>The number of remaining days before the instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public string RemainDays { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FE09970-CA69-4144-88CA-67FB4BTY56G3</para>
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

    }

}
