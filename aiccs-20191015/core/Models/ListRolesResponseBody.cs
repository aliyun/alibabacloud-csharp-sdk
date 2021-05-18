// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ListRolesResponseBody : TeaModel {
        /// <summary>
        /// message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// httpStatusCode
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRolesResponseBodyData> Data { get; set; }
        public class ListRolesResponseBodyData : TeaModel {
            /// <summary>
            /// 角色id
            /// </summary>
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 租户id
            /// </summary>
            [NameInMap("BuId")]
            [Validation(Required=false)]
            public long? BuId { get; set; }

            /// <summary>
            /// 角色名称
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 角色code
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 角色描述
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 所属角色组id
            /// </summary>
            [NameInMap("RoleGroupId")]
            [Validation(Required=false)]
            public long? RoleGroupId { get; set; }

            /// <summary>
            /// 所属角色组名称
            /// </summary>
            [NameInMap("RoleGroupName")]
            [Validation(Required=false)]
            public string RoleGroupName { get; set; }

        }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
