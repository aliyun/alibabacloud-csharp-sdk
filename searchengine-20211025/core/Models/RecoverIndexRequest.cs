// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class RecoverIndexRequest : TeaModel {
        /// <summary>
        /// The deployment ID of the data source.
        /// </summary>
        [NameInMap("buildDeployId")]
        [Validation(Required=false)]
        public int? BuildDeployId { get; set; }

        /// <summary>
        /// The name of the data source.
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// The ID of the full index version.
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public string Generation { get; set; }

        /// <summary>
        /// The index name.
        /// </summary>
        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

    }

}
