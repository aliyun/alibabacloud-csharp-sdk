// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDownloadURLResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The download URLs of data files.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataDownloadURLResponseBodyData Data { get; set; }
        public class DescribeDataDownloadURLResponseBodyData : TeaModel {
            /// <summary>
            /// The time when the data file expires. The time is displayed in UTC.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The file servers.
            /// </summary>
            [NameInMap("ServerList")]
            [Validation(Required=false)]
            public List<DescribeDataDownloadURLResponseBodyDataServerList> ServerList { get; set; }
            public class DescribeDataDownloadURLResponseBodyDataServerList : TeaModel {
                /// <summary>
                /// The host address of the file server.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// The ID of the Edge Node Service (ENS) node.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

            /// <summary>
            /// The download URL of the data file.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// The response message. Success is returned for a successful request.
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
