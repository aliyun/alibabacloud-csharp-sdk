// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateSandboxConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cri-abc123</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/my/ns:v1</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("osType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/ready</para>
        /// </summary>
        [NameInMap("readyCommand")]
        [Validation(Required=false)]
        public string ReadyCommand { get; set; }

        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acr</para>
        /// </summary>
        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/start-coroutines.sh</para>
        /// </summary>
        [NameInMap("startCommand")]
        [Validation(Required=false)]
        public string StartCommand { get; set; }

    }

}
