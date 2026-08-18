// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class MicroSandboxConfig : TeaModel {
        /// <summary>
        /// <para>The ID of the ACR Enterprise Edition image repository instance. Used in pair with MicroSandbox images. This parameter is optional. If not provided, the server resolves it as needed.</para>
        /// </summary>
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        /// <summary>
        /// <para>The image address.</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("osType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("readyCommand")]
        [Validation(Required=false)]
        public string ReadyCommand { get; set; }

        /// <summary>
        /// <para>The image repository configuration.</para>
        /// </summary>
        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public RegistryConfig RegistryConfig { get; set; }

        [NameInMap("startCommand")]
        [Validation(Required=false)]
        public string StartCommand { get; set; }

    }

}
