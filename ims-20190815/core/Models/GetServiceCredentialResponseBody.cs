// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetServiceCredentialResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66815255-7CCE-4759-AC37-9755794C3626</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service credential information.</para>
        /// </summary>
        [NameInMap("ServiceCredential")]
        [Validation(Required=false)]
        public GetServiceCredentialResponseBodyServiceCredential ServiceCredential { get; set; }
        public class GetServiceCredentialResponseBodyServiceCredential : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-15T09:20:58Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time. This field is not returned for permanent service credentials.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-15T09:20:58Z</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The service credential ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SC***************</para>
            /// </summary>
            [NameInMap("ServiceCredentialId")]
            [Validation(Required=false)]
            public string ServiceCredentialId { get; set; }

            /// <summary>
            /// <para>The service credential name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ServiceCredentialName")]
            [Validation(Required=false)]
            public string ServiceCredentialName { get; set; }

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
            /// <para>The service credential status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The logon name of the Resource Access Management (RAM) user.</para>
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
