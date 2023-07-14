// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeletePrometheusAlertRuleRequest : TeaModel {
        /// <summary>
        /// Indicates whether the alert rule was deleted. Valid values:
        /// 
        /// *   `true`: The alert rule was deleted.
        /// *   `false`: The alert rule failed to be deleted.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
