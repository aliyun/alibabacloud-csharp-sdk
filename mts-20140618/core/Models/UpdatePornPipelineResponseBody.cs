// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdatePornPipelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public UpdatePornPipelineResponseBodyPipeline Pipeline { get; set; }
        public class UpdatePornPipelineResponseBodyPipeline : TeaModel {
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("NotifyConfig")]
            [Validation(Required=false)]
            public UpdatePornPipelineResponseBodyPipelineNotifyConfig NotifyConfig { get; set; }
            public class UpdatePornPipelineResponseBodyPipelineNotifyConfig : TeaModel {
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

            }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

    }

}
