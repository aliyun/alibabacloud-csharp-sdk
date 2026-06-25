// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class SidecarContainerConfig : TeaModel {
        /// <summary>
        /// <para>The instance ID of the ACR Enterprise Edition. This parameter is required if the <c>ImageUrl</c> is from an ACR Enterprise Edition repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxxx</para>
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The startup command for the image. This command overrides the <c>ENTRYPOINT</c> defined in the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The arguments for the startup command. This parameter corresponds to <c>CMD</c> in the Dockerfile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The settings for mounting a ConfigMap. Use this to inject configuration data into the container as files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;configMapId&quot;:16,&quot;key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        /// <summary>
        /// <para>The CPU resources allocated to the container, measured in millicores. For example, a value of 1000 represents 1 vCPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The configuration for an <c>emptyDir</c> volume. This creates a temporary directory that persists for the life of the application instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;workdir\&quot;,\&quot;mountPath\&quot;:\&quot;/usr/local/tomcat/webapps\&quot;}]</para>
        /// </summary>
        [NameInMap("EmptyDirDesc")]
        [Validation(Required=false)]
        public string EmptyDirDesc { get; set; }

        /// <summary>
        /// <para>The environment variables to set in the container. Specify the variables as a JSON array of key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;TEST_ENV_KEY&quot;,&quot;value&quot;:&quot;TEST_ENV_VAR&quot;}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        /// <summary>
        /// <para>The container image URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The configuration for the liveness probe. The liveness probe checks if the container is running. If the probe fails, the system restarts the container.</para>
        /// </summary>
        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>The amount of memory allocated to the container, measured in MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The name of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration for the postStart hook. This hook runs immediately after the container starts to perform initialization tasks.</para>
        /// </summary>
        [NameInMap("PostStart")]
        [Validation(Required=false)]
        public string PostStart { get; set; }

        /// <summary>
        /// <para>The configuration for the preStop hook. This hook runs immediately before the container is terminated to ensure a graceful shutdown.</para>
        /// </summary>
        [NameInMap("PreStop")]
        [Validation(Required=false)]
        public string PreStop { get; set; }

        /// <summary>
        /// <para>The configuration for the readiness probe. The readiness probe checks if the container is ready to handle requests. The system will not direct traffic to a container until its readiness probe succeeds.</para>
        /// </summary>
        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        /// <summary>
        /// <para>Specifies how to mount a Secret. This lets you securely use sensitive data, such as credentials or keys, in your application.</para>
        /// </summary>
        [NameInMap("SecretMountDesc")]
        [Validation(Required=false)]
        public string SecretMountDesc { get; set; }

    }

}
