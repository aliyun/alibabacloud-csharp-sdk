// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListPluginsResponseBody : TeaModel {
        /// <summary>
        /// The description of the plug-in.
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListPluginsResponseBodyHeaders Headers { get; set; }
        public class ListPluginsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// The address of the plug-in description document.
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// The return results.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the plug-in.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPluginsResponseBodyResult> Result { get; set; }
        public class ListPluginsResponseBodyResult : TeaModel {
            /// <summary>
            /// The source type of the plug-in.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The name of the plug-in.
            /// </summary>
            [NameInMap("specificationUrl")]
            [Validation(Required=false)]
            public string SpecificationUrl { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
