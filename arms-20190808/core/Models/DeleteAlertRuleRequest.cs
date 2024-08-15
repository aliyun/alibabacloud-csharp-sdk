// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteAlertRuleRequest : TeaModel {
        /// <summary>
        /// The alert rule ID.
        /// 
        /// For more information about how to obtain the ID of an alert rule, see [GetAlertRules](https://help.aliyun.com/document_detail/2612348.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

    }

}
