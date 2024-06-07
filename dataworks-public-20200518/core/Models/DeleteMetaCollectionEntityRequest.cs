// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteMetaCollectionEntityRequest : TeaModel {
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
        /// This parameter is required.
        /// </summary>
        [NameInMap("EntityQualifiedName")]
        [Validation(Required=false)]
        public string EntityQualifiedName { get; set; }

    }

}
