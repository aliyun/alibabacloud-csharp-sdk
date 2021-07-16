// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateIncidentSubtotalRequest : TeaModel {
        /// <summary>
        /// 事件id
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 幂等校验Id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
