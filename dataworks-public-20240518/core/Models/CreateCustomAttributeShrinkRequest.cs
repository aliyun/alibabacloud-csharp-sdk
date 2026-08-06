// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateCustomAttributeShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the custom attribute. The value must be less than 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the attribute on the details page. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisplayEnabled")]
        [Validation(Required=false)]
        public bool? DisplayEnabled { get; set; }

        /// <summary>
        /// <para>The display name of the custom attribute. The value must be less than 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BusinessOwner</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The list of applicable entity types. Exact entity types and wildcard patterns such as <c>*-table</c> and <c>*-column</c> are supported. Examples:</para>
        /// <list type="bullet">
        /// <item><description>dataworks-project: workspace</description></item>
        /// <item><description>dataworks-dataset: DataWorks dataset</description></item>
        /// <item><description>maxcompute-table: MaxCompute table</description></item>
        /// <item><description>*-column: all column types</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EntityTypes")]
        [Validation(Required=false)]
        public string EntityTypesShrink { get; set; }

        /// <summary>
        /// <para>The custom attribute ID. The value must match <c>^custom-attribute:[A-Za-z][A-Za-z0-9_]{0,98}$</c>. The part after custom-attribute: must be less than 100 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-attribute:biz_owner</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether the attribute can be used as a filter condition on the DataWorks Data Map search page. Default value: false. Currently, only the ENUM type supports setting this value to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SearchFilterEnabled")]
        [Validation(Required=false)]
        public bool? SearchFilterEnabled { get; set; }

        /// <summary>
        /// <para>The type of the custom attribute. Valid values: ENUM, TEXT, and HYPERLINK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The enumeration values. This parameter is required when type is set to ENUM. This parameter is not supported for TEXT or HYPERLINK types.</para>
        /// </summary>
        [NameInMap("ValueEnums")]
        [Validation(Required=false)]
        public string ValueEnumsShrink { get; set; }

    }

}
