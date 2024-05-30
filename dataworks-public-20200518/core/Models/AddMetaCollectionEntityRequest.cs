// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddMetaCollectionEntityRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the collection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CollectionQualifiedName")]
        [Validation(Required=false)]
        public string CollectionQualifiedName { get; set; }

        /// <summary>
        /// The unique identifier of the entity.
        /// 
        /// Example: maxcompute-table.projectA.tableA.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EntityQualifiedName")]
        [Validation(Required=false)]
        public string EntityQualifiedName { get; set; }

        /// <summary>
        /// The remarks on the entity. Example: latest product table.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
