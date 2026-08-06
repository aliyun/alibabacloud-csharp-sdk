// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTableBusinessMetadataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The custom attribute values. The key is the custom attribute identifier, and the value contains at most one element. An empty list indicates that the attribute value is deleted. Passing this parameter without Readme prevents the usage description from being cleared. An empty object indicates that custom attributes are not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;biz_owner&quot;:[&quot;张三&quot;]}</para>
        /// </summary>
        [NameInMap("CustomAttributes")]
        [Validation(Required=false)]
        public string CustomAttributesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the table. For the format, refer to the response of the ListTables operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:::project_name:[schema_name]:table_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The usage description. Rich text format is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <h2>introduction</h2>
        /// </summary>
        [NameInMap("Readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

    }

}
