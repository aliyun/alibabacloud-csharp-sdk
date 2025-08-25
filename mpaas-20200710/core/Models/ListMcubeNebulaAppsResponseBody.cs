// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class ListMcubeNebulaAppsResponseBody : TeaModel {
        [NameInMap("ListMcubeNebulaAppsResult")]
        [Validation(Required=false)]
        public ListMcubeNebulaAppsResponseBodyListMcubeNebulaAppsResult ListMcubeNebulaAppsResult { get; set; }
        public class ListMcubeNebulaAppsResponseBodyListMcubeNebulaAppsResult : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("NebulaAppInfos")]
            [Validation(Required=false)]
            public List<ListMcubeNebulaAppsResponseBodyListMcubeNebulaAppsResultNebulaAppInfos> NebulaAppInfos { get; set; }
            public class ListMcubeNebulaAppsResponseBodyListMcubeNebulaAppsResultNebulaAppInfos : TeaModel {
                [NameInMap("H5Id")]
                [Validation(Required=false)]
                public string H5Id { get; set; }

                [NameInMap("H5Name")]
                [Validation(Required=false)]
                public string H5Name { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
