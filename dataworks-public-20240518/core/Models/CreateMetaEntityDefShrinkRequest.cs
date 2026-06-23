// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateMetaEntityDefShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of attribute definitions for the pure custom type. Do not specify this parameter if the <c>Extend</c> parameter is set to <c>TABLE</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("AttributeDefs")]
        [Validation(Required=false)]
        public string AttributeDefsShrink { get; set; }

        /// <summary>
        /// <para>A description of the entity definition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name. The maximum length is 32 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business API</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The extension mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>NONE</c>: The default value. Specifies a pure custom type with user-defined attributes.</para>
        /// </description></item>
        /// <item><description><para><c>TABLE</c>: Specifies an extended table type that references an existing table type in Data Map. Attribute definitions are not required for this type. You can create corresponding <c>Database</c> and <c>Table</c> objects for it.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The type definition name. For a pure custom type, the name must match <c>^[a-z0-9][a-z0-9_]*$</c>. For an extended table type, the name must match <c>^[a-z0-9][a-z0-9_]*-table$</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>biz_api</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
