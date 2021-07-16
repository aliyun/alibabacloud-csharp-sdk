// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DeleteIncidentRequest : TeaModel {
        /// <summary>
        /// 幂等校验
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 事件Id
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

    }

}
