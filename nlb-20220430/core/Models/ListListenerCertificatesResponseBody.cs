// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListListenerCertificatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The server certificates.</para>
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// <para>The certificates.</para>
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<ListListenerCertificatesResponseBodyCertificates> Certificates { get; set; }
        public class ListListenerCertificatesResponseBodyCertificates : TeaModel {
            /// <summary>
            /// <para>The certificate ID. Only server certificates are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12315790343_166f8204689_1714763408_70998****</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>The certificate type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Server</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <para>Specifies whether the certificate is the default certificate for the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The certificate is the default certificate.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The certificate is an additional certificate.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The association status between the certificate and the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Associating</b>: The certificate is being associated.</para>
            /// </description></item>
            /// <item><description><para><b>Associated</b>: The certificate is associated.</para>
            /// </description></item>
            /// <item><description><para><b>Diassociating</b>: The certificate is being dissociated.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Associating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query.</para>
        /// <list type="bullet">
        /// <item><description>Leave this parameter empty for the first query or when no subsequent query is required.</description></item>
        /// <item><description>For subsequent queries, set this parameter to the NextToken value returned by the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2198BD6D-9EBB-5E1C-9C48-E0ABB79CF831</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
