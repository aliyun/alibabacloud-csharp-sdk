// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOpEntitiesRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeOpEntities**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The details of the operation log.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The sort order of operation logs. Valid values:
        /// 
        /// *   **ASC**: the ascending order.
        /// *   **DESC**: the descending order.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The ID of the region where the Anti-DDoS Origin instance resides.
        /// 
        /// >  You can call the [DescribeRegions](~~118703~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("OrderDir")]
        [Validation(Required=false)]
        public string OrderDir { get; set; }

        /// <summary>
        /// The type of the operation object. The value is fixed as **1**, which indicates Anti-DDoS Origin instances.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account that performs the operation.
        /// 
        /// >  If the value is **system**, the operation is performed by Anti-DDoS Origin.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The details about the operation. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:
        /// 
        /// *   **entity**: the operation object. Data type: object. The fields that are included in the value of the **entity** parameter vary based on the value of the **OpAction** parameter. Take note of the following items:
        /// 
        ///     *   If the value of the **OpAction** parameter is **3**, the value of the **entity** parameter consists of the following field:
        /// 
        ///         *   **ips**: the public IP addresses that are protected by the Anti-DDoS Origin instance. Data type: array
        /// 
        ///     *   If the value of the **OpAction** parameter is **4**, the value of the **entity** parameter consists of the following field:
        /// 
        ///         *   **ips**: the public IP addresses that are no longer protected by the Anti-DDoS Origin instance. Data type: array.
        /// 
        ///     *   If the value of the **OpAction** parameter is **5**, the value of the **entity** parameter consists of the following fields:
        /// 
        ///         *   **baseBandwidth**: the basic protection bandwidth. Unit: Gbit/s. Data type: integer.
        ///         *   **elasticBandwidth**: the burstable protection bandwidth. Unit: Gbit/s. Data type: integer.
        ///         *   **opSource**: the source of the operation. The value is fixed as **1**, indicating that the operation is performed by Anti-DDoS Origin. Data type: integer.
        /// 
        ///     *   If the value of the **OpAction** parameter is **6**, the value of the **entity** parameter consists of the following field:
        /// 
        ///         *   **ips**: the public IP addresses for which to deactivate blackhole filtering. Data type: array.
        /// 
        ///     *   If the value of the **OpAction** parameter is **7**, the **entity** parameter is not returned.
        /// 
        ///     *   If the value of the **OpAction** parameter is **8**, the value of the **entity** parameter consists of the following fields:
        /// 
        ///         *   **baseBandwidth**: the basic protection bandwidth. Unit: Gbit/s. Data type: integer.
        ///         *   **elasticBandwidth**: the burstable protection bandwidth. Unit: Gbit/s. Data type: integer.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The sorting method of operation logs. Set the value to **opdate**, which indicates sorting based on the operation time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
