// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListProblemSubtotalsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListProblemSubtotalsResponseBodyData> Data { get; set; }
        public class ListProblemSubtotalsResponseBodyData : TeaModel {
            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 操作人
            /// </summary>
            [NameInMap("createRamName")]
            [Validation(Required=false)]
            public string CreateRamName { get; set; }

        }

    }

}
