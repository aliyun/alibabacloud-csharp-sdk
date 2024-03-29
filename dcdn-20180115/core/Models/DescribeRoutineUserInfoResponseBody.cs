// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRoutineUserInfoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeRoutineUserInfo**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
