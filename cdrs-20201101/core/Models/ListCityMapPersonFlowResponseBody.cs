// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListCityMapPersonFlowResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCityMapPersonFlowResponseBodyData> Data { get; set; }
        public class ListCityMapPersonFlowResponseBodyData : TeaModel {
            [NameInMap("FlowNumber")]
            [Validation(Required=false)]
            public string FlowNumber { get; set; }

            [NameInMap("OriginDataSourceId")]
            [Validation(Required=false)]
            public string OriginDataSourceId { get; set; }

            [NameInMap("TargetDataSourceId")]
            [Validation(Required=false)]
            public string TargetDataSourceId { get; set; }

            [NameInMap("FlowDirection")]
            [Validation(Required=false)]
            public string FlowDirection { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
