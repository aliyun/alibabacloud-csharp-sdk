// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CheckFileDeploymentRequest : TeaModel {
        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("CheckDetailUrl")]
        [Validation(Required=false)]
        public string CheckDetailUrl { get; set; }

        /// <summary>
        /// The ID of the instance to which the file checker belongs. You can obtain the ID from the CheckerInstanceId parameter in the check event logs returned by DataWorks.
        /// </summary>
        [NameInMap("CheckerInstanceId")]
        [Validation(Required=false)]
        public string CheckerInstanceId { get; set; }

        /// <summary>
        /// The check status of the file that you want to deploy. Valid values:
        /// 
        /// *   OK: The file passes the check.
        /// *   WARN: The file passes the check, but an alert is reported.
        /// *   FAIL: The file fails the check.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
