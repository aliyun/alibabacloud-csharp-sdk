// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionTasksResponseBody : TeaModel {
        [NameInMap("InspectionTaskList")]
        [Validation(Required=false)]
        public List<ListNisInspectionTasksResponseBodyInspectionTaskList> InspectionTaskList { get; set; }
        public class ListNisInspectionTasksResponseBodyInspectionTaskList : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("InspectionName")]
            [Validation(Required=false)]
            public string InspectionName { get; set; }

            [NameInMap("InspectionProject")]
            [Validation(Required=false)]
            public string InspectionProject { get; set; }

            [NameInMap("InspectionTaskId")]
            [Validation(Required=false)]
            public string InspectionTaskId { get; set; }

            [NameInMap("LastUpdateReportId")]
            [Validation(Required=false)]
            public string LastUpdateReportId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
