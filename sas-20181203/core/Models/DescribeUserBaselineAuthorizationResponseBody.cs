// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserBaselineAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about whether Security Center is authorized to run configuration checks on cloud services.
        /// </summary>
        [NameInMap("UserBaselineAuthorization")]
        [Validation(Required=false)]
        public DescribeUserBaselineAuthorizationResponseBodyUserBaselineAuthorization UserBaselineAuthorization { get; set; }
        public class DescribeUserBaselineAuthorizationResponseBodyUserBaselineAuthorization : TeaModel {
            /// <summary>
            /// Indicates whether Security Center is authorized to run configuration checks on cloud services.
            /// 
            /// *   **0**: no. Security Center is not authorized to run configuration checks on cloud services.
            /// *   **1**: yes. Security Center is authorized to run configuration checks on cloud services.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
