// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeClassDetailsResponseBody : TeaModel {
        /// <summary>
        /// The RDS edition of the instance. Valid values:
        /// 
        /// *   **Basic**: RDS Basic Edition
        /// *   **HighAvailability**: RDS High-availability Edition
        /// *   **AlwaysOn**: RDS Cluster Edition
        /// *   **Finance**: RDS Enterprise Edition
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The code of the instance type.
        /// </summary>
        [NameInMap("ClassCode")]
        [Validation(Required=false)]
        public string ClassCode { get; set; }

        /// <summary>
        /// The instance family of the instance.
        /// </summary>
        [NameInMap("ClassGroup")]
        [Validation(Required=false)]
        public string ClassGroup { get; set; }

        /// <summary>
        /// The number of CPU cores that are supported by the instance type. Unit: cores.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **local_ssd**: local SSDs
        /// *   **cloud_ssd**: standard SSDs
        /// *   **cloud_essd**: enhanced SSDs (ESSDs) of performance level 1 (PL1)
        /// *   **cloud_essd2**: ESSDs of PL2
        /// *   **cloud_essd3**: ESSD of PL3
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// The architecture of the instance.
        /// </summary>
        [NameInMap("InstructionSetArch")]
        [Validation(Required=false)]
        public string InstructionSetArch { get; set; }

        /// <summary>
        /// The maximum number of connections.
        /// </summary>
        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public string MaxConnections { get; set; }

        /// <summary>
        /// The maximum I/O bandwidth that is supported by the instance type. Unit: Mbit/s.
        /// </summary>
        [NameInMap("MaxIOMBPS")]
        [Validation(Required=false)]
        public string MaxIOMBPS { get; set; }

        /// <summary>
        /// The maximum input/output operations per second (IOPS) that is supported by the instance type. Unit: operations per second.
        /// </summary>
        [NameInMap("MaxIOPS")]
        [Validation(Required=false)]
        public string MaxIOPS { get; set; }

        /// <summary>
        /// The memory size. Unit: GB.
        /// </summary>
        [NameInMap("MemoryClass")]
        [Validation(Required=false)]
        public string MemoryClass { get; set; }

        /// <summary>
        /// The price.
        /// 
        /// Unit: cents (US dollars).
        /// 
        /// > *   If you set the CommodityCode parameter to a value that indicates the pay-as-you-go billing method, the ReferencePrice parameter specifies the hourly fee that you must pay.
        /// > *   If you set the CommodityCode parameter to a value that indicates the subscription billing method, the ReferencePrice parameter specifies the monthly fee that you must pay.
        /// </summary>
        [NameInMap("ReferencePrice")]
        [Validation(Required=false)]
        public string ReferencePrice { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
