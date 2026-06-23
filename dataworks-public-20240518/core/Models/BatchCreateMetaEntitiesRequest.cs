// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class BatchCreateMetaEntitiesRequest : TeaModel {
        /// <summary>
        /// <para>An entity list. You can create up to five entities in a batch. All entities in the batch must have the same <c>EntityType</c>.</para>
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
            /// <para>The entity attributes. Complex values must be serialized into a JSON string.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            /// <summary>
            /// <para>The comment for the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The custom attribute values. The key is the identifier of the custom attribute, and the value is a single-element list.</para>
            /// <remarks>
            /// <para>Notice: The custom attributes used here must be created in advance by using the CreateCustomAttribute API. For example, after you create a custom attribute with the ID <c>custom-attribute:owner_name</c>, you can configure the custom attribute by setting this parameter to {\&quot;owner_name\&quot;: [\&quot;Bob\&quot;]}.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> CustomAttributes { get; set; }

            /// <summary>
            /// <para>The entity type. All entities in a batch must have the same type. The following types are supported:</para>
            /// <list type="bullet">
            /// <item><description><para>Custom types, such as <c>custom_entity-biz_api</c>.</para>
            /// </description></item>
            /// <item><description><para>Extended table types. For example, if you have registered the <c>custom_dw-table</c> metadata entity type, you can create objects of the corresponding <c>custom_dw-database</c> (database) and <c>custom_dw-table</c> (table) types.</para>
            /// </description></item>
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
            /// <para>The entity name. The name can contain uppercase letters, lowercase letters, digits, and underscores (_). It must start with a letter and not exceed 64 characters.</para>
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
