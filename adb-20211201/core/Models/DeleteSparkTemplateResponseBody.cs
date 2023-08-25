// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteSparkTemplateResponseBody : TeaModel {
        /// <summary>
        /// The result returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSparkTemplateResponseBodyData Data { get; set; }
        public class DeleteSparkTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the template is deleted. Valid values:
            /// 
            /// *   **true**: The template is deleted.
            /// *   **false**: The template fails to be deleted.
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
