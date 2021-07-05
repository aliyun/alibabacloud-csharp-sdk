// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeModifyParameterLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeModifyParameterLogResponseBodyItems Items { get; set; }
        public class DescribeModifyParameterLogResponseBodyItems : TeaModel {
            [NameInMap("ParameterChangeLog")]
            [Validation(Required=false)]
            public List<DescribeModifyParameterLogResponseBodyItemsParameterChangeLog> ParameterChangeLog { get; set; }
            public class DescribeModifyParameterLogResponseBodyItemsParameterChangeLog : TeaModel {
                public string Status { get; set; }
                public string OldParameterValue { get; set; }
                public string ParameterName { get; set; }
                public string NewParameterValue { get; set; }
                public string ModifyTime { get; set; }
            }
        };

    }

}
