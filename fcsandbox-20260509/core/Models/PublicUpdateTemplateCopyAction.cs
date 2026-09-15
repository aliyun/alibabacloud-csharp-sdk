// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicUpdateTemplateCopyAction : TeaModel {
        /// <summary>
        /// <para>The ID of the destination ACR Enterprise instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-abc123</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether image replication is enabled.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The destination image address for replication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/my/ns:v2</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The image repository configuration.</para>
        /// </summary>
        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <para>The destination repository type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr</para>
        /// </summary>
        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

    }

}
