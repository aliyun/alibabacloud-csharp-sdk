// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRetcodeLogstoreResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRetcodeLogstoreResponseBodyData Data { get; set; }
        public class GetRetcodeLogstoreResponseBodyData : TeaModel {
            /// <summary>
            /// The content of the log.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The information about Log Service.
            /// </summary>
            [NameInMap("RetcodeSLSConfig")]
            [Validation(Required=false)]
            public GetRetcodeLogstoreResponseBodyDataRetcodeSLSConfig RetcodeSLSConfig { get; set; }
            public class GetRetcodeLogstoreResponseBodyDataRetcodeSLSConfig : TeaModel {
                /// <summary>
                /// The Log Service Logstore.
                /// </summary>
                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// The Log Service project.
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// The status of the request.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
