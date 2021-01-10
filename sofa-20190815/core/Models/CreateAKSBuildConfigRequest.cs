// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateAKSBuildConfigRequest : TeaModel {
        [NameInMap("AppBuildName")]
        [Validation(Required=false)]
        public string AppBuildName { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("CompileDir")]
        [Validation(Required=false)]
        public string CompileDir { get; set; }

        [NameInMap("CompileDockerfile")]
        [Validation(Required=false)]
        public string CompileDockerfile { get; set; }

        [NameInMap("ExternalDockerCredential")]
        [Validation(Required=false)]
        public string ExternalDockerCredential { get; set; }

        [NameInMap("ExternalImageName")]
        [Validation(Required=false)]
        public string ExternalImageName { get; set; }

        [NameInMap("GitlabAccessId")]
        [Validation(Required=false)]
        public string GitlabAccessId { get; set; }

        [NameInMap("GitlabAccessToken")]
        [Validation(Required=false)]
        public string GitlabAccessToken { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ScmUrl")]
        [Validation(Required=false)]
        public string ScmUrl { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

        [NameInMap("DockerCredential")]
        [Validation(Required=false)]
        public List<CreateAKSBuildConfigRequestDockerCredential> DockerCredential { get; set; }
        public class CreateAKSBuildConfigRequestDockerCredential : TeaModel {
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
