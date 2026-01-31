// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstanceList> InstanceList { get; set; }
        public class ListInstancesResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("AutoReissue")]
            [Validation(Required=false)]
            public string AutoReissue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DigiCert</para>
            /// </summary>
            [NameInMap("Brand")]
            [Validation(Required=false)]
            public string Brand { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>21795675-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18541349</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public long? CertificateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cert-13216408</para>
            /// </summary>
            [NameInMap("CertificateName")]
            [Validation(Required=false)]
            public string CertificateName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("CertificateNotAfter")]
            [Validation(Required=false)]
            public long? CertificateNotAfter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("CertificateRevokeTime")]
            [Validation(Required=false)]
            public long? CertificateRevokeTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>issued</para>
            /// </summary>
            [NameInMap("CertificateStatus")]
            [Validation(Required=false)]
            public string CertificateStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DV</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public string CertificateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FullDomainCount")]
            [Validation(Required=false)]
            public int? FullDomainCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("InstanceEndTime")]
            [Validation(Required=false)]
            public long? InstanceEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cas_dv-cn-123</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("InstanceStartTime")]
            [Validation(Required=false)]
            public long? InstanceStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RSA_2048</para>
            /// </summary>
            [NameInMap("KeyAlgorithm")]
            [Validation(Required=false)]
            public string KeyAlgorithm { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("OrderEndTime")]
            [Validation(Required=false)]
            public long? OrderEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1801324800000</para>
            /// </summary>
            [NameInMap("OrderStartTime")]
            [Validation(Required=false)]
            public long? OrderStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pending</para>
            /// </summary>
            [NameInMap("PendingResult")]
            [Validation(Required=false)]
            public string PendingResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ss.dv.t</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inactive</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WildcardDomainCount")]
            [Validation(Required=false)]
            public int? WildcardDomainCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
