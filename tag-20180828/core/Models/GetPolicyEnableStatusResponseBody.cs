// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetPolicyEnableStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the Tag Policy feature.
        /// </summary>
        [NameInMap("StatusModels")]
        [Validation(Required=false)]
        public List<GetPolicyEnableStatusResponseBodyStatusModels> StatusModels { get; set; }
        public class GetPolicyEnableStatusResponseBodyStatusModels : TeaModel {
            /// <summary>
            /// The status of the Tag Policy feature. Valid values:
            /// 
            /// *   PendingEnable: The feature is being enabled.
            /// *   Enabled: The feature is enabled.
            /// *   Closing: The feature is being disabled.
            /// *   Disabled: The feature is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The mode of the Tag Policy feature. Valid values:
            /// 
            /// *   USER: single-account mode
            /// *   RD: multi-account mode
            /// 
            /// For more information about the modes of the Tag Policy feature, see [Modes of the Tag Policy feature](~~417434~~).
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
