// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyLoginSwitchConfigRequest : TeaModel {
        /// <summary>
        /// The type of the alert that you want to enable or disable. Valid values:
        /// 
        /// *   **login\_common_ip**: alerts for unapproved logon IP addresses
        /// *   **login\_common_time**: alerts for unapproved logon time ranges
        /// *   **login\_common_account**: alerts for unapproved logon accounts
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        /// <summary>
        /// Specifies whether to enable the logon security settings. Valid values:
        /// 
        /// *   **0**: disables the logon security settings
        /// *   **1**: enables the logon security settings
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
