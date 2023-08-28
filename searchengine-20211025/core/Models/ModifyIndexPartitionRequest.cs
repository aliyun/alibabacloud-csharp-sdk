// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyIndexPartitionRequest : TeaModel {
        /// <summary>
        /// The name of the data source.
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The information about each index.
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The name of the data center.
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public long? Generation { get; set; }

        /// <summary>
        /// The number of shards of the index.
        /// </summary>
        [NameInMap("indexInfos")]
        [Validation(Required=false)]
        public List<ModifyIndexPartitionRequestIndexInfos> IndexInfos { get; set; }
        public class ModifyIndexPartitionRequestIndexInfos : TeaModel {
            /// <summary>
            /// auditing
            /// </summary>
            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            /// <summary>
            /// The parameters in the request body.
            /// </summary>
            [NameInMap("parallelNum")]
            [Validation(Required=false)]
            public int? ParallelNum { get; set; }

            /// <summary>
            /// The number of shards of the index.
            /// </summary>
            [NameInMap("partitionCount")]
            [Validation(Required=false)]
            public int? PartitionCount { get; set; }

        }

    }

}
