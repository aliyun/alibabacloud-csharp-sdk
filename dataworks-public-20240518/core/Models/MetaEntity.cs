// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class MetaEntity : TeaModel {
        /// <summary>
        /// <para>Entity attributes. Complex values are represented as JSON strings.</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <para>Comment</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Creation time as a millisecond-level timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1780553640613</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Custom attribute values. The key is the custom attribute identifier. The value is a list of attribute values.</para>
        /// </summary>
        [NameInMap("CustomAttributes")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> CustomAttributes { get; set; }

        /// <summary>
        /// <para>Entity type</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>Entity ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api:api_001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Attribute definition of the custom entity.</para>
        /// <remarks>
        /// <para>Notice: For historical reasons, this property is not returned and its value is empty. We recommend that you use the GetMetaEntityDef API to obtain the entity type definition.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("MetaEntityDef")]
        [Validation(Required=false)]
        public MetaEntityDef MetaEntityDef { get; set; }

        /// <summary>
        /// <para>Modification time as a millisecond-level timestamp</para>
        /// 
        /// <b>Example:</b>
        /// <para>1763380628000</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// <para>Entity name</para>
        /// 
        /// <b>Example:</b>
        /// <para>api_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Owner ID. The default value is the Alibaba Cloud UID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>207924799988354</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
