// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateSwimLaneRequest : TeaModel {
        /// <summary>
        /// The name of the lane group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The label key of the associated service workload. Set the value to `ASM_TRAFFIC_TAG`.
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
        /// The ID of the ASM instance.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// A list of services associated with the lane.
        /// </summary>
        [NameInMap("ServicesList")]
        [Validation(Required=false)]
        public string ServicesList { get; set; }

        /// <summary>
        /// The name of the lane.
        /// </summary>
        [NameInMap("SwimLaneName")]
        [Validation(Required=false)]
        public string SwimLaneName { get; set; }

    }

}
