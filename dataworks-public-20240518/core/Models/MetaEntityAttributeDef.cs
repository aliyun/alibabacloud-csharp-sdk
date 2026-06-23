// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class MetaEntityAttributeDef : TeaModel {
        /// <summary>
        /// <para>Enumeration values. Required when Type is ENUM.</para>
        /// </summary>
        [NameInMap("AllowedValues")]
        [Validation(Required=false)]
        public List<string> AllowedValues { get; set; }

        /// <summary>
        /// <para>Attribute description</para>
        /// 
        /// <b>Example:</b>
        /// <para>层级描述</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the attribute appears on the product page. Default is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisplayEnabled")]
        [Validation(Required=false)]
        public bool? DisplayEnabled { get; set; }

        /// <summary>
        /// <para>Display name. It can be up to 32 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API编码</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Indicates whether the value is optional. Default is true.&gt;Notice:  Validation occurs when creating an entity. If this value is false and no value is provided during creation, validation fails and an error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsOptional")]
        [Validation(Required=false)]
        public bool? IsOptional { get; set; }

        /// <summary>
        /// <para>Attribute identifier. It can contain letters, digits, and underscores. It must start with a letter or digit and be up to 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiCode</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether the attribute can be used as a filter on the search page. Default is false.</para>
        /// <para>Only attributes of type STRING, DATE, ENUM, ARRAY, INT, or BOOLEAN support this setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SearchFilterEnabled")]
        [Validation(Required=false)]
        public bool? SearchFilterEnabled { get; set; }

        /// <summary>
        /// <para>Attribute type. Supported types include STRING, TEXT, INT, FLOAT, BOOLEAN, DATE, ARRAY, ENUM, and JSON.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
