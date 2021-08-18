// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniRecoverableListResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("RecoverableInfoList")]
        [Validation(Required=false)]
        public List<DescribeUniRecoverableListResponseBodyRecoverableInfoList> RecoverableInfoList { get; set; }
        public class DescribeUniRecoverableListResponseBodyRecoverableInfoList : TeaModel {
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("ResetTime")]
            [Validation(Required=false)]
            public long? ResetTime { get; set; }

            [NameInMap("RestoreInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> RestoreInfo { get; set; }

            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResetScn")]
            [Validation(Required=false)]
            public string ResetScn { get; set; }

        }

    }

}
