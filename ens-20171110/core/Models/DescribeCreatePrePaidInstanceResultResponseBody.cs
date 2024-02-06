// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeCreatePrePaidInstanceResultResponseBody : TeaModel {
        /// <summary>
        /// Returned results of creating an instance.
        /// </summary>
        [NameInMap("InstanceCreateResult")]
        [Validation(Required=false)]
        public DescribeCreatePrePaidInstanceResultResponseBodyInstanceCreateResult InstanceCreateResult { get; set; }
        public class DescribeCreatePrePaidInstanceResultResponseBodyInstanceCreateResult : TeaModel {
            /// <summary>
            /// The status of the instance creation.
            /// 
            /// *   Accepted
            /// *   Creating
            /// *   Failed
            /// *   Successed
            /// </summary>
            [NameInMap("InstanceCreateStatus")]
            [Validation(Required=false)]
            public string InstanceCreateStatus { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
