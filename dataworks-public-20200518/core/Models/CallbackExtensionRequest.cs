// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CallbackExtensionRequest : TeaModel {
        /// <summary>
        /// The check message of the extension point event. If CheckResult is set to FAIL, you must provide the failure cause.
        /// </summary>
        [NameInMap("CheckMessage")]
        [Validation(Required=false)]
        public string CheckMessage { get; set; }

        /// <summary>
        /// The check status of the extension point event. Valid values:
        /// 
        /// *   OK: The event passes the check.
        /// *   FAIL: The event fails to pass the check. You must check and handle the reported error at the earliest opportunity to ensure that your program is run as expected.
        /// *   WARN: The event passes the check, but an alert is reported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// The unique code of the extension.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// The message ID in DataWorks OpenEvent. You can obtain the ID from a received message when an extension point event is triggered.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
