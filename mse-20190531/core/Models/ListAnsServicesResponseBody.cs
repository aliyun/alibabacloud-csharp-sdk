// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsServicesResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAnsServicesResponseBodyData> Data { get; set; }
        public class ListAnsServicesResponseBodyData : TeaModel {
            /// <summary>
            /// The total number of clusters.
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            /// <summary>
            /// The name of the contact group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The total number of instances with healthy heartbeats.
            /// </summary>
            [NameInMap("HealthyInstanceCount")]
            [Validation(Required=false)]
            public int? HealthyInstanceCount { get; set; }

            /// <summary>
            /// The total number of instances that are used for the current service.
            /// </summary>
            [NameInMap("IpCount")]
            [Validation(Required=false)]
            public int? IpCount { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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

        /// <summary>
        /// The total number of instances returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
