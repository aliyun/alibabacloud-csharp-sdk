// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListFileSystemsResponseBody : TeaModel {
        [NameInMap("FileSystems")]
        [Validation(Required=false)]
        public List<ListFileSystemsResponseBodyFileSystems> FileSystems { get; set; }
        public class ListFileSystemsResponseBodyFileSystems : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MyFirstHDFS</para>
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>107374182400</para>
            /// </summary>
            [NameInMap("MeteringSpaceSize")]
            [Validation(Required=false)]
            public float? MeteringSpaceSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MountPointCount")]
            [Validation(Required=false)]
            public long? MountPointCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NumberOfDirectories")]
            [Validation(Required=false)]
            public long? NumberOfDirectories { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("NumberOfFiles")]
            [Validation(Required=false)]
            public long? NumberOfFiles { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HDFS</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ProvisionedThroughputInMiBps")]
            [Validation(Required=false)]
            public long? ProvisionedThroughputInMiBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("SpaceCapacity")]
            [Validation(Required=false)]
            public long? SpaceCapacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StoragePackageId")]
            [Validation(Required=false)]
            public string StoragePackageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("ThroughputMode")]
            [Validation(Required=false)]
            public string ThroughputMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("UsedSpaceSize")]
            [Validation(Required=false)]
            public float? UsedSpaceSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
