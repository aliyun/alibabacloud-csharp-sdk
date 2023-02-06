// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetArtifactRepositoryCredentialsResponseBody : TeaModel {
        [NameInMap("AvailableResources")]
        [Validation(Required=false)]
        public List<GetArtifactRepositoryCredentialsResponseBodyAvailableResources> AvailableResources { get; set; }
        public class GetArtifactRepositoryCredentialsResponseBodyAvailableResources : TeaModel {
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RepositoryName")]
            [Validation(Required=false)]
            public string RepositoryName { get; set; }

        }

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public GetArtifactRepositoryCredentialsResponseBodyCredentials Credentials { get; set; }
        public class GetArtifactRepositoryCredentialsResponseBodyCredentials : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
