// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSwimmingLaneGroupResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data of the lane group.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSwimmingLaneGroupResponseBodyData> Data { get; set; }
        public class ListSwimmingLaneGroupResponseBodyData : TeaModel {
            /// <summary>
            /// The applications that are related to the lane group.
            /// </summary>
            [NameInMap("ApplicationList")]
            [Validation(Required=false)]
            public List<ListSwimmingLaneGroupResponseBodyDataApplicationList> ApplicationList { get; set; }
            public class ListSwimmingLaneGroupResponseBodyDataApplicationList : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

            /// <summary>
            /// The information about the Enterprise Distributed Application Service (EDAS) ingress gateway.
            /// </summary>
            [NameInMap("EntryApplication")]
            [Validation(Required=false)]
            public ListSwimmingLaneGroupResponseBodyDataEntryApplication EntryApplication { get; set; }
            public class ListSwimmingLaneGroupResponseBodyDataEntryApplication : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// The name of the application.
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// The data source. Set the value to EDAS.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// The ID of the lane group.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the lane group.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the microservices namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

        }

        /// <summary>
        /// The additional information that is returned.
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
