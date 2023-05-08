// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveSuspEventUserSettingRequest : TeaModel {
        /// <summary>
        /// The data source of the exception. Set the value to sas.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The severities of alert notifications. Valid values:
        /// 
        /// *   **remind**
        /// *   **suspicious**
        /// *   **serious**
        /// </summary>
        [NameInMap("LevelsOn")]
        [Validation(Required=false)]
        public string LevelsOn { get; set; }

    }

}
