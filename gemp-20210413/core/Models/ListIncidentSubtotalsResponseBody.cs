// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentSubtotalsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIncidentSubtotalsResponseBodyData> Data { get; set; }
        public class ListIncidentSubtotalsResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("createUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

            [NameInMap("createUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("createUserPhone")]
            [Validation(Required=false)]
            public string CreateUserPhone { get; set; }

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
