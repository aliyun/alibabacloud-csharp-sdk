// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListKibanaPluginsResponseBody : TeaModel {
        /// <summary>
        /// The request header.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListKibanaPluginsResponseBodyHeaders Headers { get; set; }
        public class ListKibanaPluginsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the plug-ins.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListKibanaPluginsResponseBodyResult> Result { get; set; }
        public class ListKibanaPluginsResponseBodyResult : TeaModel {
            /// <summary>
            /// The description of the plug-in.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the plug-in.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The source of the plug-in.
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The URL of the introduction to the plug-in. The value null is supported.
            /// </summary>
            [NameInMap("specificationUrl")]
            [Validation(Required=false)]
            public string SpecificationUrl { get; set; }

            /// <summary>
            /// The installation status of the plug-in.
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
