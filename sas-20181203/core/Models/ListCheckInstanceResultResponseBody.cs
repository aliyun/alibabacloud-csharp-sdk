// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckInstanceResultResponseBody : TeaModel {
        [NameInMap("BasicData")]
        [Validation(Required=false)]
        public List<ListCheckInstanceResultResponseBodyBasicData> BasicData { get; set; }
        public class ListCheckInstanceResultResponseBodyBasicData : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Checks")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Checks { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ListCheckInstanceResultResponseBodyColumns> Columns { get; set; }
        public class ListCheckInstanceResultResponseBodyColumns : TeaModel {
            [NameInMap("Grids")]
            [Validation(Required=false)]
            public List<ListCheckInstanceResultResponseBodyColumnsGrids> Grids { get; set; }
            public class ListCheckInstanceResultResponseBodyColumnsGrids : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Search")]
            [Validation(Required=false)]
            public bool? Search { get; set; }

            [NameInMap("SearchKey")]
            [Validation(Required=false)]
            public string SearchKey { get; set; }

            [NameInMap("ShowName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckInstanceResultResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckInstanceResultResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public string Count { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
