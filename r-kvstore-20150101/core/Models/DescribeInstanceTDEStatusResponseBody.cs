// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceTDEStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeInstanceTDEStatus**.
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
