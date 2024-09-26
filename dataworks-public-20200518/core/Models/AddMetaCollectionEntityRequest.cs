// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class AddMetaCollectionEntityRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the collection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>album.2222</para>
        /// </summary>
        [NameInMap("CollectionQualifiedName")]
        [Validation(Required=false)]
        public string CollectionQualifiedName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the entity. Example: maxcompute-table.projectA.tableA.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table.projectA.tableB</para>
        /// </summary>
        [NameInMap("EntityQualifiedName")]
        [Validation(Required=false)]
        public string EntityQualifiedName { get; set; }

        /// <summary>
        /// <para>The remarks of the entity. Example: latest product table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
