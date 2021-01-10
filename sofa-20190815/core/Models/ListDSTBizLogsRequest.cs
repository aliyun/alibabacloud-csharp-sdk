// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTBizLogsRequest : TeaModel {
        [NameInMap("BizLogConfigId")]
        [Validation(Required=false)]
        public long? BizLogConfigId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SpanId")]
        [Validation(Required=false)]
        public string SpanId { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
