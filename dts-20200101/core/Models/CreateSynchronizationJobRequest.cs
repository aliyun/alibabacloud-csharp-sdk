// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateSynchronizationJobRequest : TeaModel {
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public CreateSynchronizationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class CreateSynchronizationJobRequestDestinationEndpoint : TeaModel {
            /// <summary>
            /// The instance type of the destination database. Valid values:
            /// 
            /// *   **MySQL**: ApsaraDB RDS for MySQL instance or self-managed MySQL database
            /// *   **PolarDB**: PolarDB for MySQL cluster or PolarDB O Edition cluster
            /// *   **Redis**: Redis database
            /// *   **MaxCompute**: MaxCompute project
            /// 
            /// > 
            /// *   Default value: **MySQL**.
            /// *   For more information about the supported source and destination databases, see [Database types, initial synchronization types, and synchronization topologies](https://help.aliyun.com/document_detail/130744.html).
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public CreateSynchronizationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class CreateSynchronizationJobRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// The instance type of the source database. Valid values:
            /// 
            /// *   **MySQL**: ApsaraDB RDS for MySQL instance or self-managed MySQL database
            /// *   **PolarDB**: PolarDB for MySQL cluster or PolarDB O Edition cluster
            /// *   **Redis**: Redis database
            /// *   **DRDS**: PolarDB-X instance V1.0
            /// 
            /// > 
            /// *   Default value: **MySQL**.
            /// *   For more information about the supported source and destination databases, see [Database types, initial synchronization types, and synchronization topologies](https://help.aliyun.com/document_detail/130744.html).
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The **ClientToken** parameter can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// If you set the **SourceEndpoint.InstanceType** parameter to **DRDS**, you must specify the DBInstanceCount parameter. This parameter specifies the number of private RDS instances attached to the source PolarDB-X instance. Default value: **1**.
        /// </summary>
        [NameInMap("DBInstanceCount")]
        [Validation(Required=false)]
        public int? DBInstanceCount { get; set; }

        /// <summary>
        /// The ID of the region where the destination database resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// 
        /// >  If the **SourceRegion** parameter is set to the China (Hong Kong) region or a region outside the Chinese mainland, you must set the DestRegion parameter to the same region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The billing method of the data synchronization instance.
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid** (default value): pay-as-you-go
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The billing cycle of the subscription instance. Valid values:
        /// 
        /// *   **Year**
        /// *   **Month**
        /// 
        /// >  You must specify this parameter only if you set the PayType parameter to **PrePaid**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the source database resides. For more information, see [List of supported regions](https://help.aliyun.com/document_detail/141033.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// The specification of the data synchronization instance. Valid values: **micro**, **small**, **medium**, and **large**.
        /// 
        /// >  For more information about the test performance of each specification, see [Specifications of data synchronization instances](https://help.aliyun.com/document_detail/26605.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SynchronizationJobClass")]
        [Validation(Required=false)]
        public string SynchronizationJobClass { get; set; }

        /// <summary>
        /// The synchronization topology. Valid values:
        /// 
        /// *   **oneway**: one-way synchronization
        /// *   **bidirectional**: two-way synchronization
        /// 
        /// > 
        /// *   The default value is **oneway**.
        /// *   This parameter can be set to **bidirectional** only when the **SourceEndpoint.InstanceType** and **DestinationEndpoint.InstanceType** parameters are set to **MySQL**, **PolarDB**, or **Redis**.
        /// </summary>
        [NameInMap("Topology")]
        [Validation(Required=false)]
        public string Topology { get; set; }

        /// <summary>
        /// The subscription length.
        /// 
        /// *   If the billing cycle is **Year**, the value range is **1 to 5**.
        /// *   If the billing cycle is **Month**, the value range is **1 to 60**.
        /// 
        /// >  You must specify this parameter only if you set the PayType parameter to **PrePaid**.
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// The network type. Valid value: **Intranet**, which indicates virtual private cloud (VPC).
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

    }

}
