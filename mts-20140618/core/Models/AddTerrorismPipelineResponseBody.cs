// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddTerrorismPipelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public AddTerrorismPipelineResponseBodyPipeline Pipeline { get; set; }
        public class AddTerrorismPipelineResponseBodyPipeline : TeaModel {
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("NotifyConfig")]
            [Validation(Required=false)]
            public AddTerrorismPipelineResponseBodyPipelineNotifyConfig NotifyConfig { get; set; }
            public class AddTerrorismPipelineResponseBodyPipelineNotifyConfig : TeaModel {
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
