// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceProvidersPageResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data structure.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceProvidersPageResponseBodyData Data { get; set; }
        public class GetServiceProvidersPageResponseBodyData : TeaModel {
            /// <summary>
            /// The data array returned.
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<GetServiceProvidersPageResponseBodyDataContent> Content { get; set; }
            public class GetServiceProvidersPageResponseBodyDataContent : TeaModel {
                /// <summary>
                /// The remarks of the service provider.
                /// </summary>
                [NameInMap("Iannotations")]
                [Validation(Required=false)]
                public string Iannotations { get; set; }

                /// <summary>
                /// The IP address of the service provider.
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// The port number of the service provider.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// The serialization type.
                /// </summary>
                [NameInMap("SerializeType")]
                [Validation(Required=false)]
                public string SerializeType { get; set; }

                /// <summary>
                /// The service timeout period.
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

            }

            /// <summary>
            /// The number of entries returned per page.
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
        /// The message returned for the request.
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
