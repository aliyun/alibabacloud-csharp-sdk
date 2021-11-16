// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentSubtotalsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIncidentSubtotalsResponseBodyData> Data { get; set; }
        public class ListIncidentSubtotalsResponseBodyData : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 操作人Id
            /// </summary>
            [NameInMap("createUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

            /// <summary>
            /// 操作人
            /// </summary>
            [NameInMap("createUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// 操作人手机号
            /// </summary>
            [NameInMap("createUserPhone")]
            [Validation(Required=false)]
            public string CreateUserPhone { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
