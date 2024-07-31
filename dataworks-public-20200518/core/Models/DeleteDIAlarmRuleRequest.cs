// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteDIAlarmRuleRequest : TeaModel {
        /// <summary>
        /// The alert rule ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DIAlarmRuleId")]
        [Validation(Required=false)]
        public long? DIAlarmRuleId { get; set; }

    }

}
