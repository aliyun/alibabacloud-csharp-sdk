// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetUserTmpIdentityForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <para>Result of the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetUserTmpIdentityForPartnerResponseBodyData Data { get; set; }
        public class GetUserTmpIdentityForPartnerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Credential</para>
            /// </summary>
            [NameInMap("Credentials")]
            [Validation(Required=false)]
            public GetUserTmpIdentityForPartnerResponseBodyDataCredentials Credentials { get; set; }
            public class GetUserTmpIdentityForPartnerResponseBodyDataCredentials : TeaModel {
                /// <summary>
                /// <para>Encrypted temporary AccessKey ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>7t2Rzt37ND7-xxx</para>
                /// </summary>
                [NameInMap("EncryptedAccessKeyId")]
                [Validation(Required=false)]
                public string EncryptedAccessKeyId { get; set; }

                /// <summary>
                /// <para>Encrypted temporary AccessKey secret</para>
                /// 
                /// <b>Example:</b>
                /// <para>7t2Rzt37ND7-xxx</para>
                /// </summary>
                [NameInMap("EncryptedAccessKeySecret")]
                [Validation(Required=false)]
                public string EncryptedAccessKeySecret { get; set; }

                /// <summary>
                /// <para>Encrypted Security Token Service token</para>
                /// 
                /// <b>Example:</b>
                /// <para>7t2Rzt37ND7-xxx</para>
                /// </summary>
                [NameInMap("EncryptedSecurityToken")]
                [Validation(Required=false)]
                public string EncryptedSecurityToken { get; set; }

                /// <summary>
                /// <para>Expected expiration time of the certificate</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-29T14:00:00Z</para>
                /// </summary>
                [NameInMap("Expiration")]
                [Validation(Required=false)]
                public string Expiration { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether authorization from the Customer has been obtained.</para>
            /// </summary>
            [NameInMap("HasCustomRoleAuth")]
            [Validation(Required=false)]
            public bool? HasCustomRoleAuth { get; set; }

        }

        /// <summary>
        /// <para>error code. The value is interpreted as follows: If the request succeeded, the ErrorCode field is not returned. If the request failed, the ErrorCode field is returned. For more information, see the error code List in this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliuid:1998006665794443 assumeRole not exist,serviceName:realtimelogpush.dcdnservices.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
