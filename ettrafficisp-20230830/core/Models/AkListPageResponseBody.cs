// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EttrafficIsp20230830.Models
{
    public class AkListPageResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public AkListPageResponseBodyData Data { get; set; }
        public class AkListPageResponseBodyData : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("dataList")]
            [Validation(Required=false)]
            public List<AkListPageResponseBodyDataDataList> DataList { get; set; }
            public class AkListPageResponseBodyDataDataList : TeaModel {
                [NameInMap("accessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                [NameInMap("accessKeyName")]
                [Validation(Required=false)]
                public string AccessKeyName { get; set; }

                [NameInMap("accessKeySecret")]
                [Validation(Required=false)]
                public string AccessKeySecret { get; set; }

                [NameInMap("active")]
                [Validation(Required=false)]
                public int? Active { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("lastCallTime")]
                [Validation(Required=false)]
                public string LastCallTime { get; set; }

                [NameInMap("permissions")]
                [Validation(Required=false)]
                public List<AkListPageResponseBodyDataDataListPermissions> Permissions { get; set; }
                public class AkListPageResponseBodyDataDataListPermissions : TeaModel {
                    [NameInMap("authTime")]
                    [Validation(Required=false)]
                    public string AuthTime { get; set; }

                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    [NameInMap("permissionCode")]
                    [Validation(Required=false)]
                    public string PermissionCode { get; set; }

                    [NameInMap("permissionName")]
                    [Validation(Required=false)]
                    public string PermissionName { get; set; }

                }

            }

            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
