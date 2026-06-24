// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribePipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD1***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned pipeline information. For more information, see <a href="https://www.elastic.co/guide/en/logstash/6.7/logstash-settings-file.html">logstash.yml</a>.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePipelineResponseBodyResult Result { get; set; }
        public class DescribePipelineResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The batch delay of the pipeline. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("batchDelay")]
            [Validation(Required=false)]
            public int? BatchDelay { get; set; }

            /// <summary>
            /// <para>The batch size of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>125</para>
            /// </summary>
            [NameInMap("batchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            /// <summary>
            /// <para>The specific configuration of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>input {  }  filter {  }  output {  }</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The pipeline description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the pipeline was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-20T07:26:47.000+0000</para>
            /// </summary>
            [NameInMap("gmtCreatedTime")]
            [Validation(Required=false)]
            public string GmtCreatedTime { get; set; }

            /// <summary>
            /// <para>The time when the pipeline was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-20T07:26:47.000+0000</para>
            /// </summary>
            [NameInMap("gmtUpdateTime")]
            [Validation(Required=false)]
            public string GmtUpdateTime { get; set; }

            /// <summary>
            /// <para>The pipeline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pipeline_test</para>
            /// </summary>
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <para>The pipeline status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NOT_DEPLOYED: not deployed.</description></item>
            /// <item><description>RUNNING: running.</description></item>
            /// <item><description>DELETED: deleted. This status is not displayed in the console.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("pipelineStatus")]
            [Validation(Required=false)]
            public string PipelineStatus { get; set; }

            /// <summary>
            /// <para>The number of queue checkpoint writes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("queueCheckPointWrites")]
            [Validation(Required=false)]
            public int? QueueCheckPointWrites { get; set; }

            /// <summary>
            /// <para>The total capacity of the queue, in bytes. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("queueMaxBytes")]
            [Validation(Required=false)]
            public int? QueueMaxBytes { get; set; }

            /// <summary>
            /// <para>The queue type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MEMORY: a traditional memory-based queue.</description></item>
            /// <item><description>PERSISTED: a disk-based ACKed queue (persistent queue).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MEMORY</para>
            /// </summary>
            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// <para>The number of pipeline worker threads.</para>
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
