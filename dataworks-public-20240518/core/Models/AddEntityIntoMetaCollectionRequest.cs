// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class AddEntityIntoMetaCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the entity. Currently, only the table type is supported. You can obtain the ID from the response of the ListTables operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The ID of the collection object. You can obtain the ID from the response of the ListMetaCollections operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>as78d756asd</para>
        /// </summary>
        [NameInMap("MetaCollectionId")]
        [Validation(Required=false)]
        public string MetaCollectionId { get; set; }

        /// <summary>
        /// <para>The remarks when adding the entity to the collection. Currently, this parameter takes effect only for the album type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
