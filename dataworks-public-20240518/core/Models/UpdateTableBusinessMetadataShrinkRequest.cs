// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTableBusinessMetadataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The values of custom attributes. The key specifies the identifier of a custom attribute, and the value is an array that can contain at most one item. To delete the value for an attribute, pass an empty array. To update only custom attributes, omit the <c>Readme</c> parameter to prevent its existing value from being cleared. To leave the custom attributes unchanged, pass an empty object <c>{}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;biz_owner&quot;:[&quot;张三&quot;]}</para>
        /// </summary>
        [NameInMap("CustomAttributes")]
        [Validation(Required=false)]
        public string CustomAttributesShrink { get; set; }

        /// <summary>
        /// <para>The table ID. For the required format, see the response of the <c>ListTables</c> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The Readme of the table, which supports rich text format.</para>
        /// 
        /// <b>Example:</b>
        /// <h2>introduction</h2>
        /// </summary>
        [NameInMap("Readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

    }

}
