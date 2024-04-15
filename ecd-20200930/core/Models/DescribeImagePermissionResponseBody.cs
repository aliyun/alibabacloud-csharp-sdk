// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImagePermissionResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the Alibaba Cloud accounts with which the image is shared.
        /// </summary>
        [NameInMap("AliUids")]
        [Validation(Required=false)]
        public List<string> AliUids { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
