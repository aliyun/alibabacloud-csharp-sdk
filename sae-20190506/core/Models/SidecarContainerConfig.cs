// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class SidecarContainerConfig : TeaModel {
        /// <summary>
        /// <para>The ID of the Container Registry Enterprise Edition instance. This parameter is required if the ImageUrl parameter is set to the URL of an image in a Container Registry Enterprise Edition instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-xxxxxx</para>
        /// </summary>
        [NameInMap("AcrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The startup command of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The parameters of the image startup command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;a&quot;,&quot;b&quot;]</para>
        /// </summary>
        [NameInMap("CommandArgs")]
        [Validation(Required=false)]
        public string CommandArgs { get; set; }

        /// <summary>
        /// <para>The description of the ConfigMap mounted to the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;configMapId&quot;:16,&quot;key&quot;:&quot;test&quot;,&quot;mountPath&quot;:&quot;/tmp&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigMapMountDesc")]
        [Validation(Required=false)]
        public string ConfigMapMountDesc { get; set; }

        /// <summary>
        /// <para>Cpu</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The EmptyDir description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;name\&quot;:\&quot;workdir\&quot;,\&quot;mountPath\&quot;:\&quot;/usr/local/tomcat/webapps\&quot;}]</para>
        /// </summary>
        [NameInMap("EmptyDirDesc")]
        [Validation(Required=false)]
        public string EmptyDirDesc { get; set; }

        /// <summary>
        /// <para>The environment variables of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;TEST_ENV_KEY&quot;,&quot;value&quot;:&quot;TEST_ENV_VAR&quot;}]</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public string Envs { get; set; }

        /// <summary>
        /// <para>The image address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("Liveness")]
        [Validation(Required=false)]
        public string Liveness { get; set; }

        /// <summary>
        /// <para>Memory</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The container name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Readiness")]
        [Validation(Required=false)]
        public string Readiness { get; set; }

        [NameInMap("SecretMountDesc")]
        [Validation(Required=false)]
        public string SecretMountDesc { get; set; }

    }

}
