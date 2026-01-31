// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetInstanceDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("AutoReissue")]
        [Validation(Required=false)]
        public string AutoReissue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("AverageWaitingTime")]
        [Validation(Required=false)]
        public string AverageWaitingTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DigiCert</para>
        /// </summary>
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22783111-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public int? CertificateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
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
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>47305</para>
        /// </summary>
        [NameInMap("CompanyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        [NameInMap("ContactIdList")]
        [Validation(Required=false)]
        public List<long?> ContactIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----   ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        [NameInMap("DingGroupList")]
        [Validation(Required=false)]
        public List<GetInstanceDetailResponseBodyDingGroupList> DingGroupList { get; set; }
        public class GetInstanceDetailResponseBodyDingGroupList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DingGroupInstanceId")]
            [Validation(Required=false)]
            public string DingGroupInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DingGroupName")]
            [Validation(Required=false)]
            public string DingGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>remote</para>
            /// </summary>
            [NameInMap("DingGroupType")]
            [Validation(Required=false)]
            public string DingGroupType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://123.com">https://123.com</a></para>
            /// </summary>
            [NameInMap("DingGroupUrl")]
            [Validation(Required=false)]
            public string DingGroupUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("DomainValidationList")]
        [Validation(Required=false)]
        public List<GetInstanceDetailResponseBodyDomainValidationList> DomainValidationList { get; set; }
        public class GetInstanceDetailResponseBodyDomainValidationList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("RootDomain")]
            [Validation(Required=false)]
            public string RootDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>@</para>
            /// </summary>
            [NameInMap("ValidationKey")]
            [Validation(Required=false)]
            public string ValidationKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TXT</para>
            /// </summary>
            [NameInMap("ValidationType")]
            [Validation(Required=false)]
            public string ValidationType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ValidationValue")]
            [Validation(Required=false)]
            public string ValidationValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FullDomainCount")]
        [Validation(Required=false)]
        public int? FullDomainCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("GenerateCsrMethod")]
        [Validation(Required=false)]
        public string GenerateCsrMethod { get; set; }

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
        /// <para>TEST</para>
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
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B2CE1D02-6D5E-56E5-A9BD-EE288255C7F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetInstanceDetailResponseBodyTags> Tags { get; set; }
        public class GetInstanceDetailResponseBodyTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("ValidationMethod")]
        [Validation(Required=false)]
        public string ValidationMethod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WildcardDomainCount")]
        [Validation(Required=false)]
        public int? WildcardDomainCount { get; set; }

    }

}
