// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateBuildConfig : TeaModel {
        /// <summary>
        /// <para>The action configuration for pulling the source image and pushing it to the destination repository.</para>
        /// </summary>
        [NameInMap("copy")]
        [Validation(Required=false)]
        public CreateTemplateCopyAction Copy { get; set; }

        /// <summary>
        /// <para>The action configuration for packaging the envd daemon process into the image. This is an optional intermediate step in the copy process and is supported only by first-generation sandboxes.</para>
        /// </summary>
        [NameInMap("envdInject")]
        [Validation(Required=false)]
        public CreateTemplateEnvdInjectAction EnvdInject { get; set; }

        /// <summary>
        /// <para>The installation of clients required for storage mounting.</para>
        /// </summary>
        [NameInMap("installStorageClients")]
        [Validation(Required=false)]
        public bool? InstallStorageClients { get; set; }

    }

}
