// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListSCIMServerCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE4B7037-C315-5DD5-826E-57A87950BCD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SCIM credentials.</para>
        /// </summary>
        [NameInMap("SCIMServerCredentials")]
        [Validation(Required=false)]
        public List<ListSCIMServerCredentialsResponseBodySCIMServerCredentials> SCIMServerCredentials { get; set; }
        public class ListSCIMServerCredentialsResponseBodySCIMServerCredentials : TeaModel {
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
            /// <item><description>Enabled</description></item>
            /// <item><description>Disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
