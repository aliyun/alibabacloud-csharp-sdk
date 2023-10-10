// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryRegionConfigResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information about region configurations.
        /// </summary>
        [NameInMap("RegionConfig")]
        [Validation(Required=false)]
        public QueryRegionConfigResponseBodyRegionConfig RegionConfig { get; set; }
        public class QueryRegionConfigResponseBodyRegionConfig : TeaModel {
            /// <summary>
            /// The domain name of Address Server.
            /// </summary>
            [NameInMap("AddressServerHost")]
            [Validation(Required=false)]
            public string AddressServerHost { get; set; }

            /// <summary>
            /// The installation path of the script for EDAS Agent.
            /// </summary>
            [NameInMap("AgentInstallScript")]
            [Validation(Required=false)]
            public string AgentInstallScript { get; set; }

            /// <summary>
            /// The information about the file server.
            /// </summary>
            [NameInMap("FileServerConfig")]
            [Validation(Required=false)]
            public QueryRegionConfigResponseBodyRegionConfigFileServerConfig FileServerConfig { get; set; }
            public class QueryRegionConfigResponseBodyRegionConfigFileServerConfig : TeaModel {
                /// <summary>
                /// The Object Storage Service (OSS) bucket of the file server.
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// The internal endpoint of the file server.
                /// </summary>
                [NameInMap("InternalUrl")]
                [Validation(Required=false)]
                public string InternalUrl { get; set; }

                /// <summary>
                /// The public endpoint of the file server.
                /// </summary>
                [NameInMap("PublicUrl")]
                [Validation(Required=false)]
                public string PublicUrl { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) endpoint of the file server.
                /// </summary>
                [NameInMap("VpcUrl")]
                [Validation(Required=false)]
                public string VpcUrl { get; set; }

            }

            /// <summary>
            /// The type of the file server.
            /// </summary>
            [NameInMap("FileServerType")]
            [Validation(Required=false)]
            public string FileServerType { get; set; }

            /// <summary>
            /// The configured ID of the region.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The ID of the official image.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// The configured name of the region.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The serial number of the region. This parameter is deprecated.
            /// </summary>
            [NameInMap("No")]
            [Validation(Required=false)]
            public int? No { get; set; }

            /// <summary>
            /// The tag of the region. The value is fixed to `ALIYUN_SHARE`.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
