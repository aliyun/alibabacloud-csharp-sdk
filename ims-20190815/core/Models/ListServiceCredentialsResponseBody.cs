// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListServiceCredentialsResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether there is a next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE*******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D80A0F97-6F12-5CD1-A70A-77A03BF4CFC5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of service credentials.</para>
        /// </summary>
        [NameInMap("ServiceCredentials")]
        [Validation(Required=false)]
        public List<ListServiceCredentialsResponseBodyServiceCredentials> ServiceCredentials { get; set; }
        public class ListServiceCredentialsResponseBodyServiceCredentials : TeaModel {
            /// <summary>
            /// <para>The time when the service credential was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T05:49:57Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time. This field is not returned for permanent service credentials.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-07T05:49:57Z</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The ID of the service credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SC*************</para>
            /// </summary>
            [NameInMap("ServiceCredentialId")]
            [Validation(Required=false)]
            public string ServiceCredentialId { get; set; }

            /// <summary>
            /// <para>The name of the service credential.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ServiceCredentialName")]
            [Validation(Required=false)]
            public string ServiceCredentialName { get; set; }

            /// <summary>
            /// <para>The service name of the Alibaba Cloud service.</para>
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
