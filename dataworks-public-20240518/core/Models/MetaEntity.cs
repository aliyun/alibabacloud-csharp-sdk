// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class MetaEntity : TeaModel {
        /// <summary>
        /// <para>The entity properties. Complex values are represented as JSON strings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;: &quot;v1&quot;}</para>
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
        /// <para>The creation time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1780553640613</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The custom attribute values. The key is the custom attribute identifier, and the value is a list of attribute values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;owner_name&quot;:[&quot;Zhang San&quot;]}</para>
        /// </summary>
        [NameInMap("CustomAttributes")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> CustomAttributes { get; set; }

        /// <summary>
        /// <para>The entity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api:api_001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The property definition of the custom entity. <notice>This legacy property is not populated. To retrieve the entity type definition, call GetMetaEntityDef.</notice></para>
        /// </summary>
        [NameInMap("MetaEntityDef")]
        [Validation(Required=false)]
        public MetaEntityDef MetaEntityDef { get; set; }

        /// <summary>
        /// <para>The modification time. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1763380628000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>The entity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The owner ID. Default value: the Alibaba Cloud UID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>207924799988354</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
