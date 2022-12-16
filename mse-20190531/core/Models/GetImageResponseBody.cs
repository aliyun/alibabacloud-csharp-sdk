// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetImageResponseBody : TeaModel {
        /// <summary>
        /// The details of the data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetImageResponseBodyData Data { get; set; }
        public class GetImageResponseBodyData : TeaModel {
            /// <summary>
            /// The full name of the current cluster image version. The full name is in the X.X.X.X format.
            /// </summary>
            [NameInMap("CurrentVersionFullShowName")]
            [Validation(Required=false)]
            public string CurrentVersionFullShowName { get; set; }

            /// <summary>
            /// The URL of change logs for the latest version that can be updated to.
            /// </summary>
            [NameInMap("MaxVersionChangelogUrl")]
            [Validation(Required=false)]
            public string MaxVersionChangelogUrl { get; set; }

            /// <summary>
            /// The code of the latest version that can be updated to.
            /// </summary>
            [NameInMap("MaxVersionCode")]
            [Validation(Required=false)]
            public string MaxVersionCode { get; set; }

            /// <summary>
            /// The full name of the latest version that can be updated to.
            /// </summary>
            [NameInMap("MaxVersionFullShowName")]
            [Validation(Required=false)]
            public string MaxVersionFullShowName { get; set; }

        }

        /// <summary>
        /// The error code returned if the request fails.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// - `true`: The request is successful. 
        /// - `false`: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
