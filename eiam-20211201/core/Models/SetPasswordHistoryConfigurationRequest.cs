// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class SetPasswordHistoryConfigurationRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The maximum number of recent passwords that can be retained. This parameter must be specified when PasswordHistoryStatus is set to enabled.
        /// </summary>
        [NameInMap("PasswordHistoryMaxRetention")]
        [Validation(Required=false)]
        public int? PasswordHistoryMaxRetention { get; set; }

        /// <summary>
        /// Specifies whether to enable the password history feature. Valid values:
        /// 
        /// *   enabled
        /// *   disabled
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PasswordHistoryStatus")]
        [Validation(Required=false)]
        public string PasswordHistoryStatus { get; set; }

    }

}
