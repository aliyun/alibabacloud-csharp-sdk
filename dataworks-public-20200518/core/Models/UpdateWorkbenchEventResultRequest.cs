// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateWorkbenchEventResultRequest : TeaModel {
        /// <summary>
        /// The check status of the extension point event. Valid values: OK and Fail. A value of OK indicates that the event passes the check. A value of FAIL indicates that the event fails to pass the check.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// The cause of the check failure.
        /// </summary>
        [NameInMap("CheckResultTip")]
        [Validation(Required=false)]
        public string CheckResultTip { get; set; }

        /// <summary>
        /// The code of the extension.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// The ID of the message received when the related extension point event is triggered after you enable message subscription by using the OpenEvent module.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
