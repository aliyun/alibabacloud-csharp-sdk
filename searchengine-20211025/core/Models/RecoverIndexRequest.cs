// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class RecoverIndexRequest : TeaModel {
        /// <summary>
        /// buildDeployId
        /// </summary>
        [NameInMap("buildDeployId")]
        [Validation(Required=false)]
        public int? BuildDeployId { get; set; }

        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// generation
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public string Generation { get; set; }

        [NameInMap("indexName")]
        [Validation(Required=false)]
        public string IndexName { get; set; }

    }

}
