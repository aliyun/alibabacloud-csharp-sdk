// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListAdvanceConfigsRequest : TeaModel {
        /// <summary>
        /// The name of the data source.
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The index name.
        /// </summary>
        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

        /// <summary>
        /// Specifies whether the OpenSearch Vector Search Edition instance is of the new version.
        /// </summary>
        [NameInMap("newMode")]
        [Validation(Required=false)]
        public bool? NewMode { get; set; }

        /// <summary>
        /// The type of advanced configurations that you want to query. Valid values: - online -offline (default)
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
