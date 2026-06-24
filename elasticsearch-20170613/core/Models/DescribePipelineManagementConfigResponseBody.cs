// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribePipelineManagementConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePipelineManagementConfigResponseBodyResult Result { get; set; }
        public class DescribePipelineManagementConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The list of access endpoints for the Elasticsearch instance, in the format of <c>domain name:port number</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;<a href="http://es-cn-n6w1o1x0w001c****.elasticsearch.aliyuncs.com:9200%22%5D">http://es-cn-n6w1o1x0w001c****.elasticsearch.aliyuncs.com:9200&quot;]</a></para>
            /// </summary>
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            /// <summary>
            /// <para>The Elasticsearch instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>es-cn-n6w1o1x0w001c****</para>
            /// </summary>
            [NameInMap("esInstanceId")]
            [Validation(Required=false)]
            public string EsInstanceId { get; set; }

            [NameInMap("pipelineIds")]
            [Validation(Required=false)]
            public List<string> PipelineIds { get; set; }

            /// <summary>
            /// <para>The pipeline management method. Valid values: Kibana and MULTIPLE_PIPELINE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MULTIPLE_PIPELINE</para>
            /// </summary>
            [NameInMap("pipelineManagementType")]
            [Validation(Required=false)]
            public string PipelineManagementType { get; set; }

            /// <summary>
            /// <para>The username used to access the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elastic</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
