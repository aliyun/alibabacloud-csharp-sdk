// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSwimLaneListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SwimLaneList")]
        [Validation(Required=false)]
        public List<GetSwimLaneListResponseBodySwimLaneList> SwimLaneList { get; set; }
        public class GetSwimLaneListResponseBodySwimLaneList : TeaModel {
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("IngressRule")]
            [Validation(Required=false)]
            public string IngressRule { get; set; }

            [NameInMap("IngressService")]
            [Validation(Required=false)]
            public string IngressService { get; set; }

            [NameInMap("LabelSelectorKey")]
            [Validation(Required=false)]
            public string LabelSelectorKey { get; set; }

            [NameInMap("LabelSelectorValue")]
            [Validation(Required=false)]
            public string LabelSelectorValue { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ServiceList")]
            [Validation(Required=false)]
            public string ServiceList { get; set; }

        }

    }

}
