// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ModifyQuotaTemplateServiceStatusRequest : TeaModel {
        /// <summary>
        /// The status of the quota template. Valid values:
        /// 
        /// *   \\-1: The quota template is disabled.
        /// *   1: The quota template is enabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceStatus")]
        [Validation(Required=false)]
        public int? ServiceStatus { get; set; }

    }

}
