// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateColumnBusinessMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The custom attributes of the column, specified as key-value pairs. The key is the attribute identifier, and the value is an array that can contain at most one element. An empty array deletes the attribute\&quot;s value. To avoid overwriting the column\&quot;s business description, omit the <c>Description</c> parameter from the request. An empty object (<c>{}</c>) indicates that no custom attributes are updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;biz_owner&quot;:[&quot;张三&quot;]}</para>
        /// </summary>
        [NameInMap("CustomAttributes")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> CustomAttributes { get; set; }

        /// <summary>
        /// <para>The business description of the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the column. You can obtain this ID from the response of the <c>ListColumns</c> operation. For more information, see <a href="https://help.aliyun.com/document_detail/2880092.html">Metadata Entity Concepts</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-column:::project_name:[schema_name]:table_name:column_name</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
