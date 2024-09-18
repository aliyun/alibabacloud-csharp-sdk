// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListInstancesShrinkRequest : TeaModel {
        [NameInMap("catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        [NameInMap("dataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The description of the instance. You can use this description to filter instances. Fuzzy match is supported.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The instance type. Valid values: vector: OpenSearch Vector Search Edition instance. engine: OpenSearch Retrieval Engine Edition instance.
        /// </summary>
        [NameInMap("edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: 1.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 50. Default value: 10.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        /// <summary>
        /// The tags of the instance.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
