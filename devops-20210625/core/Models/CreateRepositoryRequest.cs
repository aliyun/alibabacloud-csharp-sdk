// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateRepositoryRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("gitignoreType")]
        [Validation(Required=false)]
        public string GitignoreType { get; set; }

        [NameInMap("importAccount")]
        [Validation(Required=false)]
        public string ImportAccount { get; set; }

        [NameInMap("importDemoProject")]
        [Validation(Required=false)]
        public bool? ImportDemoProject { get; set; }

        [NameInMap("importRepoType")]
        [Validation(Required=false)]
        public string ImportRepoType { get; set; }

        [NameInMap("importToken")]
        [Validation(Required=false)]
        public string ImportToken { get; set; }

        [NameInMap("importTokenEncrypted")]
        [Validation(Required=false)]
        public string ImportTokenEncrypted { get; set; }

        [NameInMap("importUrl")]
        [Validation(Required=false)]
        public string ImportUrl { get; set; }

        [NameInMap("initStandardService")]
        [Validation(Required=false)]
        public bool? InitStandardService { get; set; }

        [NameInMap("isCryptoEnabled")]
        [Validation(Required=false)]
        public bool? IsCryptoEnabled { get; set; }

        [NameInMap("localImportUrl")]
        [Validation(Required=false)]
        public string LocalImportUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespaceId")]
        [Validation(Required=false)]
        public long? NamespaceId { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("readmeType")]
        [Validation(Required=false)]
        public string ReadmeType { get; set; }

        [NameInMap("visibilityLevel")]
        [Validation(Required=false)]
        public int? VisibilityLevel { get; set; }

        [NameInMap("createParentPath")]
        [Validation(Required=false)]
        public bool? CreateParentPath { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

    }

}
