// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVirtualNumberRelationResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   The value 200 indicates that the request was successful.
        /// *   For more information about other response codes, see [API error codes](~~112502~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The list of associations between virtual numbers and real numbers. The following fields are returned:
        /// 
        /// *   **relatedNum**: the real number.
        /// *   **createTime**: the time when the number was activated.
        /// *   **pageNo**: the page number.
        /// *   **pageSize**: the number of entries per page.
        /// *   **total**: the total number of entries returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
