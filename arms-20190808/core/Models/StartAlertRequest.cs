// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class StartAlertRequest : TeaModel {
        /// <summary>
        /// The ID of the alert rule. You can call the SearchAlertRules operation and view the `Id` parameter in the response. For more information, see [SearchAlertRules](https://help.aliyun.com/document_detail/175825.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public string AlertId { get; set; }

        /// <summary>
        /// The ID of the region. Set the value to `cn-hangzhou`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
