// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbInstanceResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about the returned custom ApsaraDB RDS for MySQL instance.
        /// </summary>
        [NameInMap("DbInstance")]
        [Validation(Required=false)]
        public DescribeDrdsDbInstanceResponseBodyDbInstance DbInstance { get; set; }
        public class DescribeDrdsDbInstanceResponseBodyDbInstance : TeaModel {
            /// <summary>
            /// The URL used to connect to the custom ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("ConnectUrl")]
            [Validation(Required=false)]
            public string ConnectUrl { get; set; }

            /// <summary>
            /// The ID of the ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The state of the instance.
            /// </summary>
            [NameInMap("DBInstanceStatus")]
            [Validation(Required=false)]
            public string DBInstanceStatus { get; set; }

            /// <summary>
            /// The role of the instance. Valid values:
            /// 
            /// *   **Primary**: The instance is a primary instance.
            /// *   **ReadOnly**: The instance is a read-only instance.
            /// </summary>
            [NameInMap("DbInstType")]
            [Validation(Required=false)]
            public string DbInstType { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("DmInstanceId")]
            [Validation(Required=false)]
            public string DmInstanceId { get; set; }

            /// <summary>
            /// The engine of the database that is run on the instance. Valid value: **MySQL**.
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// The engine version of the database that is run on the instance. Valid values: **5.7**.
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// The time when the custom ApsaraDB RDS for MySQL instance expires. The value of this parameter is a UNIX timestamp. Unit: seconds.
            /// 
            /// >  This parameter is returned only when the custom ApsaraDB RDS for MySQL instance is a subscription instance.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The type of the network. Valid values: **VPC**.
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// The billing method of the custom ApsaraDB RDS for MySQL instance. Valid values:
            /// 
            /// *   **Prepaid**: subscription
            /// *   **Postaid**: pay-as-you-go
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The port used to connect to the custom ApsaraDB RDS for MySQL instance.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The type of the instance.
            /// </summary>
            [NameInMap("RdsInstType")]
            [Validation(Required=false)]
            public string RdsInstType { get; set; }

            /// <summary>
            /// The list of read-only ApsaraDB RDS for MySQL instances.
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
                    /// The URL used to connect to the read-only instance.
                    /// </summary>
                    [NameInMap("ConnectUrl")]
                    [Validation(Required=false)]
                    public string ConnectUrl { get; set; }

                    /// <summary>
                    /// The ID of the read-only instance.
                    /// </summary>
                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

                    /// <summary>
                    /// The state of the read-only instance.
                    /// </summary>
                    [NameInMap("DBInstanceStatus")]
                    [Validation(Required=false)]
                    public string DBInstanceStatus { get; set; }

                    /// <summary>
                    /// The role of the read-only instance.
                    /// </summary>
                    [NameInMap("DbInstType")]
                    [Validation(Required=false)]
                    public string DbInstType { get; set; }

                    /// <summary>
                    /// The ID of the resource.
                    /// </summary>
                    [NameInMap("DmInstanceId")]
                    [Validation(Required=false)]
                    public string DmInstanceId { get; set; }

                    /// <summary>
                    /// The engine of the database that is run on the read-only instance.
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// The engine version of the database that is run on the read-only instance.
                    /// </summary>
                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    /// <summary>
                    /// The timestamp that indicates when the read-only instance expires.
                    /// </summary>
                    [NameInMap("ExpireTime")]
                    [Validation(Required=false)]
                    public string ExpireTime { get; set; }

                    /// <summary>
                    /// The network type of the read-only instance.
                    /// </summary>
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// The billing method of the read-only instance.
                    /// </summary>
                    [NameInMap("PayType")]
                    [Validation(Required=false)]
                    public string PayType { get; set; }

                    /// <summary>
                    /// The port used to connect to the read-only instance.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The type of the ApsaraDB RDS for MySQL instance.
                    /// </summary>
                    [NameInMap("RdsInstType")]
                    [Validation(Required=false)]
                    public string RdsInstType { get; set; }

                    /// <summary>
                    /// The read ratio of the read-only instance.
                    /// </summary>
                    [NameInMap("ReadWeight")]
                    [Validation(Required=false)]
                    public int? ReadWeight { get; set; }

                    /// <summary>
                    /// The number of remaining days before the read-only instance expires.
                    /// </summary>
                    [NameInMap("RemainDays")]
                    [Validation(Required=false)]
                    public string RemainDays { get; set; }

                    /// <summary>
                    /// This parameter is unavailable for read-only instances.
                    /// </summary>
                    [NameInMap("VersionAction")]
                    [Validation(Required=false)]
                    public int? VersionAction { get; set; }

                }

            }

            /// <summary>
            /// The read ratio of the instance.
            /// </summary>
            [NameInMap("ReadWeight")]
            [Validation(Required=false)]
            public int? ReadWeight { get; set; }

            /// <summary>
            /// The number of remaining days before the instance expires.
            /// </summary>
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public string RemainDays { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
