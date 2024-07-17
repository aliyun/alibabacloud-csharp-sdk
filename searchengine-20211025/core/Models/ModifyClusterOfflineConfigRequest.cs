// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyClusterOfflineConfigRequest : TeaModel {
        /// <summary>
        /// The reindexing method. Valid values: api: API data source. indexRecover: data recovery by using indexing.
        /// </summary>
        [NameInMap("buildMode")]
        [Validation(Required=false)]
        public string BuildMode { get; set; }

        /// <summary>
        /// The configuration name, which is stored as a key.
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, int?> Config { get; set; }

        /// <summary>
        /// The name of the data source.
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The type of the data source. Valid values: odps: MaxCompute. swift: Swift. unKnow: unknown type.
        /// </summary>
        [NameInMap("dataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// This parameter is required when index building by using API data sources is triggered.
        /// </summary>
        [NameInMap("dataTimeSec")]
        [Validation(Required=false)]
        public int? DataTimeSec { get; set; }

        /// <summary>
        /// The data center in which the data source is deployed.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the full index version.
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public long? Generation { get; set; }

        /// <summary>
        /// This parameter is required when index building for full data in a MaxCompute data source is triggered.
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// The push mode of the configuration. By default, only the configuration is pushed.
        /// </summary>
        [NameInMap("pushMode")]
        [Validation(Required=false)]
        public string PushMode { get; set; }

    }

}
