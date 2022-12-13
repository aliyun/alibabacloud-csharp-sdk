// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class RespondIncidentRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 影响程度
        /// </summary>
        [NameInMap("incidentIds")]
        [Validation(Required=false)]
        public List<long?> IncidentIds { get; set; }

    }

}
