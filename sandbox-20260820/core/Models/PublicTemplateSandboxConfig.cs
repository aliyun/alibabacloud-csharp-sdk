// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateSandboxConfig : TeaModel {
        /// <summary>
        /// <para>The ID of the Container Registry Enterprise instance. This parameter is required when registryType is set to acree.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-****</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The sandbox generation. Valid values: 1 (first generation) and 2 (second generation). Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        /// <summary>
        /// <para>The address of the sandbox base image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/sandbox-demo/python:3.12</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The operating system type of the second-generation sandbox. Valid values: linux-amd64, android-36-osworld, and windows-osworld.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linux-amd64</para>
        /// </summary>
        [NameInMap("osType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The readiness probe command for the sandbox. A successful execution indicates that the sandbox is ready to receive requests. This parameter is supported only by first-generation sandboxes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>curl -sf <a href="http://127.0.0.1:49983/health">http://127.0.0.1:49983/health</a></para>
        /// </summary>
        [NameInMap("readyCommand")]
        [Validation(Required=false)]
        public string ReadyCommand { get; set; }

        /// <summary>
        /// <para>The configuration used to access the image repository. For security reasons, only the network configuration is returned in query responses, and logon credentials are not returned.</para>
        /// </summary>
        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public PublicTemplateRegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <para>The startup command for the sandbox container. This parameter is supported only by first-generation sandboxes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/usr/local/bin/start.sh</para>
        /// </summary>
        [NameInMap("startCommand")]
        [Validation(Required=false)]
        public string StartCommand { get; set; }

        /// <summary>
        /// <para>The list of custom build steps.</para>
        /// </summary>
        [NameInMap("steps")]
        [Validation(Required=false)]
        public List<PublicTemplateStep> Steps { get; set; }

    }

}
