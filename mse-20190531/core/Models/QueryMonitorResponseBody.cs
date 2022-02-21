// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryMonitorResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryMonitorResponseBodyData> Data { get; set; }
        public class QueryMonitorResponseBodyData : TeaModel {
            [NameInMap("clusterNamePrefix")]
            [Validation(Required=false)]
            public string ClusterNamePrefix { get; set; }

            [NameInMap("podName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Values { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
