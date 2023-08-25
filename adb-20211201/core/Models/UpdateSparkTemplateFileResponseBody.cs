// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UpdateSparkTemplateFileResponseBody : TeaModel {
        /// <summary>
        /// The update result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateSparkTemplateFileResponseBodyData Data { get; set; }
        public class UpdateSparkTemplateFileResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the application template is updated.
            /// 
            /// *   **true**: The application template is updated.
            /// *   **false**: The application template fails to be updated.
            /// </summary>
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public bool? Succeeded { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
