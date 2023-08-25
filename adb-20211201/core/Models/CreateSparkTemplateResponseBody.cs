// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateSparkTemplateResponseBody : TeaModel {
        /// <summary>
        /// The creation result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSparkTemplateResponseBodyData Data { get; set; }
        public class CreateSparkTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the application template is created. Valid values:
            /// 
            /// *   **true**: The application template is created.
            /// *   **false**: The application fails to be created.
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
