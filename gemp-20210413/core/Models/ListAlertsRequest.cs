// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListAlertsRequest : TeaModel {
        /// <summary>
        /// 报警等级 P1 P2 P3 P4
        /// </summary>
        [NameInMap("alertLevel")]
        [Validation(Required=false)]
        public string AlertLevel { get; set; }

        /// <summary>
        /// 报警名称
        /// </summary>
        [NameInMap("alertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// 报警来源
        /// </summary>
        [NameInMap("alertSourceName")]
        [Validation(Required=false)]
        public string AlertSourceName { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

    }

}
