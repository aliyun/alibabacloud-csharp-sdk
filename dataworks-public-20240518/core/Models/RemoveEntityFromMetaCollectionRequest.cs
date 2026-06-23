// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class RemoveEntityFromMetaCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The entity ID. Currently, entities can only be tables. You can call the ListTables operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The collection ID. You can call the ListMetaCollections operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>as78d756asd</para>
        /// </summary>
        [NameInMap("MetaCollectionId")]
        [Validation(Required=false)]
        public string MetaCollectionId { get; set; }

    }

}
