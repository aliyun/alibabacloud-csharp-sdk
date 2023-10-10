// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceConsumersPageResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceConsumersPageResponseBodyData Data { get; set; }
        public class GetServiceConsumersPageResponseBodyData : TeaModel {
            /// <summary>
            /// The data array that is returned.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<GetServiceConsumersPageResponseBodyDataContent> Content { get; set; }
            public class GetServiceConsumersPageResponseBodyDataContent : TeaModel {
                /// <summary>
                /// The name of the service consumer.
                /// </summary>
                [NameInMap("EdasAppName")]
                [Validation(Required=false)]
                public string EdasAppName { get; set; }

                /// <summary>
                /// The ID of the service consumer.
                /// </summary>
                [NameInMap("EdassAppId")]
                [Validation(Required=false)]
                public string EdassAppId { get; set; }

                /// <summary>
                /// The IP address of the service consumer.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// The number of entries to return on each page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public int? TotalElements { get; set; }

            /// <summary>
            /// The total number of returned pages.
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// The message that is returned for the request.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
