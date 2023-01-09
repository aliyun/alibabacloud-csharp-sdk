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
            /// The full version number of the current instance image. The parameter is in the X.X.X.X format.
            /// </summary>
            [NameInMap("CurrentVersionFullShowName")]
            [Validation(Required=false)]
            public string CurrentVersionFullShowName { get; set; }

            /// <summary>
            /// The URL of the changelog for the maximum version to which the current version can be upgraded.
            /// </summary>
            [NameInMap("MaxVersionChangelogUrl")]
            [Validation(Required=false)]
            public string MaxVersionChangelogUrl { get; set; }

            /// <summary>
            /// The code of the maximum version to which the current version can be upgraded.
            /// </summary>
            [NameInMap("MaxVersionCode")]
            [Validation(Required=false)]
            public string MaxVersionCode { get; set; }

            /// <summary>
            /// The full number of the maximum version to which the current version can be upgraded.
            /// </summary>
            [NameInMap("MaxVersionFullShowName")]
            [Validation(Required=false)]
            public string MaxVersionFullShowName { get; set; }

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
