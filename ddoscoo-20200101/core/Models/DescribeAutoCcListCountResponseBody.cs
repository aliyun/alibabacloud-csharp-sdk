// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeAutoCcListCountResponseBody : TeaModel {
        /// <summary>
        /// The total number of IP addresses in the blacklist.
        /// </summary>
        [NameInMap("BlackCount")]
        [Validation(Required=false)]
        public int? BlackCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of IP addresses in the whitelist.
        /// </summary>
        [NameInMap("WhiteCount")]
        [Validation(Required=false)]
        public int? WhiteCount { get; set; }

    }

}
