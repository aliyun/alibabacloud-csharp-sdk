// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateTairInstanceResponseBody : TeaModel {
        /// <summary>
        /// The maximum bandwidth of the instance. Unit: MB/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The detailed configurations of the instance. The value is a JSON string. For more information about the parameter description, see [Modify the parameters of an ApsaraDB for Redis instance](~~43885~~).
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The internal endpoint of the instance.
        /// </summary>
        [NameInMap("ConnectionDomain")]
        [Validation(Required=false)]
        public string ConnectionDomain { get; set; }

        /// <summary>
        /// The maximum number of connections supported by the instance.
        /// </summary>
        [NameInMap("Connections")]
        [Validation(Required=false)]
        public long? Connections { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the instance.
        /// 
        /// **
        /// 
        /// This parameter is returned only if the **InstanceName** parameter is specified in the request.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The state of the instance. The return value is **Creating**.
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The port number that is used to connect to the instance.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The maximum number of read and write operations that can be processed by the instance per second. The value is a theoretical value.
        /// </summary>
        [NameInMap("QPS")]
        [Validation(Required=false)]
        public long? QPS { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The zone ID of the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
