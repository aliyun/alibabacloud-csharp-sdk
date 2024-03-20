// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ModifyClusterOfflineConfigRequest : TeaModel {
        /// <summary>
        /// The mode of reindexing. Valid values: api and indexRecover. api indicates to push incremental data to a data source by calling the API operations. indexRecover indicates that the data source is restored from the index.
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
        /// The type of the data source. Valid values: odps, swift, saro, and unKnow.
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
        /// The domain where the data source is deployed.
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The data restoration version.
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

        [NameInMap("pushMode")]
        [Validation(Required=false)]
        public string PushMode { get; set; }

    }

}
