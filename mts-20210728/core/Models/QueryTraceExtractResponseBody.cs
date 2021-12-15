// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class QueryTraceExtractResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTraceExtractResponseBodyData Data { get; set; }
        public class QueryTraceExtractResponseBodyData : TeaModel {
            [NameInMap("Trace")]
            [Validation(Required=false)]
            public string Trace { get; set; }
        };

        /// <summary>
        /// 返回信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
