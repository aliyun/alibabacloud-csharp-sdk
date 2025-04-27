// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeXpackMonitorConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeXpackMonitorConfigResponseBodyResult Result { get; set; }
        public class DescribeXpackMonitorConfigResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the X-Pack Monitoring feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled</description></item>
            /// <item><description>false: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<string> Endpoints { get; set; }

            /// <summary>
            /// <para>The ID of the associated Elasticsearch cluster.</para>
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
            /// <para>The username that is used to access the associated Elasticsearch cluster.</para>
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
