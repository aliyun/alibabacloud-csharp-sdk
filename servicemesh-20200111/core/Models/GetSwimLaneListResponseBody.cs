// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSwimLaneListResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of all the lanes in the lane group.
        /// </summary>
        [NameInMap("SwimLaneList")]
        [Validation(Required=false)]
        public List<GetSwimLaneListResponseBodySwimLaneList> SwimLaneList { get; set; }
        public class GetSwimLaneListResponseBodySwimLaneList : TeaModel {
            /// <summary>
            /// The name of the lane group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The traffic routing rule associated with the lane.
            /// </summary>
            [NameInMap("IngressRule")]
            [Validation(Required=false)]
            public string IngressRule { get; set; }

            /// <summary>
            /// This parameter is deprecated.
            /// </summary>
            [NameInMap("IngressService")]
            [Validation(Required=false)]
            public string IngressService { get; set; }

            /// <summary>
            /// The label key of the associated service workload. Fixed value: `ASM_TRAFFIC_TAG`.
            /// </summary>
            [NameInMap("LabelSelectorKey")]
            [Validation(Required=false)]
            public string LabelSelectorKey { get; set; }

            /// <summary>
            /// The label value of the associated service workload.``
            /// </summary>
            [NameInMap("LabelSelectorValue")]
            [Validation(Required=false)]
            public string LabelSelectorValue { get; set; }

            /// <summary>
            /// The name of the lane.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// A list of services associated with the lane.
            /// </summary>
            [NameInMap("ServiceList")]
            [Validation(Required=false)]
            public string ServiceList { get; set; }

        }

    }

}
