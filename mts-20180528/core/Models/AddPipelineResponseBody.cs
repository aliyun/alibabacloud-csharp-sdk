// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class AddPipelineResponseBody : TeaModel {
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public AddPipelineResponseBodyPipeline Pipeline { get; set; }
        public class AddPipelineResponseBodyPipeline : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NotifyConfig")]
            [Validation(Required=false)]
            public AddPipelineResponseBodyPipelineNotifyConfig NotifyConfig { get; set; }
            public class AddPipelineResponseBodyPipelineNotifyConfig : TeaModel {
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            [NameInMap("SpeedLevel")]
            [Validation(Required=false)]
            public long? SpeedLevel { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
