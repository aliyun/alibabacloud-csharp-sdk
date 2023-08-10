// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddMetaCollectionEntityRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the entity.
        /// 
        /// Example: maxcompute-table.projectA.tableA.
        /// </summary>
        [NameInMap("CollectionQualifiedName")]
        [Validation(Required=false)]
        public string CollectionQualifiedName { get; set; }

        /// <summary>
        /// The ID of the request. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("EntityQualifiedName")]
        [Validation(Required=false)]
        public string EntityQualifiedName { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
