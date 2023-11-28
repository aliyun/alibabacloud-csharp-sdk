// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeXpackMonitorConfigResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeXpackMonitorConfigResponseBodyResult Result { get; set; }
        public class DescribeXpackMonitorConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the X-Pack Monitoring feature is enabled. Valid values:
            /// 
            /// *   true: enabled
            /// *   false: disabled
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<string> Endpoints { get; set; }

            /// <summary>
            /// The ID of the associated Elasticsearch cluster.
            /// </summary>
            [NameInMap("esInstanceId")]
            [Validation(Required=false)]
            public string EsInstanceId { get; set; }

            [NameInMap("pipelineIds")]
            [Validation(Required=false)]
            public List<string> PipelineIds { get; set; }

            /// <summary>
            /// The username that is used to access the associated Elasticsearch cluster.
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
