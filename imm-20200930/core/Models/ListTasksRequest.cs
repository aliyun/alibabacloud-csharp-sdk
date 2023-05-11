// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListTasksRequest : TeaModel {
        [NameInMap("EndTimeRange")]
        [Validation(Required=false)]
        public TimeRange EndTimeRange { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("RequestDefinition")]
        [Validation(Required=false)]
        public bool? RequestDefinition { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("StartTimeRange")]
        [Validation(Required=false)]
        public TimeRange StartTimeRange { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TagSelector")]
        [Validation(Required=false)]
        public string TagSelector { get; set; }

        [NameInMap("TaskTypes")]
        [Validation(Required=false)]
        public List<string> TaskTypes { get; set; }

    }

}
