// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListFunctionsResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListFunctionsResponseBodyData Data { get; set; }
        public class ListFunctionsResponseBodyData : TeaModel {
            /// <summary>
            /// The information about each function.
            /// </summary>
            [NameInMap("functions")]
            [Validation(Required=false)]
            public List<ListFunctionsResponseBodyDataFunctions> Functions { get; set; }
            public class ListFunctionsResponseBodyDataFunctions : TeaModel {
                /// <summary>
                /// The class in which the function was defined.
                /// </summary>
                [NameInMap("class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                /// <summary>
                /// The time when the function was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("creationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                /// <summary>
                /// The display name of the function.
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The name of the function.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The owner of the function.
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The name of the resource that was associated with the function.
                /// </summary>
                [NameInMap("resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

                /// <summary>
                /// The schema of the function.
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// Indicates the marker after which the returned list begins.
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// The maximum number of entries returned per page.
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
