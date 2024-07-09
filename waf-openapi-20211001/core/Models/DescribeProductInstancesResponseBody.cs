// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeProductInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the instances.
        /// </summary>
        [NameInMap("ProductInstances")]
        [Validation(Required=false)]
        public List<DescribeProductInstancesResponseBodyProductInstances> ProductInstances { get; set; }
        public class DescribeProductInstancesResponseBodyProductInstances : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource belongs.
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            [NameInMap("ResourceInstanceIp")]
            [Validation(Required=false)]
            public string ResourceInstanceIp { get; set; }

            [NameInMap("ResourceInstanceName")]
            [Validation(Required=false)]
            public string ResourceInstanceName { get; set; }

            /// <summary>
            /// The public IP address of the instance.
            /// </summary>
            [NameInMap("ResourceIp")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceIp { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            [Obsolete]
            public string ResourceName { get; set; }

            /// <summary>
            /// The information about the ports.
            /// </summary>
            [NameInMap("ResourcePorts")]
            [Validation(Required=false)]
            public List<DescribeProductInstancesResponseBodyProductInstancesResourcePorts> ResourcePorts { get; set; }
            public class DescribeProductInstancesResponseBodyProductInstancesResourcePorts : TeaModel {
                /// <summary>
                /// The information about the certificates.
                /// </summary>
                [NameInMap("Certificates")]
                [Validation(Required=false)]
                public List<DescribeProductInstancesResponseBodyProductInstancesResourcePortsCertificates> Certificates { get; set; }
                public class DescribeProductInstancesResponseBodyProductInstancesResourcePortsCertificates : TeaModel {
                    /// <summary>
                    /// The ID of the certificate.
                    /// </summary>
                    [NameInMap("CertificateId")]
                    [Validation(Required=false)]
                    public string CertificateId { get; set; }

                    /// <summary>
                    /// The name of the certificate.
                    /// </summary>
                    [NameInMap("CertificateName")]
                    [Validation(Required=false)]
                    public string CertificateName { get; set; }

                }

                /// <summary>
                /// The port number.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol type. Valid values:
                /// 
                /// *   **http**
                /// *   **https**
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// The cloud service to which the instance belongs. Valid values:
            /// 
            /// *   **clb4**: Layer 4 CLB.
            /// *   **clb7**: Layer 7 CLB.
            /// *   **ecs**: ECS.
            /// </summary>
            [NameInMap("ResourceProduct")]
            [Validation(Required=false)]
            public string ResourceProduct { get; set; }

            /// <summary>
            /// The region ID of the instance. Valid values:
            /// 
            /// *   **cn-chengdu**: China (Chengdu).
            /// *   **cn-beijing**: China (Beijing).
            /// *   **cn-zhangjiakou**: China (Zhangjiakou).
            /// *   **cn-hangzhou**: China (Hangzhou).
            /// *   **cn-shanghai**: China (Shanghai).
            /// *   **cn-shenzhen**: China (Shenzhen).
            /// *   **cn-qingdao**: China (Qingdao).
            /// *   **cn-hongkong**: China (Hong Kong).
            /// *   **ap-southeast-3**: Malaysia (Kuala Lumpur).
            /// *   **ap-southeast-5**: Indonesia (Jakarta).
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
