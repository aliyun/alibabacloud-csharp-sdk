// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaAlarmRequest : TeaModel {
        /// <summary>
        /// The ID of the quota alert.
        /// 
        /// For more information about how to query the ID of a quota alert, see [ListQuotaAlarms](~~184348~~).
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public string AlarmId { get; set; }

    }

}
