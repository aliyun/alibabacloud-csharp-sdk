// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeInstanceKeywordsResponseBody : TeaModel {
        /// <summary>
        /// The type of reserved keyword returned.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of reserved keywords.
        /// </summary>
        [NameInMap("Words")]
        [Validation(Required=false)]
        public DescribeInstanceKeywordsResponseBodyWords Words { get; set; }
        public class DescribeInstanceKeywordsResponseBodyWords : TeaModel {
            [NameInMap("word")]
            [Validation(Required=false)]
            public List<string> Word { get; set; }

        }

    }

}
