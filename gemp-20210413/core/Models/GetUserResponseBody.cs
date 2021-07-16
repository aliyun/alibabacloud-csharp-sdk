// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUserResponseBodyData Data { get; set; }
        public class GetUserResponseBodyData : TeaModel {
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
            [NameInMap("ramId")]
            [Validation(Required=false)]
            public string RamId { get; set; }
            [NameInMap("isEditableUser")]
            [Validation(Required=false)]
            public bool? IsEditableUser { get; set; }
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }
        };

    }

}
