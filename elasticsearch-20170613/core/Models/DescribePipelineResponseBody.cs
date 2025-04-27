// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribePipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the pipeline was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD1***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MEMORY: a traditional memory-based queue.</description></item>
        /// <item><description>PERSISTED: disk-based ACKed queue (persistent queue).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePipelineResponseBodyResult Result { get; set; }
        public class DescribePipelineResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the pipeline was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("batchDelay")]
            [Validation(Required=false)]
            public int? BatchDelay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>125</para>
            /// </summary>
            [NameInMap("batchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            /// <summary>
            /// <para>The description of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>input {  }  filter {  }  output {  }</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The state of the MPS queue. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_DEPLOYED: The node is not deployed.</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>DELETED: Deleted. The console does not display this status.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>this is a test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-06-20T07:26:47.000+0000</para>
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// <para>The total capacity of the queue in bytes. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-20T07:26:47.000+0000</para>
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// <para>Number of queue checkpoint writes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pipeline_test</para>
            /// </summary>
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("pipelineStatus")]
            [Validation(Required=false)]
            public string PipelineStatus { get; set; }

            /// <summary>
            /// <para>Pipeline batch delay. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("queueCheckPointWrites")]
            [Validation(Required=false)]
            public int? QueueCheckPointWrites { get; set; }

            /// <summary>
            /// <para>The number of pipeline workers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("queueMaxBytes")]
            [Validation(Required=false)]
            public int? QueueMaxBytes { get; set; }

            /// <summary>
            /// <para>The specific configuration of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MEMORY</para>
            /// </summary>
            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// <para>The size of the pipeline batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("workers")]
            [Validation(Required=false)]
            public int? Workers { get; set; }

        }

    }

}
