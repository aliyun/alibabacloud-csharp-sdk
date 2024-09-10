// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ReceiveFunctionTrialRewardByAliUidRequest : TeaModel {
        /// <summary>
        /// The name of the feature for which you want to apply for a free trial. Valid values:
        /// 
        /// *   **trail_honeypot_reward**: cloud honeypot
        /// *   **trail_file_detect_api_reward**: SDK for malicious file detection
        /// </summary>
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
