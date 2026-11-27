// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class AssociateAdditionalCertificatesWithListenerRequest : TeaModel {
        /// <summary>
        /// <para>The list of additional certificates.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<AssociateAdditionalCertificatesWithListenerRequestCertificates> Certificates { get; set; }
        public class AssociateAdditionalCertificatesWithListenerRequestCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate. Only server certificates are supported.</para>
            /// <remarks>
            /// <para>The certificate ID is a globally unique ID that ends with a region ID, such as 1011****-cn-hangzhou.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1011****-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3F******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: prechecks the request without associating the additional certificates with the HTTPS or QUIC listener. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the request fails the precheck, the system returns an error. If the request passes the precheck, the system returns the <c>DryRunOperation</c> error code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. If the request passes the precheck, the system returns an HTTP <c>2xx</c> status code and performs the operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the listener.</para>
        /// <para>This parameter is valid only for HTTPS and QUIC listeners.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-5qnirjhpt******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
