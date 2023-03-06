// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreatePipelinesRequest : TeaModel {
        /// <summary>
        /// 5A2CFF0E-5718-45B5-9D4D-70B3FF\*\*\*\*
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<CreatePipelinesRequestBody> Body { get; set; }
        public class CreatePipelinesRequestBody : TeaModel {
            [NameInMap("batchDelay")]
            [Validation(Required=false)]
            public int? BatchDelay { get; set; }

            [NameInMap("batchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("pipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("queueCheckPointWrites")]
            [Validation(Required=false)]
            public int? QueueCheckPointWrites { get; set; }

            [NameInMap("queueMaxBytes")]
            [Validation(Required=false)]
            public int? QueueMaxBytes { get; set; }

            [NameInMap("queueType")]
            [Validation(Required=false)]
            public string QueueType { get; set; }

            [NameInMap("workers")]
            [Validation(Required=false)]
            public int? Workers { get; set; }

        }

        /// <summary>
        /// false
        /// </summary>
        [NameInMap("trigger")]
        [Validation(Required=false)]
        public bool? Trigger { get; set; }

    }

}
