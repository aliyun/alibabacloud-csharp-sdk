// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitivityLevelResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID. You can use the ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The sensitivity levels.
        /// </summary>
        [NameInMap("SensitivityLevelList")]
        [Validation(Required=false)]
        public List<ListSensitivityLevelResponseBodySensitivityLevelList> SensitivityLevelList { get; set; }
        public class ListSensitivityLevelResponseBodySensitivityLevelList : TeaModel {
            /// <summary>
            /// Indicates whether the fields of the sensitive level are displayed in plaintext.
            /// </summary>
            [NameInMap("IsPlain")]
            [Validation(Required=false)]
            public bool? IsPlain { get; set; }

            /// <summary>
            /// The name of the sensitive level.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the classification template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// The type of the classification template. Valid values:
            /// 
            /// *   **INNER**: a built-in template.
            /// *   **USER_DEFINE**: a custom template.
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
