// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class UpdateSCIMServerCredentialStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C086C2F-1C66-57B3-B14E-2C1DA70727CD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the SCIM credential.</para>
        /// </summary>
        [NameInMap("SCIMServerCredential")]
        [Validation(Required=false)]
        public UpdateSCIMServerCredentialStatusResponseBodySCIMServerCredential SCIMServerCredential { get; set; }
        public class UpdateSCIMServerCredentialStatusResponseBodySCIMServerCredential : TeaModel {
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
            /// <para>The status of the SCIM credential. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: The SCIM credential is enabled.</description></item>
            /// <item><description>Disabled: The SCIM credential is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
