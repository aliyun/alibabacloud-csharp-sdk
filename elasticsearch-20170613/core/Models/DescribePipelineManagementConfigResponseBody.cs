// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribePipelineManagementConfigResponseBody : TeaModel {
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
        public DescribePipelineManagementConfigResponseBodyResult Result { get; set; }
        public class DescribePipelineManagementConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// The access addresses of the Elasticsearch cluster. Specify each address in the `http://Endpoint of the Elasticsearch cluster:Port number` format.
            /// </summary>
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            /// <summary>
            /// The ID of the Elasticsearch cluster.
            /// </summary>
            [NameInMap("esInstanceId")]
            [Validation(Required=false)]
            public string EsInstanceId { get; set; }

            [NameInMap("pipelineIds")]
            [Validation(Required=false)]
            public List<string> PipelineIds { get; set; }

            /// <summary>
            /// The pipeline management method. Valid values: Kibana and MULTIPLE_PIPELINE.
            /// </summary>
            [NameInMap("pipelineManagementType")]
            [Validation(Required=false)]
            public string PipelineManagementType { get; set; }

            /// <summary>
            /// The username that is used to access the Elasticsearch cluster.
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
