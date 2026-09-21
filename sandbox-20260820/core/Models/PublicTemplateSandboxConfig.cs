// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicTemplateSandboxConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cri-****</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/sandbox-demo/python:3.12</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>linux-amd64</para>
        /// </summary>
        [NameInMap("osType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>curl -sf <a href="http://127.0.0.1:49983/health">http://127.0.0.1:49983/health</a></para>
        /// </summary>
        [NameInMap("readyCommand")]
        [Validation(Required=false)]
        public string ReadyCommand { get; set; }

        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public PublicTemplateRegistryConfig RegistryConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/usr/local/bin/start.sh</para>
        /// </summary>
        [NameInMap("startCommand")]
        [Validation(Required=false)]
        public string StartCommand { get; set; }

    }

}
