// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreatePipelinesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<CreatePipelinesRequestBody> Body { get; set; }
        public class CreatePipelinesRequestBody : TeaModel {
            /// <summary>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>input { } filter { } output { }</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>this is a test</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pipeline-test</para>
            /// </summary>
            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("queueCheckPointWrites")]
            [Validation(Required=false)]
            public int? QueueCheckPointWrites { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("queueMaxBytes")]
            [Validation(Required=false)]
            public int? QueueMaxBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MEMORY</para>
            /// </summary>
            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("workers")]
            [Validation(Required=false)]
            public int? Workers { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("trigger")]
        [Validation(Required=false)]
        public bool? Trigger { get; set; }

    }

}
