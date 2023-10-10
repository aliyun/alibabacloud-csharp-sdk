// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryEccInfoResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the ECC.
        /// </summary>
        [NameInMap("EccInfo")]
        [Validation(Required=false)]
        public QueryEccInfoResponseBodyEccInfo EccInfo { get; set; }
        public class QueryEccInfoResponseBodyEccInfo : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// ECC ID
            /// </summary>
            [NameInMap("EccId")]
            [Validation(Required=false)]
            public string EccId { get; set; }

            /// <summary>
            /// ECU ID
            /// </summary>
            [NameInMap("EcuId")]
            [Validation(Required=false)]
            public string EcuId { get; set; }

            /// <summary>
            /// The ID of the ECC group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the ECC group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The MD5 hash value of the deployment package version.
            /// </summary>
            [NameInMap("PackageMd5")]
            [Validation(Required=false)]
            public string PackageMd5 { get; set; }

            /// <summary>
            /// The version of the deployment package.
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            /// <summary>
            /// VPC ID
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
