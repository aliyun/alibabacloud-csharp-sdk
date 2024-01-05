// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppWebUiAddressResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSparkAppWebUiAddressResponseBodyData Data { get; set; }
        public class GetSparkAppWebUiAddressResponseBodyData : TeaModel {
            /// <summary>
            /// The Spark application ID.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The database ID.
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// The expiration time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
