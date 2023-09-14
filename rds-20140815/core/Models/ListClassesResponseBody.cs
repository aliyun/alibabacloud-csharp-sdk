// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListClassesResponseBody : TeaModel {
        /// <summary>
        /// The list of instance specifications.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListClassesResponseBodyItems> Items { get; set; }
        public class ListClassesResponseBodyItems : TeaModel {
            /// <summary>
            /// The code of the instance type. For more information, see [Primary ApsaraDB RDS instance types](~~26312~~) and [Read-only ApsaraDB RDS instance types](~~145759~~).
            /// </summary>
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            /// <summary>
            /// The instance family. For more information, see [Overview of instance families](~~57184~~).
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
            /// The size of the encrypted memory that is supported by the security-enhanced instance type. Unit: GB.
            /// </summary>
            [NameInMap("EncryptedMemory")]
            [Validation(Required=false)]
            public string EncryptedMemory { get; set; }

            /// <summary>
            /// The architecture of the instance type. Valid values:
            /// 
            /// *   If the architecture of the instance type is **x86**, an empty string is returned by default.
            /// *   If the architecture of the instance type is **ARM**, **arm** is returned.
            /// </summary>
            [NameInMap("InstructionSetArch")]
            [Validation(Required=false)]
            public string InstructionSetArch { get; set; }

            /// <summary>
            /// The maximum number of connections that are supported by the instance type. Unit: connections.
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
            /// The memory size that is supported by the instance type. Unit: GB.
            /// </summary>
            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            /// <summary>
            /// The fee that you must pay for the instance type.
            /// 
            /// *   Unit: cents (USD).
            /// 
            /// > 
            /// 
            /// *   If you set **CommodityCode** to a value that indicates the pay-as-you-go billing method, the ReferencePrice parameter specifies the hourly fee that you must pay.
            /// 
            /// *   If you set **CommodityCode** to a value that indicates the subscription billing method, the ReferencePrice parameter specifies the monthly fee that you must pay.
            /// </summary>
            [NameInMap("ReferencePrice")]
            [Validation(Required=false)]
            public string ReferencePrice { get; set; }

        }

        /// <summary>
        /// The ID of the region.
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

    }

}
