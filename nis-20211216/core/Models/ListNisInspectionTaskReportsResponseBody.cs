// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class ListNisInspectionTaskReportsResponseBody : TeaModel {
        [NameInMap("InspectionReportList")]
        [Validation(Required=false)]
        public List<ListNisInspectionTaskReportsResponseBodyInspectionReportList> InspectionReportList { get; set; }
        public class ListNisInspectionTaskReportsResponseBodyInspectionReportList : TeaModel {
            [NameInMap("InspectionReportId")]
            [Validation(Required=false)]
            public string InspectionReportId { get; set; }

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
