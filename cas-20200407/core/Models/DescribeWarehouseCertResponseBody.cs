// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeWarehouseCertResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The status of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>issued</para>
        /// </summary>
        [NameInMap("CertStatus")]
        [Validation(Required=false)]
        public string CertStatus { get; set; }

        /// <summary>
        /// <para>The type of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OV</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The common name of the certificate subject. This field is empty if the certificate subject does not include a common name (CN).</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyundoc.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The content of the certificate, including the certificate chain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>---BEGIN CERTIFICATE----- MIIF...... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The fingerprint of the certificate content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1291AF83F48170E48140FDFE5DADC19FE51F261</para>
        /// </summary>
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// <para>The common name (or organization name) of the issuer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Digicert</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The unique identifier of the issuer certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("IssuerIdentifier")]
        [Validation(Required=false)]
        public string IssuerIdentifier { get; set; }

        /// <summary>
        /// <para>The instance ID of the private CA instance associated with the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("PrivateCaInstanceId")]
        [Validation(Required=false)]
        public string PrivateCaInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the private CA instance associated with the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("PrivateCaRegionId")]
        [Validation(Required=false)]
        public string PrivateCaRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The instance ID of the certificate warehouse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66</para>
        /// </summary>
        [NameInMap("WarehouseInstanceId")]
        [Validation(Required=false)]
        public string WarehouseInstanceId { get; set; }

    }

}
