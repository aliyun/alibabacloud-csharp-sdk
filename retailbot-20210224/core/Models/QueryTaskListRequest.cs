// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryTaskListRequest : TeaModel {
        [NameInMap("DigTaskPageQuery")]
        [Validation(Required=false)]
        public QueryTaskListRequestDigTaskPageQuery DigTaskPageQuery { get; set; }
        public class QueryTaskListRequestDigTaskPageQuery : TeaModel {
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }
            [NameInMap("RobotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("PageData")]
        [Validation(Required=false)]
        public QueryTaskListRequestPageData PageData { get; set; }
        public class QueryTaskListRequestPageData : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

    }

}
