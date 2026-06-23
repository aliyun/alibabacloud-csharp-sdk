// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateMetaEntityDefRequest : TeaModel {
        /// <summary>
        /// <para>The new description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The new display name. The maximum length is 32 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business API</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The entity type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_entity-customer_api</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The new attribute definitions. New attributes must be optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("NewAttributeDefs")]
        [Validation(Required=false)]
        public List<MetaEntityAttributeDef> NewAttributeDefs { get; set; }

        /// <summary>
        /// <para>The updates to existing attribute definitions. You can modify only the display name and description. You can also add enumerated values for attributes of the ENUM type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("UpdateAttributeDefs")]
        [Validation(Required=false)]
        public List<MetaEntityAttributeDef> UpdateAttributeDefs { get; set; }

    }

}
