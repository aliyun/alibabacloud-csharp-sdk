// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateIDEEventResultRequest : TeaModel {
        /// <summary>
        /// The summary information of the check result. The information is displayed in DataStudio. If an alert is reported or the event fails the check, you can troubleshoot errors based on the information.
        /// </summary>
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// The ID of the request. You can troubleshoot errors based on the ID.
        /// </summary>
        [NameInMap("CheckResultTip")]
        [Validation(Required=false)]
        public string CheckResultTip { get; set; }

        /// <summary>
        /// The check status of the extension point event. Valid values:
        /// 
        /// *   OK: The event passes the check.
        /// *   FAIL: The event fails to pass the check. You must check and handle the reported error at the earliest opportunity to ensure that your program is run as expected.
        /// *   WARN: The event passes the check, but an alert is reported.
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// The ID of the extension. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Extensions tab of the Open Platform page to view the ID.
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
