// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListDSEntityResponseBody : TeaModel {
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public List<ListDSEntityResponseBodyEntities> Entities { get; set; }
        public class ListDSEntityResponseBodyEntities : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public string ModifyUserId { get; set; }

            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// 系统实体code，如@sys.date
            /// </summary>
            [NameInMap("SysEntityCode")]
            [Validation(Required=false)]
            public string SysEntityCode { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
