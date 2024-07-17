// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListVectorQueryResultRequest : TeaModel {
        /// <summary>
        /// The instance endpoint.
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The request body.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

        /// <summary>
        /// The query type. Valid values: vector, primary_key, and vector_text.
        /// </summary>
        [NameInMap("queryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// The vector query type. Valid values: vector, image, and text.
        /// </summary>
        [NameInMap("vectorQueryType")]
        [Validation(Required=false)]
        public string VectorQueryType { get; set; }

    }

}
