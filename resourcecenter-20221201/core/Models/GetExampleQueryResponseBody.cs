// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetExampleQueryResponseBody : TeaModel {
        /// <summary>
        /// The information about the sample query template.
        /// </summary>
        [NameInMap("ExampleQuery")]
        [Validation(Required=false)]
        public GetExampleQueryResponseBodyExampleQuery ExampleQuery { get; set; }
        public class GetExampleQueryResponseBodyExampleQuery : TeaModel {
            /// <summary>
            /// The description of the template.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The query statement in the template.
            /// </summary>
            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            /// <summary>
            /// The name of the template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the template.
            /// </summary>
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
