// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyCloudResourceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public ModifyCloudResourceRequestListen Listen { get; set; }
        public class ModifyCloudResourceRequestListen : TeaModel {
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<ModifyCloudResourceRequestListenCertificates> Certificates { get; set; }
            public class ModifyCloudResourceRequestListenCertificates : TeaModel {
                [NameInMap("AppliedType")]
                [Validation(Required=false)]
                public string AppliedType { get; set; }

                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

            }

            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public int? CipherSuite { get; set; }

            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

        }

        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public ModifyCloudResourceRequestRedirect Redirect { get; set; }
        public class ModifyCloudResourceRequestRedirect : TeaModel {
            [NameInMap("Keepalive")]
            [Validation(Required=false)]
            public bool? Keepalive { get; set; }

            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<ModifyCloudResourceRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class ModifyCloudResourceRequestRedirectRequestHeaders : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

            [NameInMap("XffProto")]
            [Validation(Required=false)]
            public bool? XffProto { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
