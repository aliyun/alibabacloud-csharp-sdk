// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class RespondIncidentRequest : TeaModel {
        /// <summary>
        /// 事件ID数组
        /// </summary>
        [NameInMap("incidentIds")]
        [Validation(Required=false)]
        public List<long?> IncidentIds { get; set; }

        /// <summary>
        /// 幂等校验Id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
