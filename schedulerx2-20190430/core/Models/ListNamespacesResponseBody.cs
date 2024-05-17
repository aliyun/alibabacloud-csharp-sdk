// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListNamespacesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about the namespaces.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespacesResponseBodyData Data { get; set; }
        public class ListNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// The namespaces and their details.
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<ListNamespacesResponseBodyDataNamespaces> Namespaces { get; set; }
            public class ListNamespacesResponseBodyDataNamespaces : TeaModel {
                /// <summary>
                /// The description of the namespace.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the namespace.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The namespace ID.
                /// </summary>
                [NameInMap("UId")]
                [Validation(Required=false)]
                public string UId { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
