// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class QueryAccountListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<QueryAccountListResponseData> Data { get; set; }
        public class QueryAccountListResponseData : TeaModel {
            [NameInMap("UserName")]
            [Validation(Required=true)]
            public string UserName { get; set; }

            [NameInMap("Role")]
            [Validation(Required=true)]
            public string Role { get; set; }

            [NameInMap("ShortName")]
            [Validation(Required=true)]
            public string ShortName { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=true)]
            public string Remark { get; set; }

            [NameInMap("RamUid")]
            [Validation(Required=true)]
            public string RamUid { get; set; }

        }

    }

}
