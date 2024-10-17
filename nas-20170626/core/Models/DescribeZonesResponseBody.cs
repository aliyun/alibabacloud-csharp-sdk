// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A70BEE5D-76D3-49FB-B58F-1F398211****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried zones.</para>
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
                /// <para>This parameter is reserved. You can ignore this parameter.</para>
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
                /// <para>The details about file system types.</para>
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
                        /// <para>The protocol type.</para>
                        /// <list type="bullet">
                        /// <item><description>If the FileSystemType parameter is set to standard, the protocol type is nfs or smb.</description></item>
                        /// <item><description>If the FileSystemType parameter is set to extreme, the protocol type is nfs.</description></item>
                        /// <item><description>If the FileSystemType parameter is set to cpfs, the protocol type is cpfs.</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>CPFS file systems are available only on the China site (aliyun.com).</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>nfs</para>
                        /// </summary>
                        [NameInMap("ProtocolType")]
                        [Validation(Required=false)]
                        public string ProtocolType { get; set; }

                        /// <summary>
                        /// <para>The storage type.</para>
                        /// <list type="bullet">
                        /// <item><description>If the FileSystemType parameter is set to standard, the storage type is Performance or Capacity.</description></item>
                        /// <item><description>If the FileSystemType parameter is set to extreme, the storage type is standard or advance.</description></item>
                        /// <item><description>If the FileSystemType parameter is set to cpfs, the storage type is advance_100 (100 MB/s/TiB baseline) or advance_200 (200 MB/s/TiB baseline).</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para>CPFS file systems are available only on the China site (aliyun.com).</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Capacity</para>
                        /// </summary>
                        [NameInMap("StorageType")]
                        [Validation(Required=false)]
                        public string StorageType { get; set; }

                    }

                }

                /// <summary>
                /// <para>This parameter is reserved. You can ignore this parameter.</para>
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
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
