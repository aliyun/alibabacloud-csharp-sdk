// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListScenesResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scenes")]
        [Validation(Required=false)]
        public List<ListScenesResponseBodyScenes> Scenes { get; set; }
        public class ListScenesResponseBodyScenes : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Flows")]
            [Validation(Required=false)]
            public List<ListScenesResponseBodyScenesFlows> Flows { get; set; }
            public class ListScenesResponseBodyScenesFlows : TeaModel {
                [NameInMap("FlowCode")]
                [Validation(Required=false)]
                public string FlowCode { get; set; }

                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public string FlowName { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
