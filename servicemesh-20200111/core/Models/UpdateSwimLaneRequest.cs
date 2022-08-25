// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateSwimLaneRequest : TeaModel {
        [NameInMap("AddedServicesList")]
        [Validation(Required=false)]
        public string AddedServicesList { get; set; }

        [NameInMap("DeletedServicesList")]
        [Validation(Required=false)]
        public string DeletedServicesList { get; set; }

        [NameInMap("LabelSelectorKey")]
        [Validation(Required=false)]
        public string LabelSelectorKey { get; set; }

        [NameInMap("LabelSelectorValue")]
        [Validation(Required=false)]
        public string LabelSelectorValue { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("SwimLaneName")]
        [Validation(Required=false)]
        public string SwimLaneName { get; set; }

    }

}
