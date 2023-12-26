// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried zones.
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                /// <summary>
                /// This parameter is reserved. You can ignore this parameter.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneCapacity Capacity { get; set; }
                public class DescribeZonesResponseBodyZonesZoneCapacity : TeaModel {
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public List<string> Protocol { get; set; }

                }

                /// <summary>
                /// The details about file system types.
                /// </summary>
                [NameInMap("InstanceTypes")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneInstanceTypes InstanceTypes { get; set; }
                public class DescribeZonesResponseBodyZonesZoneInstanceTypes : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneInstanceTypesInstanceType> InstanceType { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneInstanceTypesInstanceType : TeaModel {
                        /// <summary>
                        /// The protocol type.
                        /// 
                        /// *   If the FileSystemType parameter is set to standard, the protocol type is nfs or smb.
                        /// *   If the FileSystemType parameter is set to extreme, the protocol type is nfs.
                        /// *   If the FileSystemType parameter is set to cpfs, the protocol type is cpfs.
                        /// 
                        /// > CPFS file systems are available only on the China site (aliyun.com).
                        /// </summary>
                        [NameInMap("ProtocolType")]
                        [Validation(Required=false)]
                        public string ProtocolType { get; set; }

                        /// <summary>
                        /// The storage type.
                        /// 
                        /// *   If the FileSystemType parameter is set to standard, the storage type is Performance or Capacity.
                        /// *   If the FileSystemType parameter is set to extreme, the storage type is standard or advance.
                        /// *   If the FileSystemType parameter is set to cpfs, the storage type is advance\_100 (100 MB/s/TiB baseline) or advance\_200 (200 MB/s/TiB baseline).
                        /// 
                        /// > CPFS file systems are available only on the China site (aliyun.com).
                        /// </summary>
                        [NameInMap("StorageType")]
                        [Validation(Required=false)]
                        public string StorageType { get; set; }

                    }

                }

                /// <summary>
                /// This parameter is reserved. You can ignore this parameter.
                /// </summary>
                [NameInMap("Performance")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZonePerformance Performance { get; set; }
                public class DescribeZonesResponseBodyZonesZonePerformance : TeaModel {
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public List<string> Protocol { get; set; }

                }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
