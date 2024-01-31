// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportWarningRequest : TeaModel {
        /// <summary>
        /// Specifies whether the baseline risks are handled. Valid values:
        /// 
        /// *   **Y**: yes
        /// *   **N**: no
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// The type of the export task. Set the value to **hc_check_warning**, which indicates tasks to export baseline check results.
        /// </summary>
        [NameInMap("ExportType")]
        [Validation(Required=false)]
        public string ExportType { get; set; }

        /// <summary>
        /// The ID of the server group.
        /// 
        /// >  You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to query the IDs of server groups.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The export method of the results for the weak password baseline check. Valid values:
        /// 
        /// *   **0**: exports the check results after it is masked.
        /// *   **1**: exports the check results in plaintext.
        /// </summary>
        [NameInMap("IsCleartextPwd")]
        [Validation(Required=false)]
        public int? IsCleartextPwd { get; set; }

        /// <summary>
        /// Specifies whether the baseline check results are aggregated and exported. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("IsSummaryExport")]
        [Validation(Required=false)]
        public int? IsSummaryExport { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the risk item in the baseline check results. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("RiskIds")]
        [Validation(Required=false)]
        public string RiskIds { get; set; }

        /// <summary>
        /// The severity of the baseline check item. Separate multiple severities with commas (,). Valid values:
        /// 
        /// *   **high**
        /// *   **medium**
        /// *   **low**
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public string RiskLevels { get; set; }

        /// <summary>
        /// The name of the baseline.
        /// </summary>
        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The status of the check item in the baseline check results. Separate multiple statuses with commas (,). Valid values:
        /// 
        /// *   **3**: passed
        /// *   **1**: failed
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public string StatusList { get; set; }

        /// <summary>
        /// The ID of the baseline check policy.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// The subtypes of the baselines based on which baseline checks are performed. Separate multiple subtypes with commas (,).
        /// 
        /// > You must set the value of this parameter to the value of the **TypeName** parameter that is contained in the **SubTypes** parameter. You can call the [DescribeRiskType](~~DescribeRiskType~~) operation to obtain the value of the TypeName parameter.
        /// </summary>
        [NameInMap("SubTypeNames")]
        [Validation(Required=false)]
        public string SubTypeNames { get; set; }

        /// <summary>
        /// The type of the baseline based on which baseline checks are performed.
        /// 
        /// > You must set the value of this parameter to the value of the **TypeName** parameter that is returned by calling the [DescribeRiskType](~~DescribeRiskType~~) operation. If both the **TypeName** and **TypeNames** parameters are specified, only the **TypeName** parameter takes effect.
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// The types of the baselines based on which baseline checks are performed. Separate multiple types with commas (,).
        /// 
        /// > You must set the value of this parameter to the value of the **TypeName** parameter that is returned by calling the [DescribeRiskType](~~DescribeRiskType~~) operation. If both the **TypeName** and **TypeNames** parameters are specified, only the **TypeName** parameter takes effect.
        /// </summary>
        [NameInMap("TypeNames")]
        [Validation(Required=false)]
        public string TypeNames { get; set; }

        /// <summary>
        /// The UUID of the server whose baseline check results you want to export. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
