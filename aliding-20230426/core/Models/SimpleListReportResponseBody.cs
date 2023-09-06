// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class SimpleListReportResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<SimpleListReportResponseBodyDataList> DataList { get; set; }
        public class SimpleListReportResponseBodyDataList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            [NameInMap("DeptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
