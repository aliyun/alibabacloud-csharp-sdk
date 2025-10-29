// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class AddEntityIntoMetaCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The entity ID. Currently, only table entities are supported. You can call the ListTables operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The collection ID. You can refer to the return result of the ListMetaCollections operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>category.123</para>
        /// </summary>
        [NameInMap("MetaCollectionId")]
        [Validation(Required=false)]
        public string MetaCollectionId { get; set; }

        /// <summary>
        /// <para>Remarks added when adding the entity to a collection. This parameter is currently valid only for album collections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
