// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnFullDomainsBlockIPConfigResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// The value of Code is not 0 in the following scenarios:
        /// 
        /// *   The format of the IP address is invalid.
        /// *   The number of IP addresses exceeds the limit.
        /// *   Other abnormal scenarios
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned results. If the operation is successful, URLs of OSS objects are returned. If the operation fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
