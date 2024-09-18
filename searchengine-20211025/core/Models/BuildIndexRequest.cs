// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class BuildIndexRequest : TeaModel {
        /// <summary>
        /// The reindexing method. Valid values: api: API data source. indexRecover: data recovery by using indexing.
        /// </summary>
        [NameInMap("buildMode")]
        [Validation(Required=false)]
        public string BuildMode { get; set; }

        /// <summary>
        /// The name of the data source.
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The type of the data source.
        /// </summary>
        [NameInMap("dataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// The timestamp in seconds. The value must be of the INTEGER type. This parameter is required if you specify an API data source.
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
        /// The data restoration version.
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public long? Generation { get; set; }

        /// <summary>
        /// The partition in the MaxCompute table. This parameter is required if type is set to odps.
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
