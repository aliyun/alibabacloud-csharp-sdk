// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("codeUrl")]
        [Validation(Required=false)]
        public string CodeUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("codeVersion")]
        [Validation(Required=false)]
        public string CodeVersion { get; set; }

        [NameInMap("filePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("requestFrom")]
        [Validation(Required=false)]
        public string RequestFrom { get; set; }

        [NameInMap("resourceIdentifier")]
        [Validation(Required=false)]
        public string ResourceIdentifier { get; set; }

        [NameInMap("reuse")]
        [Validation(Required=false)]
        public bool? Reuse { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workspaceTemplate")]
        [Validation(Required=false)]
        public string WorkspaceTemplate { get; set; }

    }

}
