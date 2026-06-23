// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateMetaEntityShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The entity attributes. Complex values must be serialized into a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string AttributesShrink { get; set; }

        /// <summary>
        /// <para>The comment on the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The custom attribute values. Each key specifies a custom attribute, and its value is an array that can contain at most one item. To delete an attribute value, provide an empty array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("CustomAttributes")]
        [Validation(Required=false)]
        public string CustomAttributesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the entity to update. The entity name, entity type, and parent-child relationship are determined by the ID and cannot be modified using this operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api:api_001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
