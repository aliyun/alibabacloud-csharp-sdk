// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateConfigMapRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ConfigMap instance that you want to update. To view the ID, call the <a href="https://help.aliyun.com/document_detail/176917.html">ListNamespacedConfigMaps</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConfigMapId")]
        [Validation(Required=false)]
        public long? ConfigMapId { get; set; }

        /// <summary>
        /// <para>The key-value pairs for the ConfigMap. The value must be a JSON-formatted string, as shown in the following example:</para>
        /// <para>{&quot;Data&quot;:&quot;{&quot;k1&quot;:&quot;v1&quot;, &quot;k2&quot;:&quot;v2&quot;}&quot;}</para>
        /// <para>In the JSON string, k represents a key and v represents a value. For more information about configuration items, see <a href="https://help.aliyun.com/document_detail/171326.html">Managing and using configuration items</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;env.shell&quot;: &quot;/bin/sh&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
