// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateCopyAction : TeaModel {
        /// <summary>
        /// <para>The ID of the destination Container Registry Enterprise instance. This field does not inherit the instance ID from the source image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-****</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the image replication action. Required when this action block is included.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The destination image address to push to. If not specified, the service derives a new tag under the repository where the source image resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/sandbox-demo/python:3.12-envd</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The credentials, TLS, and network configuration required to access the destination image repository.</para>
        /// </summary>
        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <para>The type of the destination image repository. Valid values: oci (standard OCI repository), acr (Container Registry Personal Edition), acree (Container Registry Enterprise Edition). If not specified, the type is inferred from the destination image address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acree</para>
        /// </summary>
        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

    }

}
