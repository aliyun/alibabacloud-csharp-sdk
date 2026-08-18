// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchCreateMetaEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>The list of entities. A maximum of five entities are supported. All entities in the same batch must have the same entityType.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public List<BatchCreateMetaEntitiesRequestEntities> Entities { get; set; }
        public class BatchCreateMetaEntitiesRequestEntities : TeaModel {
            /// <summary>
            /// <para>The entity attributes. Complex values must be serialized as JSON strings.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            /// <summary>
            /// <para>The comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The custom attribute values. The key is the custom attribute identifier, and the value currently supports only a single value.
            /// <notice>The custom attributes used here must be created in advance by calling the CreateCustomAttribute operation. For example, after you call the API to create a custom attribute with the ID <c>custom-attribute:owner_name</c>, you can configure {\&quot;owner_name\&quot;: [\&quot;Bob\&quot;]} here to complete the custom attribute configuration.</notice></para>
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> CustomAttributes { get; set; }

            /// <summary>
            /// <para>The entity type. All entities in the same batch must have the same type. The following types are supported:</para>
            /// <list type="bullet">
            /// <item><description>Custom entity types, such as custom_entity-biz_api.</description></item>
            /// <item><description>Extension table types. If the metadata entity type custom_dw-table is registered, you can create objects of the corresponding database type custom_dw-database and table type custom_dw-table.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom_entity-customer_api</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The entity name. The name can contain uppercase letters, lowercase letters, digits, and underscores (_). It must start with a letter and can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api_001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
