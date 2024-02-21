// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListTagKeysResponseBody : TeaModel {
        /// <summary>
        /// The tag keys.
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public ListTagKeysResponseBodyKeys Keys { get; set; }
        public class ListTagKeysResponseBodyKeys : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public List<string> Key { get; set; }

        }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. If the NextToken parameter is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
