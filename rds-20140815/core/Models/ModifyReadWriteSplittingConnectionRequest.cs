// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyReadWriteSplittingConnectionRequest : TeaModel {
        /// <summary>
        /// The prefix of the read/write splitting endpoint. The prefix must be unique. It can be up to 30 characters in length and can contain lowercase letters and hyphens (-). It must start with a lowercase letter.
        /// 
        /// > The default prefix consists of the name of the primary instance followed by the letters rw.
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The ID of the primary instance. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The method that is used to assign read weights. Valid values:
        /// 
        /// *   **Standard**: The system automatically assigns read weights to the primary and read-only instances based on the specifications of these instances.
        /// *   **Custom**: You must manually assign a read weight to each instance.
        /// 
        /// > You must specify at least one of **MaxDelayTime** and **DistributionType**.
        /// </summary>
        [NameInMap("DistributionType")]
        [Validation(Required=false)]
        public string DistributionType { get; set; }

        /// <summary>
        /// The latency threshold that is allowed by the read/write splitting link. Unit: seconds. If the latency on a read-only instance exceeds the specified threshold, the system no longer routes read requests to the read-only instance. If you do not specify this parameter, the default value of this parameter is retained.
        /// 
        /// > *   If the primary instance runs SQL Server 2017 on RDS Cluster Edition, the **MaxDelayTime** parameter is not supported.
        /// > *   You must specify at least one of **MaxDelayTime** and **DistributionType**.
        /// </summary>
        [NameInMap("MaxDelayTime")]
        [Validation(Required=false)]
        public string MaxDelayTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The port that is associated with the read/write splitting endpoint.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The read weights of the primary instance and its read-only instances. A read weight must be a multiple of 100 and cannot exceed 10,000.
        /// 
        /// *   For ApsaraDB RDS instances, the value of this parameter is in the following format: `{"<ID of the read-only instance >":<Weight>,"master":<Weight>,"slave":<Weight>}`.
        /// *   For ApsaraDB MyBase instances, the value of this parameter is in the following format: `[{"instanceName":"<ID of the primary instance>","weight":<Weight>,"role":"master"},{"instanceName":"<ID of the primary instance>","weight":<Weight>,"role":"slave"},{"instanceName":"<ID of the read-only instance>","weight":<Weight>,"role":"master"}]`
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified when **DistributionType** is set to **Custom**.
        /// 
        /// *   If **DistributionType** is set to **Standard**, this parameter is invalid.
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public string Weight { get; set; }

    }

}
