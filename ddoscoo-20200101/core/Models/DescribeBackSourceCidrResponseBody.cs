// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBackSourceCidrResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the back-to-origin CIDR blocks of the instance.
        /// </summary>
        [NameInMap("Cidrs")]
        [Validation(Required=false)]
        public List<string> Cidrs { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
