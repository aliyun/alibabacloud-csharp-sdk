// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListSSLCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSSLCertResponseBodyData> Data { get; set; }
        public class ListSSLCertResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the certificate expired. The time was formatted as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1726039184803</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public string AfterDate { get; set; }

            /// <summary>
            /// <para>The algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The time when the certificate took effect. The time was formatted as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694503184803</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public string BeforeDate { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The domain name with which the certificate is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.test.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The time when the certificate expired. The time was formatted as a GMT timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-11T07:19:44.803+0000</para>
            /// </summary>
            [NameInMap("GmtAfter")]
            [Validation(Required=false)]
            public string GmtAfter { get; set; }

            /// <summary>
            /// <para>The time when the certificate took effect. The time was formatted as a GMT timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-12T07:19:44.803+0000</para>
            /// </summary>
            [NameInMap("GmtBefore")]
            [Validation(Required=false)]
            public string GmtBefore { get; set; }

            /// <summary>
            /// <para>The issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSL</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to perform this operation.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAA9A229-141D-5FBA-AC5C-516C02026A11</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
