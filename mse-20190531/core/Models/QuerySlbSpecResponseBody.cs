// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QuerySlbSpecResponseBody : TeaModel {
        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data entries returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QuerySlbSpecResponseBodyData> Data { get; set; }
        public class QuerySlbSpecResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the returned data.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The maximum number of connections.
            /// </summary>
            [NameInMap("MaxConnection")]
            [Validation(Required=false)]
            public string MaxConnection { get; set; }

            /// <summary>
            /// The name of the instance.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of connections per second.
            /// </summary>
            [NameInMap("NewConnectionPerSecond")]
            [Validation(Required=false)]
            public string NewConnectionPerSecond { get; set; }

            /// <summary>
            /// The number of queries per second (QPS).
            /// </summary>
            [NameInMap("Qps")]
            [Validation(Required=false)]
            public string Qps { get; set; }

            /// <summary>
            /// The specification of the instance.
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned. If the request is successful, a success message is returned. If the request fails, an error message is returned.
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
