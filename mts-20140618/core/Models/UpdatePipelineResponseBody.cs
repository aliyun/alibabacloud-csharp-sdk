// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdatePipelineResponseBody : TeaModel {
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public UpdatePipelineResponseBodyPipeline Pipeline { get; set; }
        public class UpdatePipelineResponseBodyPipeline : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("NotifyConfig")]
            [Validation(Required=false)]
            public UpdatePipelineResponseBodyPipelineNotifyConfig NotifyConfig { get; set; }
            public class UpdatePipelineResponseBodyPipelineNotifyConfig : TeaModel {
                [NameInMap("MqTag")]
                [Validation(Required=false)]
                public string MqTag { get; set; }

                [NameInMap("MqTopic")]
                [Validation(Required=false)]
                public string MqTopic { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }
            [NameInMap("QuotaAllocate")]
            [Validation(Required=false)]
            public long? QuotaAllocate { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
