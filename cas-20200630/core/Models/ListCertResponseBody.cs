// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListCertResponseBodyList> List { get; set; }
        public class ListCertResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The expiration time of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-13 12:59:45</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public string AfterDate { get; set; }

            /// <summary>
            /// <para>The expiration time of the client certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// <remarks>
            /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be both left empty or both specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1728921600000</para>
            /// </summary>
            [NameInMap("AfterTime")]
            [Validation(Required=false)]
            public long? AfterTime { get; set; }

            /// <summary>
            /// <para>The public key algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The alias of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The issuance time of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-19</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public string BeforeDate { get; set; }

            /// <summary>
            /// <para>The issuance time of the client certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// <remarks>
            /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must be both left empty or both specified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1728921600000</para>
            /// </summary>
            [NameInMap("BeforeTime")]
            [Validation(Required=false)]
            public long? BeforeTime { get; set; }

            /// <summary>
            /// <para>The type of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>free</c>: Free certificate.</para>
            /// </description></item>
            /// <item><description><para><c>cas</c>: Alibaba Cloud Security certificate.</para>
            /// </description></item>
            /// <item><description><para><c>upload</c>: A user-uploaded certificate.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Server</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>The primary domain name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.kfsjn.xyz">www.kfsjn.xyz</a></para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>A unique, user-defined identifier for the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para><em><b>b86sca4384811e0b5e8707e68</b></em></para>
            /// </summary>
            [NameInMap("CustomIdentifier")]
            [Validation(Required=false)]
            public string CustomIdentifier { get; set; }

            /// <summary>
            /// <para>A JSON string containing extended attributes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appId&quot;:&quot;APP_PFHMIGUHKDUW6S3N7ZL2&quot;}</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The ID of the data source to which the certificate order belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1806958</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The unique identifier of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1ef539a8-1e1f-6b88-8c11-21cf01a203e9</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>Specifies if the private key is exportable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: The private key is exportable.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: The private key is not exportable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("KeyExportable")]
            [Validation(Required=false)]
            public bool? KeyExportable { get; set; }

            /// <summary>
            /// <para>The organization specified in the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Organization")]
            [Validation(Required=false)]
            public string Organization { get; set; }

            /// <summary>
            /// <para>The organizational unit (OU) specified in the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IT</para>
            /// </summary>
            [NameInMap("OrganizationUnit")]
            [Validation(Required=false)]
            public string OrganizationUnit { get; set; }

            /// <summary>
            /// <para>The certificate serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3a3ee3c3597d675e</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>ISSUE</c>: Issued.</para>
            /// </description></item>
            /// <item><description><para><c>REVOKE</c>: Revoked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>complete</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The distinguished name (DN) of the certificate subject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubjectDn</para>
            /// </summary>
            [NameInMap("SubjectDn")]
            [Validation(Required=false)]
            public string SubjectDn { get; set; }

            /// <summary>
            /// <para>The tags of the certificate.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A token to retrieve the next page of results. If this value is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86sca4384811e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of certificates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
