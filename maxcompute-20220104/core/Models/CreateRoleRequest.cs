// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateRoleRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters. For valid values, see <a href="https://help.aliyun.com/document_detail/27935.html">MaxCompute permissions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;: &quot;role_name&quot;,&quot;type&quot;: &quot;resource/admin&quot;,&quot;policy&quot;: &quot;&quot;, //policy content. Not required if the type is acl.&quot;acl&quot;: { // Not required if the type is policy.&quot;table&quot;: [{&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[&quot;&quot;,&quot;&quot;,]}, {&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[]}],&quot;resource&quot;:[{&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[&quot;&quot;,&quot;&quot;,]}, {&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[]}],&quot;function&quot;:[{&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[&quot;&quot;,&quot;&quot;,]}, {&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[]}],&quot;package&quot;:[{&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[&quot;&quot;,&quot;&quot;,]}, {&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[]}],&quot;project&quot;:[{&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[]}], //Only the current project is available on the console.&quot;instance&quot;:[{&quot;name&quot;: &quot;&quot;, &quot;actions&quot;:[]}] //Only * is supported for the name. }}// * is supported for the name.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
