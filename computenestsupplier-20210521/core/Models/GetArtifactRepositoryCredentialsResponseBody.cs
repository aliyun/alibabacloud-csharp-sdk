// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetArtifactRepositoryCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the resources that can be uploaded.</para>
        /// </summary>
        [NameInMap("AvailableResources")]
        [Validation(Required=false)]
        public List<GetArtifactRepositoryCredentialsResponseBodyAvailableResources> AvailableResources { get; set; }
        public class GetArtifactRepositoryCredentialsResponseBodyAvailableResources : TeaModel {
            /// <summary>
            /// <para>The path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;/xxx/&quot;</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The repository name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>computenest-artifacts-draft-cn-hangzhou</para>
            /// </summary>
            [NameInMap("RepositoryName")]
            [Validation(Required=false)]
            public string RepositoryName { get; set; }

        }

        /// <summary>
        /// <para>The credentials.</para>
        /// </summary>
        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public GetArtifactRepositoryCredentialsResponseBodyCredentials Credentials { get; set; }
        public class GetArtifactRepositoryCredentialsResponseBodyCredentials : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STS.xxx</para>
            /// </summary>
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            /// <summary>
            /// <para>The AccessKey secret.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            /// <summary>
            /// <para>The password.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJ0aW1lIjoiMTUyNjU0OTc5:0705733****</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The Security Token Service (STS) token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The time when the credentials expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1526549792000</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94E89857-B994-44B6-9C4F-DBD200E9XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
