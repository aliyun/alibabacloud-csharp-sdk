// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRiskLevelsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of sensitivity levels.
        /// </summary>
        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<DescribeRiskLevelsResponseBodyRiskLevelList> RiskLevelList { get; set; }
        public class DescribeRiskLevelsResponseBodyRiskLevelList : TeaModel {
            /// <summary>
            /// The description of the sensitivity level. You can enter a custom description.
            /// 
            /// The following list describes the sensitivity level names and the corresponding default description:
            /// 
            /// *   **NA**: which indicates that no sensitive data is detected.
            /// *   **S1**: which indicates the sensitive data at sensitivity level 1.
            /// *   **S2**: which indicates the sensitive data at sensitivity level 2.
            /// *   **S3**: which indicates the sensitive data at sensitivity level 3.
            /// *   **S4**: which indicates the sensitive data at sensitivity level 4.
            /// *   **S5**: which indicates the sensitive data at sensitivity level 5.
            /// *   **S6**: which indicates the sensitive data at sensitivity level 6.
            /// *   **S7**: which indicates the sensitive data at sensitivity level 7.
            /// *   **S8**: which indicates the sensitive data at sensitivity level 8.
            /// *   **S9**: which indicates the sensitive data at sensitivity level 9.
            /// *   **S10**: which indicates the sensitive data at sensitivity level 10.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The unique ID of the sensitivity level. Valid values: 1 to 11. Each sensitivity level ID maps a sensitivity level. For example, the sensitivity level ID of 2 corresponds to the sensitivity level S1.
            /// 
            /// For more information, see the description of the Name parameter.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the sensitivity level. The highest sensitivity level varies based on rule templates. The highest sensitivity level is S10. The highest sensitivity level of the **Built-in data security classification templates for Alibaba and Ant Group** is S4, and that of the **built-in classification templates for financial data** and **built-in classification templates for assets** is S5. For more information about the built-in classification templates for financial data, see Guidelines for Security Classification of Financial Data and Security Data - JRT 0197-2020. For a copied rule template, the highest sensitivity level is S10. The following list describes the sensitivity level names and the corresponding IDs:
            /// 
            /// *   **NA**: 1
            /// *   **S1**: 2
            /// *   **S2**: 3
            /// *   **S3**: 4
            /// *   **S4**: 5
            /// *   **S5**: 6
            /// *   **S6**: 7
            /// *   **S7**: 8
            /// *   **S8**: 9
            /// *   **S9**: 10
            /// *   **S10**: 11
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The number of times that each sensitivity level is referenced in the rule template. Default value: 0.
            /// </summary>
            [NameInMap("ReferenceNum")]
            [Validation(Required=false)]
            public int? ReferenceNum { get; set; }

        }

    }

}
