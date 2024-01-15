// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopsPolicyGroupResponseBody : TeaModel {
        /// <summary>
        /// The change results.
        /// </summary>
        [NameInMap("ModifyResults")]
        [Validation(Required=false)]
        public List<ModifyDesktopsPolicyGroupResponseBodyModifyResults> ModifyResults { get; set; }
        public class ModifyDesktopsPolicyGroupResponseBodyModifyResults : TeaModel {
            /// <summary>
            /// The change result. A value of success indicates that the policy is changed. If the policy is not changed, an error message is returned.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The ID of the cloud desktop.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The error message. This parameter is empty if the Code value is success.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
