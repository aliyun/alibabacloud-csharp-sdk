// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTagValuesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the next query is required. The value of this parameter may be empty.
        /// 
        /// *   If the value of this parameter is empty (`"NextToken": ""`), all results are returned, and the next query is not required.
        /// *   If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the tag values.
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public ListTagValuesResponseBodyValues Values { get; set; }
        public class ListTagValuesResponseBodyValues : TeaModel {
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

    }

}
