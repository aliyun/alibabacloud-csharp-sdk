// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainCloudAccountRoleAccessCredentialResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ca_01kmegjc11qa1txxxxx</para>
        /// </summary>
        [NameInMap("cloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        [NameInMap("cloudAccountRoleAccessCredential")]
        [Validation(Required=false)]
        public ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredential CloudAccountRoleAccessCredential { get; set; }
        public class ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredential : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1767196800</para>
            /// </summary>
            [NameInMap("accessCredentialExpiresAt")]
            [Validation(Required=false)]
            public long? AccessCredentialExpiresAt { get; set; }

            [NameInMap("alibabaCloudStsToken")]
            [Validation(Required=false)]
            public ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredentialAlibabaCloudStsToken AlibabaCloudStsToken { get; set; }
            public class ObtainCloudAccountRoleAccessCredentialResponseBodyCloudAccountRoleAccessCredentialAlibabaCloudStsToken : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>STS.NUgYrLnoC37mZZCNnAbez****</para>
                /// </summary>
                [NameInMap("accessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CVwjCkNzTMupZ8NbTCxCBRq3K16jtcWFTJAyBEv2****</para>
                /// </summary>
                [NameInMap("accessKeySecret")]
                [Validation(Required=false)]
                public string AccessKeySecret { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-10-20T04:27:09Z</para>
                /// </summary>
                [NameInMap("expiration")]
                [Validation(Required=false)]
                public string Expiration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CAIShwJ1q6Ft5B2yfSjIr5bSEsj4g7BihPWGWHz****</para>
                /// </summary>
                [NameInMap("securityToken")]
                [Validation(Required=false)]
                public string SecurityToken { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::xxx:role/role-test</para>
        /// </summary>
        [NameInMap("cloudAccountRoleExternalId")]
        [Validation(Required=false)]
        public string CloudAccountRoleExternalId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>carole_01kmek49aqxxxx</para>
        /// </summary>
        [NameInMap("cloudAccountRoleId")]
        [Validation(Required=false)]
        public string CloudAccountRoleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>role-test</para>
        /// </summary>
        [NameInMap("cloudAccountRoleName")]
        [Validation(Required=false)]
        public string CloudAccountRoleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alibaba_cloud</para>
        /// </summary>
        [NameInMap("cloudAccountVendorType")]
        [Validation(Required=false)]
        public string CloudAccountVendorType { get; set; }

    }

}
