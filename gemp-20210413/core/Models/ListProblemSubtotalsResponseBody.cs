// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListProblemSubtotalsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListProblemSubtotalsResponseBodyData> Data { get; set; }
        public class ListProblemSubtotalsResponseBodyData : TeaModel {
            [NameInMap("createRamName")]
            [Validation(Required=false)]
            public string CreateRamName { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("createUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

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
