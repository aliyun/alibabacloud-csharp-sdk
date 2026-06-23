// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateCustomAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the custom attribute. The description must be less than 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the attribute on the product page. The default value is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DisplayEnabled")]
        [Validation(Required=false)]
        public bool? DisplayEnabled { get; set; }

        /// <summary>
        /// <para>The display name of the custom attribute. The name must be less than 128 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>业务负责人</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The list of applicable entity types. You can specify precise entity types or use wildcards such as <c>*-table</c> and <c>*-column</c>. Examples:</para>
        /// <list type="bullet">
        /// <item><description><para>dataworks-project: a DataWorks workspace.</para>
        /// </description></item>
        /// <item><description><para>dataworks-dataset: a DataWorks dataset.</para>
        /// </description></item>
        /// <item><description><para>maxcompute-table: a MaxCompute table.</para>
        /// </description></item>
        /// <item><description><para>\*-column: all field types.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EntityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>The ID of the custom attribute. The ID must match the regular expression <c>^custom-attribute:[A-Za-z][A-Za-z0-9_]{0,98}$</c>. The part after \<c>custom-attribute:\\</c> must be less than 100 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-attribute:biz_owner</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Specifies whether the attribute can be used as a filter on the Data Map search page. The default value is false. Currently, you can set this parameter to true only for attributes of the ENUM type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SearchFilterEnabled")]
        [Validation(Required=false)]
        public bool? SearchFilterEnabled { get; set; }

        /// <summary>
        /// <para>The type of the custom attribute. Valid values are ENUM, TEXT, and HYPERLINK.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TEXT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The enumeration values. This parameter is required when \<c>Type\\</c> is set to \<c>ENUM\\</c>. It is not supported for the TEXT and HYPERLINK types.</para>
        /// </summary>
        [NameInMap("ValueEnums")]
        [Validation(Required=false)]
        public List<string> ValueEnums { get; set; }

    }

}
