// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateTemplateCopyAction : TeaModel {
        /// <summary>
        /// <para>The ID of the ACR Enterprise instance where the source image resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-abcd1234efgh</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable image replication.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The source image address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/demo/nginx:latest</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The source image repository configuration.</para>
        /// </summary>
        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <para>The source image repository type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr</para>
        /// </summary>
        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

    }

}
