// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class CreateSCIMServerCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D2E5180-7ACF-57FF-A56C-26A49ABEBFF7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the SCIM credential.</para>
        /// </summary>
        [NameInMap("SCIMServerCredential")]
        [Validation(Required=false)]
        public CreateSCIMServerCredentialResponseBodySCIMServerCredential SCIMServerCredential { get; set; }
        public class CreateSCIMServerCredentialResponseBodySCIMServerCredential : TeaModel {
            /// <summary>
            /// <para>The time when the SCIM credential was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-09T08:12:52Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the SCIM credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scimcred-004whl0kvfwcypbi****</para>
            /// </summary>
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// <para>The SCIM credential.</para>
            /// <remarks>
            /// <para> The SCIM credential is returned only when it is created. After the SCIM credential is created, you cannot query it. Keep the SCIM credential confidential.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8aAJCtpbyPJ8saXeYDgyw****</para>
            /// </summary>
            [NameInMap("CredentialSecret")]
            [Validation(Required=false)]
            public string CredentialSecret { get; set; }

            /// <summary>
            /// <para>The type of the SCIM credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BearerToken</para>
            /// </summary>
            [NameInMap("CredentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// <para>The ID of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-00fc2p61****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The time when the SCIM credential expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-09T08:12:52Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The status of the SCIM credential. The value is fixed as Enabled, which indicates that the SCIM credential is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
