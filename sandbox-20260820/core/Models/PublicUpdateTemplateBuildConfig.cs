// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateBuildConfig : TeaModel {
        /// <summary>
        /// <para>The image replication action configuration.</para>
        /// </summary>
        [NameInMap("copy")]
        [Validation(Required=false)]
        public PublicUpdateTemplateCopyAction Copy { get; set; }

        /// <summary>
        /// <para>The envd injection action configuration.</para>
        /// </summary>
        [NameInMap("envdInject")]
        [Validation(Required=false)]
        public PublicUpdateTemplateEnvdInjectAction EnvdInject { get; set; }

        /// <summary>
        /// <para>Installs the clients required for storage mounting.</para>
        /// </summary>
        [NameInMap("installStorageClients")]
        [Validation(Required=false)]
        public bool? InstallStorageClients { get; set; }

    }

}
