// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateSceneRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<UpdateSceneRequestFlows> Flows { get; set; }
        public class UpdateSceneRequestFlows : TeaModel {
            [NameInMap("FlowCode")]
            [Validation(Required=false)]
            public string FlowCode { get; set; }

            [NameInMap("FlowName")]
            [Validation(Required=false)]
            public string FlowName { get; set; }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
