// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class AllocateReadWriteSplittingConnectionRequest : TeaModel {
        /// <summary>
        /// The prefix of the read-only routing endpoint. The prefix must be unique. It can be up to 30 characters in length and can contain lowercase letters and hyphens (-). It must start with a lowercase letter.
        /// 
        /// >  The default prefix consists of the name of the primary instance followed by the letters rw.
        /// </summary>
        [NameInMap("ConnectionStringPrefix")]
        [Validation(Required=false)]
        public string ConnectionStringPrefix { get; set; }

        /// <summary>
        /// The primary instance ID. You can call the DescribeDBInstances operation to query the primary instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The method that is used to assign read weights. Valid values:
        /// 
        /// *   **Standard**: The system automatically assigns read weights to the primary and read-only instances based on the specifications of these instances.
        /// *   **Custom**: You must manually assign a read weight to each instance.
        /// </summary>
        [NameInMap("DistributionType")]
        [Validation(Required=false)]
        public string DistributionType { get; set; }

        /// <summary>
        /// The threshold of the latency that is allowed on the read-only instances. Valid values: 0 to 7200. Default value: 30. Unit: seconds.
        /// 
        /// >  If the latency on a read-only instance exceeds the specified threshold, ApsaraDB RDS does not forward read requests to the read-only instance.
        /// </summary>
        [NameInMap("MaxDelayTime")]
        [Validation(Required=false)]
        public string MaxDelayTime { get; set; }

        /// <summary>
        /// The network type of the read-only routing endpoint. Valid values:
        /// 
        /// *   **Internet**
        /// *   **Intranet**
        /// 
        /// >  The default value is Intranet. Make sure that the network type of the read-only routing endpoint is the same as that of the primary instance.
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The port that is associated with the read-only routing endpoint. Valid values: 1000 to 5999. Default value: 1433.
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
        /// The read weights of the primary instance and its read-only instances. The read weight is increased in increments of 100. The maximum value is 10000.
        /// 
        /// *   For ApsaraDB RDS instances, the value of this parameter is in the following format: `{"<ID of the read-only instance >":<Weight>,"master":<Weight>,"slave":<Weight>}`.
        /// *   For ApsaraDB MyBase instances, the value of this parameter is in the following format: `[{"instanceName":"<Primary instance ID>","weight":<Weight>,"role":"master"},{"instanceName":"<Primary instance ID>","weight":<Weight>,"role":"slave"},{"instanceName":"<Read-only instance ID>","weight":<Weight>,"role":"master"}]`
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
