// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeApiListResponseBody : TeaModel {
        /// <summary>
        /// The information about the service.
        /// </summary>
        [NameInMap("ApiList")]
        [Validation(Required=false)]
        public List<DescribeApiListResponseBodyApiList> ApiList { get; set; }
        public class DescribeApiListResponseBodyApiList : TeaModel {
            /// <summary>
            /// The link to the API references of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("DocUrl")]
            [Validation(Required=false)]
            public string DocUrl { get; set; }

            /// <summary>
            /// The POP code of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("PopCode")]
            [Validation(Required=false)]
            public string PopCode { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
