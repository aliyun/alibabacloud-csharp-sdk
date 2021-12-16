// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyData Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyDataList> List { get; set; }
            public class ListInstancesResponseBodyDataList : TeaModel {
                public List<ListInstancesResponseBodyDataListAdminList> AdminList { get; set; }
                public class ListInstancesResponseBodyDataListAdminList : TeaModel {
                    public string DisplayName { get; set; }
                    public string Email { get; set; }
                    public string Extension { get; set; }
                    public string InstanceId { get; set; }
                    public string LoginName { get; set; }
                    public string Mobile { get; set; }
                    public string RoleId { get; set; }
                    public string RoleName { get; set; }
                    public string UserId { get; set; }
                    public string WorkMode { get; set; }
                }
                public string AliyunUid { get; set; }
                public string ConsoleUrl { get; set; }
                public long? CreateTime { get; set; }
                public string Description { get; set; }
                public string DomainName { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public List<ListInstancesResponseBodyDataListNumberList> NumberList { get; set; }
                public class ListInstancesResponseBodyDataListNumberList : TeaModel {
                    public string Number { get; set; }
                }
                public string Status { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
