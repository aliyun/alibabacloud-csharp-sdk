// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeImageResultExtRequest : TeaModel {
        /// <summary>
        /// The content of the information to be obtained. Multiple values are separated by commas.
        /// </summary>
        [NameInMap("InfoType")]
        [Validation(Required=false)]
        public string InfoType { get; set; }

        /// <summary>
        /// The reqId field returned by the Url Async Moderation API.
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

    }

}
