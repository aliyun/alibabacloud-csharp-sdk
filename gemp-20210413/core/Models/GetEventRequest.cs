// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetEventRequest : TeaModel {
        /// <summary>
        /// 监控源ID不能为空
        /// </summary>
        [NameInMap("monitorSourceId")]
        [Validation(Required=false)]
        public long? MonitorSourceId { get; set; }

    }

}
