// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListUsersResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListUsersResponseBodyData> Data { get; set; }
        public class ListUsersResponseBodyData : TeaModel {
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public long? AccountType { get; set; }

            [NameInMap("appAccount")]
            [Validation(Required=false)]
            public string AppAccount { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("isEditableUser")]
            [Validation(Required=false)]
            public long? IsEditableUser { get; set; }

            [NameInMap("isOperation")]
            [Validation(Required=false)]
            public int? IsOperation { get; set; }

            [NameInMap("isRam")]
            [Validation(Required=false)]
            public int? IsRam { get; set; }

            [NameInMap("isRelated")]
            [Validation(Required=false)]
            public string IsRelated { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("ramId")]
            [Validation(Required=false)]
            public long? RamId { get; set; }

            [NameInMap("synergyChannel")]
            [Validation(Required=false)]
            public string SynergyChannel { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
