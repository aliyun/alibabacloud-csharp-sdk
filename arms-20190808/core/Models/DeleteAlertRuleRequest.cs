// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteAlertRuleRequest : TeaModel {
        /// <summary>
        /// Indicates whether the alert rule was successfully deleted.
        /// 
        /// *   `true`: The specified data is deleted.
        /// *   `false`: The specified data fails to be deleted.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

    }

}
