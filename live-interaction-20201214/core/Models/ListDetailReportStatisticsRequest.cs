// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListDetailReportStatisticsRequest : TeaModel {
        /// <summary>
        /// 应用Id
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 请求
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public ListDetailReportStatisticsRequestRequestParams RequestParams { get; set; }
        public class ListDetailReportStatisticsRequestRequestParams : TeaModel {
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("ReportStatisticsType")]
            [Validation(Required=false)]
            public string ReportStatisticsType { get; set; }
        };

    }

}
