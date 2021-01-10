// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMsConfigResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public AddMsConfigResourcesResponseBodyResource Resource { get; set; }
        public class AddMsConfigResourcesResponseBodyResource : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<AddMsConfigResourcesResponseBodyResourceAttributes> Attributes { get; set; }
            public class AddMsConfigResourcesResponseBodyResourceAttributes : TeaModel {
                public string AttributeName { get; set; }
                public string InstanceId { get; set; }
                public long? Id { get; set; }
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
            public long? Id { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
