// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListStatisticReportRequest : TeaModel {
        /// <summary>
        /// pv,uv
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

        /// <summary>
        /// 1582646399
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 10
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// bizType:test,sceneTag:myTag
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// 1582214400
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
