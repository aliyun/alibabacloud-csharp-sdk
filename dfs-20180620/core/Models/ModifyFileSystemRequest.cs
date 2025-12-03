// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ModifyFileSystemRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MyFirstModDFS</para>
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
        /// <para>1024</para>
        /// </summary>
        [NameInMap("ProvisionedThroughputInMiBps")]
        [Validation(Required=false)]
        public long? ProvisionedThroughputInMiBps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("SpaceCapacity")]
        [Validation(Required=false)]
        public long? SpaceCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ThroughputMode")]
        [Validation(Required=false)]
        public string ThroughputMode { get; set; }

    }

}
