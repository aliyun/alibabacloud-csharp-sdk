// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaCollectionEntitiesRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the collection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CollectionQualifiedName")]
        [Validation(Required=false)]
        public string CollectionQualifiedName { get; set; }

        /// <summary>
        /// The type of the entities.
        /// 
        /// For example, if this parameter is set to maxcompute-table, the entity is a MaxCompute table.
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// The search keyword.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
