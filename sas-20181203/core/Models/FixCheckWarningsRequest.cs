// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FixCheckWarningsRequest : TeaModel {
        /// <summary>
        /// The parameters for the baseline risk item that you want to fix.
        /// 
        /// *   **checkId**: the ID of the check item that corresponds to the baseline risk item.
        /// 
        /// *   **rules**: an array that consists of the rules applied to fixes.
        /// 
        ///     *   **value**: specifies whether a fix method is selected. Valid values: **0** and **1**. The value 0 indicates that no fix method is selected and the value 1 indicates that a fix method is selected.
        ///     *   **ruleId**: the ID of the fix method.
        ///     *   **paramList**: an array that consists of the details about the fix method.\\
        ///         • **paramName**: the name of the fix method.\\
        ///         • **value**: the value of the fix method.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CheckParams")]
        [Validation(Required=false)]
        public string CheckParams { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the baseline risk item.
        /// 
        /// >  To query specified baseline risk items and the check items of a specified server, you must provide the IDs of the baseline risk items. You can call the [DescribeCheckWarningSummary](~~DescribeCheckWarningSummary~~) operation to query the IDs.
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The UUID of the asset for which you want to fix the baseline risk item. You can call the [DescribeWarningMachines](~~DescribeWarningMachines~~) operation to query the UUIDs of assets.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
