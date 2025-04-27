// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue that is used to run the job.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListPipelineResponseBodyHeaders Headers { get; set; }
        public class ListPipelineResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The time when the pipeline was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the pipeline was created.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPipelineResponseBodyResult> Result { get; set; }
        public class ListPipelineResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-08-05T03:10:38.188Z</para>
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-08-05T08:43:31.757Z</para>
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// <para>The status of the pipeline. Supported:</para>
            /// <list type="bullet">
            /// <item><description>NOT_DEPLOYED: The node is not deployed.</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>DELETED: Deleted. The console does not display this status.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pipeline_test</para>
            /// </summary>
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NOT_DEPLOYED</para>
            /// </summary>
            [NameInMap("pipelineStatus")]
            [Validation(Required=false)]
            public string PipelineStatus { get; set; }

        }

    }

}
