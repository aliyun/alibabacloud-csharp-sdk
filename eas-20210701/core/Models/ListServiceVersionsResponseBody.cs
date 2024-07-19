// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceVersionsResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
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

        /// <summary>
        /// The historical versions of the service.
        /// </summary>
        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<ListServiceVersionsResponseBodyVersions> Versions { get; set; }
        public class ListServiceVersionsResponseBodyVersions : TeaModel {
            /// <summary>
            /// The time when the service version was created. The time is displayed in UTC.
            /// </summary>
            [NameInMap("BuildTime")]
            [Validation(Required=false)]
            public string BuildTime { get; set; }

            /// <summary>
            /// Indicates whether the image is available. Valid values:
            /// 
            /// *   true: The image is available.
            /// *   false: The image is unavailable.
            /// *   unknown: The availability of the image is unknown.
            /// </summary>
            [NameInMap("ImageAvailable")]
            [Validation(Required=false)]
            public string ImageAvailable { get; set; }

            /// <summary>
            /// The image ID.
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public int? ImageId { get; set; }

            /// <summary>
            /// The returned message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The service deployment configurations. This parameter is returned only if the service is deployed by using a custom image.
            /// </summary>
            [NameInMap("ServiceConfig")]
            [Validation(Required=false)]
            public string ServiceConfig { get; set; }

            /// <summary>
            /// Indicates whether Elastic Algorithm service (EAS) is activated. Valid values:
            /// 
            /// *   true: EAS is activated.
            /// *   false: EAS is not activated.
            /// *   unknown: The activation of EAS is unknown.
            /// </summary>
            [NameInMap("ServiceRunnable")]
            [Validation(Required=false)]
            public string ServiceRunnable { get; set; }

        }

    }

}
