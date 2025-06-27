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
        /// <para>dlf-table:123456789:test_catalog:test_database::test_table</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The collection ID. You can call the ListMetaCollections operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>category.123</para>
        /// </summary>
        [NameInMap("MetaCollectionId")]
        [Validation(Required=false)]
        public string MetaCollectionId { get; set; }

    }

}
