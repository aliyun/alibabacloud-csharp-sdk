// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCloudAccessResponseBody : TeaModel {
        /// <summary>
        /// The list of the AccessKey pairs.
        /// </summary>
        [NameInMap("CloudAccessList")]
        [Validation(Required=false)]
        public List<ListCloudAccessResponseBodyCloudAccessList> CloudAccessList { get; set; }
        public class ListCloudAccessResponseBodyCloudAccessList : TeaModel {
            /// <summary>
            /// The AccessKey ID used to access the cloud service.
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public long? AccessId { get; set; }

            /// <summary>
            /// The cloud service provider.
            /// </summary>
            [NameInMap("CloudName")]
            [Validation(Required=false)]
            public string CloudName { get; set; }

            /// <summary>
            /// The AccessKey secret used to access the cloud service.
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

            /// <summary>
            /// The status of the service.
            /// </summary>
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }

        }

        /// <summary>
        /// The page number. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of revoked certificates per page. Default value: **20**.
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
