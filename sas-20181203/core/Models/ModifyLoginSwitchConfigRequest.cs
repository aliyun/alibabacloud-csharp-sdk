// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyLoginSwitchConfigRequest : TeaModel {
        /// <summary>
        /// The type of the logon security settings that you want to enable or disable. Valid values:
        /// 
        /// *   **login_common_ip**: unapproved logon IP addresses
        /// *   **login_common_time**: unapproved logon time ranges
        /// *   **login_common_account**: unapproved logon accounts
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        /// <summary>
        /// Specifies whether to enable the logon security settings. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
