// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDnsGtmMonitorStatusRequest : TeaModel {
        /// <summary>
        /// The language to return some response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the health check task.
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check feature. Valid values:
        /// 
        /// *   OPEN: enable
        /// *   CLOSE: disable
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
