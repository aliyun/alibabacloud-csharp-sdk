// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteSparkTemplateFileResponseBody : TeaModel {
        /// <summary>
        /// The deletion result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSparkTemplateFileResponseBodyData Data { get; set; }
        public class DeleteSparkTemplateFileResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the template file is deleted. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public bool? Succeeded { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
