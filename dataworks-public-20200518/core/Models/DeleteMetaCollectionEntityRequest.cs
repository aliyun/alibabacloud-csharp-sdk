// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteMetaCollectionEntityRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the collection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>album.12345</para>
        /// </summary>
        [NameInMap("CollectionQualifiedName")]
        [Validation(Required=false)]
        public string CollectionQualifiedName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the entity.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute.projectA.tableB</para>
        /// </summary>
        [NameInMap("EntityQualifiedName")]
        [Validation(Required=false)]
        public string EntityQualifiedName { get; set; }

    }

}
