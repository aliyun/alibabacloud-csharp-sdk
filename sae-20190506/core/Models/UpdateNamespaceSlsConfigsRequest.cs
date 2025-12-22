// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateNamespaceSlsConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The short ID of the namespace. No need to specify a region ID. We recommend configuring this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NameSpaceShortId")]
        [Validation(Required=false)]
        public string NameSpaceShortId { get; set; }

        /// <summary>
        /// <para>The namespace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The logging configurations of Simple Log Service.</para>
        /// <list type="bullet">
        /// <item><description><c>[{&quot;logDir&quot;:&quot;&quot;,&quot;logType&quot;:&quot;stdout&quot;},{&quot;logDir&quot;:&quot;/tmp/a.log&quot;}]</c>: Simple Log Service resources automatically created by Serverless App Engine (SAE) are used.</description></item>
        /// <item><description>To use custom Simple Log Service resources, set this parameter to <c>[{&quot;projectName&quot;:&quot;test-sls&quot;,&quot;logType&quot;:&quot;stdout&quot;,&quot;logDir&quot;:&quot;&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;},{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</c>.</description></item>
        /// </list>
        /// <para>Take note of the following subparameters:</para>
        /// <list type="bullet">
        /// <item><description><b>projectName</b>: the name of the Simple Log Service project.</description></item>
        /// <item><description><b>logDir</b>: the path in which logs are stored.</description></item>
        /// <item><description><b>logType</b>: the log type. <b>stdout</b> indicates the standard output (stdout) logs of the container. You can specify only one stdout value for this parameter. If not specified, file logs are collected.</description></item>
        /// <item><description><b>logstoreName</b>: the name of the Logstore in Simple Log Service.</description></item>
        /// <item><description><b>logtailName</b>: the name of the Logtail in Simple Log Service. If not specified, a new Logtail is created.</description></item>
        /// </list>
        /// <para>If logging configuration changes are not needed during job template deployment, specify <b>SlsConfigs</b> only in the first request. Omit this parameter in later requests. To stop using Simple Log Service, leave <b>SlsConfigs</b> empty.</para>
        /// <remarks>
        /// <para>Projects automatically created by SAE for job templates are deleted when their corresponding job templates are deleted. Therefore, you should not select an existing SAE-created project for log collection.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;projectName&quot;:&quot;test&quot;,&quot;logDir&quot;:&quot;/tmp/a.log&quot;,&quot;logstoreName&quot;:&quot;sae&quot;,&quot;logtailName&quot;:&quot;&quot;}]</para>
        /// </summary>
        [NameInMap("SlsConfigs")]
        [Validation(Required=false)]
        public string SlsConfigs { get; set; }

        [NameInMap("SlsLogEnvTags")]
        [Validation(Required=false)]
        public string SlsLogEnvTags { get; set; }

    }

}
