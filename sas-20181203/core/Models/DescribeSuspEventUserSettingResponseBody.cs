// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventUserSettingResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the risk levels of alert notifications. Valid values:
        /// 
        /// *   **remind**
        /// *   **suspicious**
        /// *   **serious**
        /// </summary>
        [NameInMap("LevelsOn")]
        [Validation(Required=false)]
        public List<string> LevelsOn { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
