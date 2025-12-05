// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateCertificateStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate. The ID must be globally unique in Certificates Manager.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9a28de48-8d8b-484d-a766-dec4****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// <para>The status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>INACTIVE: The certificate is disabled.</para>
        /// </description></item>
        /// <item><description><para>ACTIVE: The certificate is enabled.</para>
        /// </description></item>
        /// <item><description><para>REVOKED: The certificate is revoked.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the certificate is in the REVOKED state, you can use the certificate only to verify a signature, but not to generate a signature.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
