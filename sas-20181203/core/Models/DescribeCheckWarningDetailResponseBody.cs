// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningDetailResponseBody : TeaModel {
        /// <summary>
        /// The suggestion for the management of the risk item.
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// List of asset details to check.
        /// </summary>
        [NameInMap("CheckDetailAssetInfo")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> CheckDetailAssetInfo { get; set; }

        /// <summary>
        /// Detection content details.
        /// </summary>
        [NameInMap("CheckDetailColumns")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningDetailResponseBodyCheckDetailColumns> CheckDetailColumns { get; set; }
        public class DescribeCheckWarningDetailResponseBodyCheckDetailColumns : TeaModel {
            /// <summary>
            /// Detection content list.
            /// </summary>
            [NameInMap("Grids")]
            [Validation(Required=false)]
            public List<DescribeCheckWarningDetailResponseBodyCheckDetailColumnsGrids> Grids { get; set; }
            public class DescribeCheckWarningDetailResponseBodyCheckDetailColumnsGrids : TeaModel {
                /// <summary>
                /// Key to detect content.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The detection content key corresponds to the display name.
                /// </summary>
                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                /// <summary>
                /// Display type. Value:
                /// - **grid**：Detection grid
                /// - **text**：text
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Key to detect content.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The detection content key corresponds to the display name.
            /// </summary>
            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            /// <summary>
            /// Display type. Value:
            /// - **grid**：Detection grid
            /// - **text**：text
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the check item.
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// The additional information about the risk item.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the check item.
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        /// <summary>
        /// The risk level of the check item. Valid values:
        /// 
        /// *   **high**: The item is a high-risk item and is highlighted in red.
        /// *   **medium**: The item is a medium-risk item and is highlighted in orange.
        /// *   **low**: The item is a low-risk item and is highlighted in gray.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The prompt for the risk item.
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the check item. Valid values:
        /// 
        /// *   **hc_exploit**: unauthorized access
        /// *   **hc_djbh**: classified protection compliance
        /// *   **hc_best_secruity**: best security practice
        /// *   **hc_container**: container security
        /// *   **hc_custom**: custom baseline
        /// *   **cis**: Center for Internet Security (CIS) compliance
        /// *   **weak_password**: weak password
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
