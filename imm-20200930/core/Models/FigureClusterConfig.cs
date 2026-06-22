// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FigureClusterConfig : TeaModel {
        /// <summary>
        /// <para>Whether to automatically group similar figures into clusters.</para>
        /// </summary>
        [NameInMap("AutoClustering")]
        [Validation(Required=false)]
        public bool? AutoClustering { get; set; }

        /// <summary>
        /// <para>Whether to automatically generate metadata for each cluster, such as a representative cover image.</para>
        /// </summary>
        [NameInMap("AutoGenerate")]
        [Validation(Required=false)]
        public bool? AutoGenerate { get; set; }

        /// <summary>
        /// <para>An array of strings specifying the clustering strategies to use.</para>
        /// </summary>
        [NameInMap("EnabledFeatures")]
        [Validation(Required=false)]
        public List<string> EnabledFeatures { get; set; }

        /// <summary>
        /// <para>The minimum number of figures required to form a cluster.</para>
        /// </summary>
        [NameInMap("MinEntityCount")]
        [Validation(Required=false)]
        public long? MinEntityCount { get; set; }

    }

}
