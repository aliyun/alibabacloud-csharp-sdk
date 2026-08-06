// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateMetaEntityDefShrinkRequest : TeaModel {
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
        /// <para>The new display name, up to 32 characters.</para>
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
        public string NewAttributeDefsShrink { get; set; }

        /// <summary>
        /// <para>Updates to existing attribute definitions. Only modifying the display name, description, and appending enum values to ENUM types are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("UpdateAttributeDefs")]
        [Validation(Required=false)]
        public string UpdateAttributeDefsShrink { get; set; }

    }

}
