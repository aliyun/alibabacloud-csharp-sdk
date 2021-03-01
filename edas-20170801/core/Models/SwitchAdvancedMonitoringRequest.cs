// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class SwitchAdvancedMonitoringRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("EnableAdvancedMonitoring")]
        [Validation(Required=false)]
        public bool? EnableAdvancedMonitoring { get; set; }

    }

}
