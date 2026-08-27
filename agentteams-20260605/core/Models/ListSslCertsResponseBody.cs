// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class ListSslCertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This field is typically empty when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[...]</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListSslCertsResponseBodyItems> Items { get; set; }
        public class ListSslCertsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The certificate algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public long? CertId { get; set; }

            /// <summary>
            /// <para>The certificate identifier used by APIG. Pass this value when creating or updating an HTTPS domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22584627-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-cert</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate chain is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ChainCompleted")]
            [Validation(Required=false)]
            public bool? ChainCompleted { get; set; }

            /// <summary>
            /// <para>The certificate common name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The certificate domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The certificate issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DigiCert</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The expiration timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1893456000000</para>
            /// </summary>
            [NameInMap("NotAfterTimestamp")]
            [Validation(Required=false)]
            public long? NotAfterTimestamp { get; set; }

            /// <summary>
            /// <para>The effective period UNIX timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1704067200000</para>
            /// </summary>
            [NameInMap("NotBeforeTimestamp")]
            [Validation(Required=false)]
            public long? NotBeforeTimestamp { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. The value is <c>null</c> if no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-123</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
