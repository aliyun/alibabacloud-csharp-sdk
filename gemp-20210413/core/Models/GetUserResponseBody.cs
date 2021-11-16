// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// 用户
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUserResponseBodyData Data { get; set; }
        public class GetUserResponseBodyData : TeaModel {
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("isEditableUser")]
            [Validation(Required=false)]
            public bool? IsEditableUser { get; set; }
            [NameInMap("isRelated")]
            [Validation(Required=false)]
            public string IsRelated { get; set; }
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }
            [NameInMap("ramId")]
            [Validation(Required=false)]
            public string RamId { get; set; }
            [NameInMap("serviceGroups")]
            [Validation(Required=false)]
            public List<GetUserResponseBodyDataServiceGroups> ServiceGroups { get; set; }
            public class GetUserResponseBodyDataServiceGroups : TeaModel {
                public string Name { get; set; }
                public long? ServiceGroupId { get; set; }
            }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
