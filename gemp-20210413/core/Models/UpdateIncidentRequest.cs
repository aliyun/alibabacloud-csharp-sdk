// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateIncidentRequest : TeaModel {
        /// <summary>
        /// 幂等校验Id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 影响程度
        /// </summary>
        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        /// <summary>
        /// 事件Id
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public long? IncidentId { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [NameInMap("incidentLevel")]
        [Validation(Required=false)]
        public string IncidentLevel { get; set; }

        /// <summary>
        /// 事件标题
        /// </summary>
        [NameInMap("incidentTitle")]
        [Validation(Required=false)]
        public string IncidentTitle { get; set; }

    }

}
