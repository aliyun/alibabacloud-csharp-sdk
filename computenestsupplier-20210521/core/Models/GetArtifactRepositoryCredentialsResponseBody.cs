// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetArtifactRepositoryCredentialsResponseBody : TeaModel {
        /// <summary>
        /// The information about the resources that can be uploaded.
        /// </summary>
        [NameInMap("AvailableResources")]
        [Validation(Required=false)]
        public List<GetArtifactRepositoryCredentialsResponseBodyAvailableResources> AvailableResources { get; set; }
        public class GetArtifactRepositoryCredentialsResponseBodyAvailableResources : TeaModel {
            /// <summary>
            /// The path.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The repository name.
            /// </summary>
            [NameInMap("RepositoryName")]
            [Validation(Required=false)]
            public string RepositoryName { get; set; }

        }

        /// <summary>
        /// The credentials.
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public GetArtifactRepositoryCredentialsResponseBodyCredentials Credentials { get; set; }
        public class GetArtifactRepositoryCredentialsResponseBodyCredentials : TeaModel {
            /// <summary>
            /// The AccessKey ID.
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// The AccessKey secret.
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// The password.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The Security Token Service (STS) token.
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// The username.
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// The time when the credentials expired.
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
