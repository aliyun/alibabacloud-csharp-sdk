// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateNamespaceSlsConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The short ID of the namespace. You do not need to include the region. This parameter is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NameSpaceShortId")]
        [Validation(Required=false)]
        public string NameSpaceShortId { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The configuration for collecting logs to SLS.</para>
        /// <list type="bullet">
        /// <item><description><para>To use an SLS resource that is automatically created by SAE: <c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>.</para>
        /// </description></item>
        /// <item><description><para>To use a custom SLS resource: <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><c>projectName</c>: The name of the SLS project.</para>
        /// </description></item>
        /// <item><description><para><c>logDir</c>: The log path.</para>
        /// </description></item>
        /// <item><description><para><c>logType</c>: The log type. A value of <c>stdout</c> specifies container standard output logs. You can specify only one <c>stdout</c> configuration. If you do not set this parameter, file logs are collected.</para>
        /// </description></item>
        /// <item><description><para><c>logstoreName</c>: The name of the SLS logstore.</para>
        /// </description></item>
        /// <item><description><para><c>logtailName</c>: The name of the Logtail. If you do not specify this parameter, a new Logtail is created.</para>
        /// </description></item>
        /// </list>
        /// <para>If the SLS configuration remains the same across deployments, you can omit this parameter. To disable log collection to SLS, set the value of <c>SlsConfigs</c> to an empty string (&quot;&quot;).</para>
        /// <remarks>
        /// <para>SAE automatically deletes a project when you delete the task template used to create it. Therefore, when you select an existing project, do not select a project that was automatically created by SAE.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        /// <summary>
        /// <para>The SLS log tags.</para>
        /// </summary>
        [NameInMap("SlsLogEnvTags")]
        [Validation(Required=false)]
        public string SlsLogEnvTags { get; set; }

    }

}
