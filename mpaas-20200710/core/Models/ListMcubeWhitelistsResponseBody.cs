// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class ListMcubeWhitelistsResponseBody : TeaModel {
        [NameInMap("ListWhitelistResult")]
        [Validation(Required=false)]
        public ListMcubeWhitelistsResponseBodyListWhitelistResult ListWhitelistResult { get; set; }
        public class ListMcubeWhitelistsResponseBodyListWhitelistResult : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("Whitelists")]
            [Validation(Required=false)]
            public List<ListMcubeWhitelistsResponseBodyListWhitelistResultWhitelists> Whitelists { get; set; }
            public class ListMcubeWhitelistsResponseBodyListWhitelistResultWhitelists : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("WhiteListCount")]
                [Validation(Required=false)]
                public long? WhiteListCount { get; set; }

                [NameInMap("WhiteListName")]
                [Validation(Required=false)]
                public string WhiteListName { get; set; }

                [NameInMap("WhitelistType")]
                [Validation(Required=false)]
                public string WhitelistType { get; set; }

            }

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
