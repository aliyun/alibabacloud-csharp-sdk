// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListComponentsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ComponentList")]
        [Validation(Required=false)]
        public ListComponentsResponseBodyComponentList ComponentList { get; set; }
        public class ListComponentsResponseBodyComponentList : TeaModel {
            [NameInMap("Component")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyComponentListComponent> Component { get; set; }
            public class ListComponentsResponseBodyComponentListComponent : TeaModel {
                public string ComponentId { get; set; }
                public string ComponentKey { get; set; }
                public string Desc { get; set; }
                public bool? Expired { get; set; }
                public string Type { get; set; }
                public string Version { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
