// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ExecJobRequest : TeaModel {
        /// <summary>
        /// <para>The job template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ee1a7a07-abcb-4652-a1d3-2d57f415****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The startup command, which must be an executable that exists in the container. Example:</para>
        /// <pre><c>command:
        ///       - echo
        ///       - abc
        ///       - &gt;
        ///       - file0
        /// </c></pre>
        /// <para>Based on this example, <c>Command</c> is <c>echo</c> and <c>CommandArgs</c> is <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The arguments for the <b>Command</b> parameter. The value must be a string that represents a JSON array. Format:</para>
        /// <para><c>[&quot;a&quot;,&quot;b&quot;]</c></para>
        /// <para>In the preceding example for the <c>Command</c> parameter, <c>CommandArgs</c> is <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c>. The JSON array <c>[&quot;abc&quot;, &quot;&gt;&quot;, &quot;file0&quot;]</c> must be converted to a string. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The container environment variables. You can specify custom environment variables or reference an existing ConfigMap. For more information about creating a ConfigMap, see <a href="https://help.aliyun.com/document_detail/176914.html">CreateConfigMap</a>.</para>
        /// <list type="bullet">
        /// <item><description><para>Custom configuration</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The name of the environment variable.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The value of the environment variable.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Reference a ConfigMap</para>
        /// <list type="bullet">
        /// <item><description><para><b>name</b>: The name of the environment variable. You can reference a single key or all keys. To reference all keys, use the <c>sae-sys-configmap-all-&lt;ConfigMap name&gt;</c> format. Example: <c>sae-sys-configmap-all-test1</c>.</para>
        /// </description></item>
        /// <item><description><para><b>valueFrom</b>: The source of the environment variable. Set the value to <c>configMapRef</c>.</para>
        /// </description></item>
        /// <item><description><para><b>configMapId</b>: The ID of the ConfigMap.</para>
        /// </description></item>
        /// <item><description><para><b>key</b>: The key that you want to reference. If you want to reference all key-value pairs, do not specify this parameter.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;envtmp&quot;,&quot;value&quot;:&quot;0&quot;}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        /// <summary>
        /// <para>A customizable event ID that ensures idempotency. The system creates only one job for requests that have the same event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>Arguments for starting a job deployed from a JAR package. The default startup command is:
        /// <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArgs</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>custom-args</para>
        /// </summary>
        [NameInMap("JarStartArgs")]
        [Validation(Required=false)]
        public string JarStartArgs { get; set; }

        /// <summary>
        /// <para>Options for starting a job deployed from a JAR package. The default startup command is:
        /// <c>$JAVA_HOME/bin/java $JarStartOptions -jar $CATALINA_OPTS &quot;$package_path&quot; $JarStartArg</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>-Xms4G -Xmx4G</para>
        /// </summary>
        [NameInMap("JarStartOptions")]
        [Validation(Required=false)]
        public string JarStartOptions { get; set; }

        /// <summary>
        /// <para>The number of concurrent instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public string Replicas { get; set; }

        /// <summary>
        /// <para>The time to trigger the job, specified in the <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss\\&quot;Z\\&quot;</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-09-14T14:25:02Z</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>The startup command for a job deployed from a WAR package. Configuration is the same as for an image-based deployment. For more information, see <a href="https://help.aliyun.com/document_detail/96677.html">Configure a startup command</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CATALINA_OPTS=\&quot;$CATALINA_OPTS $Options\&quot; catalina.sh run</para>
        /// </summary>
        [NameInMap("WarStartOptions")]
        [Validation(Required=false)]
        public string WarStartOptions { get; set; }

    }

}
