// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the resources. You can specify up to 20 IDs in the format of a JSON array.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;000e5836-xxxx-xxxx-xxxx-0d6ab2ac4877&quot;]</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The region in which the resource resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>application</b>: Enterprise Distributed Application Service (EDAS) application</description></item>
        /// <item><description><b>cluster</b>: EDAS cluster</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The key-value pairs. When you set this parameter, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>You can add up to 20 tags to a resource.</description></item>
        /// <item><description>The tag key cannot start with <b>aliyun</b> or <b>acs:</b>. It cannot contain <b>http://</b> or <b>https://</b>.</description></item>
        /// <item><description>The tag key or tag value can be up to 128 characters in length, and can contain letters, digits, hyphens (-), commas (,), asterisks (\*), forward slashes (/), question marks (?), and colons (:).</description></item>
        /// <item><description>Set this parameter to a JSON array.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;key1&quot;,&quot;value&quot;:&quot;v1&quot;},{&quot;key&quot;:&quot;key2&quot;,&quot;value&quot;:&quot;v2&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
