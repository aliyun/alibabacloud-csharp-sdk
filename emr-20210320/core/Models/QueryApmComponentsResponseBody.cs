// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class QueryApmComponentsResponseBody : TeaModel {
        /// <summary>
        /// Created on 2022/7/11 5:27 PM
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryApmComponentsResponseBodyData Data { get; set; }
        public class QueryApmComponentsResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
