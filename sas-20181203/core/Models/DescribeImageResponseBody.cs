// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageResponseBody : TeaModel {
        /// <summary>
        /// The information about the image digest.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageResponseBodyData Data { get; set; }
        public class DescribeImageResponseBodyData : TeaModel {
            /// <summary>
            /// The digest value of the image.
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
