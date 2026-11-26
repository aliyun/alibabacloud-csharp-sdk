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
        /// <para>The SCIM server credential information.</para>
        /// </summary>
        [NameInMap("SCIMServerCredential")]
        [Validation(Required=false)]
        public CreateSCIMServerCredentialResponseBodySCIMServerCredential SCIMServerCredential { get; set; }
        public class CreateSCIMServerCredentialResponseBodySCIMServerCredential : TeaModel {
            /// <summary>
            /// <para>The time when the SCIM server credential was created. The time is in UTC and follows the RFC 3339 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-09T08:12:52Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the SCIM server credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scimcred-004whl0kvfwcypbi****</para>
            /// </summary>
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            /// <summary>
            /// <para>The SCIM server credential secret.</para>
            /// <remarks>
            /// <para>The SCIM server credential secret is returned only when the credential is created and cannot be queried later. Store it securely.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8aAJCtpbyPJ8saXeYDgyw****</para>
            /// </summary>
            [NameInMap("CredentialSecret")]
            [Validation(Required=false)]
            public string CredentialSecret { get; set; }

            /// <summary>
            /// <para>The type of the SCIM server credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BearerToken</para>
            /// </summary>
            [NameInMap("CredentialType")]
            [Validation(Required=false)]
            public string CredentialType { get; set; }

            /// <summary>
            /// <para>The directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-00fc2p61****</para>
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// <para>The time when the SCIM server credential expires. The time is in UTC and follows the RFC 3339 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-09T08:12:52Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The status of the SCIM server credential. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: The credential is enabled.</description></item>
            /// </list>
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
