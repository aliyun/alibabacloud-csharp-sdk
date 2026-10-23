// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListPipelineResponseBodyHeaders Headers { get; set; }
        public class ListPipelineResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

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
        public List<ListPipelineResponseBodyResult> Result { get; set; }
        public class ListPipelineResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the pipeline was created. The format is YYYY-MM-DDTHH:mm:ss.SSSZ, where the trailing Z indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-05T03:10:38.188Z</para>
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// <para>The time when the pipeline was updated. The format is YYYY-MM-DDTHH:mm:ss.SSSZ, where the trailing Z indicates UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-08-05T08:43:31.757Z</para>
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pipeline_test</para>
            /// </summary>
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The status of the pipeline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_DEPLOYED: not deployed</description></item>
            /// <item><description>RUNNING: running</description></item>
            /// <item><description>DELETED: deleted (this status is not displayed in the console)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NOT_DEPLOYED</para>
            /// </summary>
            [NameInMap("pipelineStatus")]
            [Validation(Required=false)]
            public string PipelineStatus { get; set; }

        }

    }

}
