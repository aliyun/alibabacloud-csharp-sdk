// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateSlsLogStoreRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the ListApplication operation to query the application ID. For more information, see <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af58edcf-f7eb-<b><b>-</b></b>-db4e425f****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The configurations of the Logstore.</para>
        /// <list type="bullet">
        /// <item><description><para>The following parameters are included in the configurations:****</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the collection type. Set this parameter to file to specify the file type. Set this parameter to stdout to specify the standard output type.</para>
        /// </description></item>
        /// <item><description><para><b>logstore</b>: the name of the Logstore. Make sure that the name of the Logstore is unique in the cluster. The name must comply with the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Note</b>If you leave this parameter empty, the system automatically generates a name.</para>
        /// </description></item>
        /// <item><description><para><b>LogDir</b>: If the standard output type is used, the collection path is stdout.log. If the file type is used, the collection path is the path of the collected file. Wildcards (\*) are supported. The collection path must match the following regular expression: <c>^/(.+)/(.*)^/$</c>.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;logstore&quot;:&quot;thisisanotherfilelog&quot;,&quot;type&quot;:&quot;file&quot;,&quot;logDir&quot;:&quot;/var/log/<em>&quot;},{&quot;logstore&quot;:&quot;&quot;,&quot;type&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;stdout.log&quot;},{&quot;logstore&quot;:&quot;thisisafilelog&quot;,&quot;type&quot;:&quot;file&quot;,&quot;logDir&quot;:&quot;/tmp/log/</em>&quot;}]</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public string Configs { get; set; }

    }

}
