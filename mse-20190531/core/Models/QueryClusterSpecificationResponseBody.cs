// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryClusterSpecificationResponseBody : TeaModel {
        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryClusterSpecificationResponseBodyData> Data { get; set; }
        public class QueryClusterSpecificationResponseBodyData : TeaModel {
            /// <summary>
            /// The engine specifications that can be used.
            /// </summary>
            [NameInMap("ClusterSpecificationName")]
            [Validation(Required=false)]
            public string ClusterSpecificationName { get; set; }

            /// <summary>
            /// The number of vCPUs in the specifications.
            /// </summary>
            [NameInMap("CpuCapacity")]
            [Validation(Required=false)]
            public string CpuCapacity { get; set; }

            /// <summary>
            /// The memory size in the specifications. Unit: GB.
            /// </summary>
            [NameInMap("MemoryCapacity")]
            [Validation(Required=false)]
            public string MemoryCapacity { get; set; }

        }

        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
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

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
