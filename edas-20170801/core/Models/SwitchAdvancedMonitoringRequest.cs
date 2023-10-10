// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class SwitchAdvancedMonitoringRequest : TeaModel {
        /// <summary>
        /// The ID of the application for which you want to query or configure the advanced application monitoring feature.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// Specifies whether to enable the advanced application monitoring feature. Valid values:
        /// 
        /// *   true: enables the advanced application monitoring feature.
        /// *   false: disables the advanced application monitoring feature.
        /// 
        /// If you call this operation to query the status of the advanced application monitoring feature, you do not need to specify this parameter.
        /// </summary>
        [NameInMap("EnableAdvancedMonitoring")]
        [Validation(Required=false)]
        public bool? EnableAdvancedMonitoring { get; set; }

    }

}
