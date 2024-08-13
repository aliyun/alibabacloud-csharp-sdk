// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOpEntitiesResponseBody : TeaModel {
        /// <summary>
        /// The details of the operation log.
        /// </summary>
        [NameInMap("OpEntities")]
        [Validation(Required=false)]
        public List<DescribeOpEntitiesResponseBodyOpEntities> OpEntities { get; set; }
        public class DescribeOpEntitiesResponseBodyOpEntities : TeaModel {
            /// <summary>
            /// The operation object, which is the ID of the instance.
            /// </summary>
            [NameInMap("EntityObject")]
            [Validation(Required=false)]
            public string EntityObject { get; set; }

            /// <summary>
            /// The type of the operation object. The value is fixed as **1**, which indicates Anti-DDoS Origin instances.
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public int? EntityType { get; set; }

            /// <summary>
            /// The time when the log was generated. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that performs the operation.
            /// 
            /// > If the value is **system**, the operation is performed by Anti-DDoS Origin.
            /// </summary>
            [NameInMap("OpAccount")]
            [Validation(Required=false)]
            public string OpAccount { get; set; }

            /// <summary>
            /// The type of operation. Valid values:
            /// 
            /// *   **3**: indicates an operation to add an IP address to the Anti-DDoS Origin instance for protection.
            /// *   **4**: indicates an operation to remove a protected IP address from the Anti-DDoS Origin instance.
            /// *   **5**: indicates an operation to downgrade the Anti-DDoS Origin instance.
            /// *   **6**: indicates an operation to deactivate blackhole filtering for an IP address.
            /// *   **7**: indicates an operation to reset the number of times that you can deactivate blackhole filtering.
            /// *   **8**: indicates an operation to enable burstable protection.
            /// </summary>
            [NameInMap("OpAction")]
            [Validation(Required=false)]
            public int? OpAction { get; set; }

            /// <summary>
            /// The details of the operation. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:
            /// 
            /// *   **entity**: the operation object. Data type: object. The fields that are included in the value of the **entity** parameter vary based on the value of the **OpAction** parameter. Valid values:
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
            [NameInMap("OpDesc")]
            [Validation(Required=false)]
            public string OpDesc { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of operation logs.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
