// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class DescribeNisInspectionTaskResponseBody : TeaModel {
        [NameInMap("CheckResourceList")]
        [Validation(Required=false)]
        public List<DescribeNisInspectionTaskResponseBodyCheckResourceList> CheckResourceList { get; set; }
        public class DescribeNisInspectionTaskResponseBodyCheckResourceList : TeaModel {
            [NameInMap("CheckScope")]
            [Validation(Required=false)]
            public string CheckScope { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("InspectionInterval")]
        [Validation(Required=false)]
        public string InspectionInterval { get; set; }

        [NameInMap("InspectionName")]
        [Validation(Required=false)]
        public string InspectionName { get; set; }

        [NameInMap("InspectionProject")]
        [Validation(Required=false)]
        public string InspectionProject { get; set; }

        [NameInMap("InspectionTaskId")]
        [Validation(Required=false)]
        public string InspectionTaskId { get; set; }

        [NameInMap("InspectionTriggerTime")]
        [Validation(Required=false)]
        public string InspectionTriggerTime { get; set; }

        [NameInMap("LastUpdateReportId")]
        [Validation(Required=false)]
        public string LastUpdateReportId { get; set; }

        [NameInMap("LastUpdateTime")]
        [Validation(Required=false)]
        public string LastUpdateTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
