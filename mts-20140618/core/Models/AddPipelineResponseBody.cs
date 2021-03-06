// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddPipelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public AddPipelineResponseBodyPipeline Pipeline { get; set; }
        public class AddPipelineResponseBodyPipeline : TeaModel {
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("SpeedLevel")]
            [Validation(Required=false)]
            public long? SpeedLevel { get; set; }
            [NameInMap("NotifyConfig")]
            [Validation(Required=false)]
            public AddPipelineResponseBodyPipelineNotifyConfig NotifyConfig { get; set; }
            public class AddPipelineResponseBodyPipelineNotifyConfig : TeaModel {
                [NameInMap("MqTopic")]
                [Validation(Required=false)]
                public string MqTopic { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("MqTag")]
                [Validation(Required=false)]
                public string MqTag { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("QuotaAllocate")]
            [Validation(Required=false)]
            public long? QuotaAllocate { get; set; }
        };

    }

}
