// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyClusterOfflineConfigRequest : TeaModel {
        /// <summary>
        /// The reindexing method. Valid values: api: API data source. indexRecover: data recovery through indexing.
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
        [NameInMap("dataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// The type of the data source. Valid values: odps: MaxCompute. swift: Swift. unKnow: unknown type.
        /// </summary>
        [NameInMap("dataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// This parameter is required if the API data source experiences full indexing.
        /// </summary>
        [NameInMap("dataTimeSec")]
        [Validation(Required=false)]
        public int? DataTimeSec { get; set; }

        /// <summary>
        /// The domain in which the data source is deployed.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the backward data delivery.
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public long? Generation { get; set; }

        /// <summary>
        /// This parameter is required if the MaxCompute data source experiences full indexing.
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// Specifies whether to trigger reindexing.
        /// 
        /// *   true: synchronizes the configuration and triggers reindexing.
        /// *   false: waits for the configuration to take effect next time when reindexing is triggered.
        /// </summary>
        [NameInMap("triggerBuild")]
        [Validation(Required=false)]
        public bool? TriggerBuild { get; set; }

    }

}
