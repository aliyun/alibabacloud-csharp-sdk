// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppWebUiAddressResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppWebUiAddressResponseBodyData Data { get; set; }
        public class GetSparkAppWebUiAddressResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Spark application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The ID of the Database.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The expiration time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("ExpirationTimeInMillis")]
            [Validation(Required=false)]
            public long? ExpirationTimeInMillis { get; set; }

            /// <summary>
            /// The URL of the web UI for the Spark application.
            /// </summary>
            [NameInMap("WebUiAddress")]
            [Validation(Required=false)]
            public string WebUiAddress { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
