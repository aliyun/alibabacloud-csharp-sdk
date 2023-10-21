// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProductResourceTagKeyListResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination cursor. If more entries are to be returned on the next page, a pagination cursor is returned.
        /// 
        /// >  If the value of this parameter is not null, more entries are to be returned on the next page. You can use the returned pagination cursor as a request parameter to obtain entries on the next page. If the value of this parameter is null, all the entries have been returned.
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
        /// Indicates whether the call was successful. The value true indicates a success. The value false indicates a failure.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The keys of tags.
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public DescribeProductResourceTagKeyListResponseBodyTagKeys TagKeys { get; set; }
        public class DescribeProductResourceTagKeyListResponseBodyTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public List<string> TagKey { get; set; }

        }

    }

}
