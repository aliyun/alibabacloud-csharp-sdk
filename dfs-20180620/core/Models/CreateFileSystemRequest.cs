// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class CreateFileSystemRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>LRS</para>
        /// </summary>
        [NameInMap("DataRedundancyType")]
        [Validation(Required=false)]
        public string DataRedundancyType { get; set; }

        [NameInMap("DedicatedClusterId")]
        [Validation(Required=false)]
        public string DedicatedClusterId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyFirstHDFS</para>
        /// </summary>
        [NameInMap("FileSystemName")]
        [Validation(Required=false)]
        public string FileSystemName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PartitionNumber")]
        [Validation(Required=false)]
        public int? PartitionNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("SpaceCapacity")]
        [Validation(Required=false)]
        public long? SpaceCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AligroupStorageSet</para>
        /// </summary>
        [NameInMap("StorageSetName")]
        [Validation(Required=false)]
        public string StorageSetName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
