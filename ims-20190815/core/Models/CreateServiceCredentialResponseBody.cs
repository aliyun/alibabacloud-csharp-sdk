// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateServiceCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81313F5E-3C85-478F-BCC9-E1B70E4556DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service credential information.</para>
        /// </summary>
        [NameInMap("ServiceCredential")]
        [Validation(Required=false)]
        public CreateServiceCredentialResponseBodyServiceCredential ServiceCredential { get; set; }
        public class CreateServiceCredentialResponseBodyServiceCredential : TeaModel {
            /// <summary>
            /// <para>The time when the service credential was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T10:05:24Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the service credential.
            /// This field is not returned for permanently valid service credentials.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-02-01T10:05:24Z</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The service credential ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SC*************</para>
            /// </summary>
            [NameInMap("ServiceCredentialId")]
            [Validation(Required=false)]
            public string ServiceCredentialId { get; set; }

            /// <summary>
            /// <para>The service credential name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourServiceCredentialName</para>
            /// </summary>
            [NameInMap("ServiceCredentialName")]
            [Validation(Required=false)]
            public string ServiceCredentialName { get; set; }

            /// <summary>
            /// <para>The secret of the service credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourServiceCredentialSecret</para>
            /// </summary>
            [NameInMap("ServiceCredentialSecret")]
            [Validation(Required=false)]
            public string ServiceCredentialSecret { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The status of the service credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The logon name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

    }

}
