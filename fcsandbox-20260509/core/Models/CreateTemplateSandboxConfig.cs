// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateTemplateSandboxConfig : TeaModel {
        /// <summary>
        /// <para>The Container Registry Enterprise instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-abcd1234efgh</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The sandbox generation. A value of 1 indicates the first-generation sandbox. A value of 2 indicates the second-generation sandbox.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        /// <summary>
        /// <para>The image address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The operating system type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("osType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The sandbox readiness probe command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>curl -sf <a href="http://127.0.0.1:8080/healthz">http://127.0.0.1:8080/healthz</a></para>
        /// </summary>
        [NameInMap("readyCommand")]
        [Validation(Required=false)]
        public string ReadyCommand { get; set; }

        /// <summary>
        /// <para>The image repository configuration.</para>
        /// </summary>
        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <para>The image repository type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr</para>
        /// </summary>
        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// <para>The sandbox startup command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sleep infinity</para>
        /// </summary>
        [NameInMap("startCommand")]
        [Validation(Required=false)]
        public string StartCommand { get; set; }

        /// <summary>
        /// <para>The list of custom build steps.</para>
        /// </summary>
        [NameInMap("steps")]
        [Validation(Required=false)]
        public List<CreateTemplateStep> Steps { get; set; }

    }

}
