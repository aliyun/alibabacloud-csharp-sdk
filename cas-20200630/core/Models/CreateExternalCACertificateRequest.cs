// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateExternalCACertificateRequest : TeaModel {
        [NameInMap("ApiPassthrough")]
        [Validation(Required=false)]
        public CreateExternalCACertificateRequestApiPassthrough ApiPassthrough { get; set; }
        public class CreateExternalCACertificateRequestApiPassthrough : TeaModel {
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public CreateExternalCACertificateRequestApiPassthroughExtensions Extensions { get; set; }
            public class CreateExternalCACertificateRequestApiPassthroughExtensions : TeaModel {
                [NameInMap("ExtendedKeyUsages")]
                [Validation(Required=false)]
                public List<string> ExtendedKeyUsages { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PathLenConstraint")]
                [Validation(Required=false)]
                public int? PathLenConstraint { get; set; }

            }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public CreateExternalCACertificateRequestApiPassthroughSubject Subject { get; set; }
            public class CreateExternalCACertificateRequestApiPassthroughSubject : TeaModel {
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("Locality")]
                [Validation(Required=false)]
                public string Locality { get; set; }

                [NameInMap("Organization")]
                [Validation(Required=false)]
                public string Organization { get; set; }

                [NameInMap("OrganizationUnit")]
                [Validation(Required=false)]
                public string OrganizationUnit { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----
        /// MIIBczCCARgCAQAwgYoxFDASBgNVBAMMC2FsaXl1bi50ZXN0MQ0wCwYDVQQ
        /// ...
        /// vbIgMQIhAKHDWD6/WAMbtezAt4bysJ/BZIDz1jPWuUR5GV4TJ/mS
        /// -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas_deposit-cn-1234abcd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10y</para>
        /// </summary>
        [NameInMap("Validity")]
        [Validation(Required=false)]
        public string Validity { get; set; }

    }

}
