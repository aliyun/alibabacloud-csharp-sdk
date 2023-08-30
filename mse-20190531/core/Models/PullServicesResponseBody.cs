// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class PullServicesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   `true`: The request was successful.
        /// *   `false`: The request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data structure.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PullServicesResponseBodyData> Data { get; set; }
        public class PullServicesResponseBodyData : TeaModel {
            /// <summary>
            /// The information about services.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The name of the group.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// code
            /// </summary>
            [NameInMap("NamespaceShowName")]
            [Validation(Required=false)]
            public string NamespaceShowName { get; set; }

            /// <summary>
            /// The data structure.
            /// </summary>
            [NameInMap("Services")]
            [Validation(Required=false)]
            public List<PullServicesResponseBodyDataServices> Services { get; set; }
            public class PullServicesResponseBodyDataServices : TeaModel {
                /// <summary>
                /// The ID of the service source.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The namespace.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The name of the group.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The type of the service source.
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// The alias of the namespace.
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
