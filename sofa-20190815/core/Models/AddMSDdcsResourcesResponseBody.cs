// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMSDdcsResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public AddMSDdcsResourcesResponseBodyResource Resource { get; set; }
        public class AddMSDdcsResourcesResponseBodyResource : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<AddMSDdcsResourcesResponseBodyResourceAttributes> Attributes { get; set; }
            public class AddMSDdcsResourcesResponseBodyResourceAttributes : TeaModel {
                public string AttributeName { get; set; }
                public string InstanceId { get; set; }
                public int? Id { get; set; }
                public string Desc { get; set; }
            }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
        };

    }

}
