// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetIncidentSubtotalCountRequest : TeaModel {
        /// <summary>
        /// 事件id列表
        /// </summary>
        [NameInMap("incidentIds")]
        [Validation(Required=false)]
        public List<long?> IncidentIds { get; set; }

        /// <summary>
        /// 幂等标识
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
