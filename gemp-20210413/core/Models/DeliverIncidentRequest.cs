// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class DeliverIncidentRequest : TeaModel {
        /// <summary>
        /// 事件ID
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        /// <summary>
        /// 转交用户ID
        /// </summary>
        [NameInMap("assignUserId")]
        [Validation(Required=false)]
        public long? AssignUserId { get; set; }

        /// <summary>
        /// 幂等校验id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
