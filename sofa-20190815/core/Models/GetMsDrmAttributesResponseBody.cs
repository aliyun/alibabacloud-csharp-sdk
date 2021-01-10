// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetMsDrmAttributesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("DrmAttribute")]
        [Validation(Required=false)]
        public GetMsDrmAttributesResponseBodyDrmAttribute DrmAttribute { get; set; }
        public class GetMsDrmAttributesResponseBodyDrmAttribute : TeaModel {
            [NameInMap("AttributeName")]
            [Validation(Required=false)]
            public string AttributeName { get; set; }
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }
            [NameInMap("Parent")]
            [Validation(Required=false)]
            public GetMsDrmAttributesResponseBodyDrmAttributeParent Parent { get; set; }
            public class GetMsDrmAttributesResponseBodyDrmAttributeParent : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ResourceDomain")]
                [Validation(Required=false)]
                public string ResourceDomain { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceVersion")]
                [Validation(Required=false)]
                public string ResourceVersion { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }
        };

    }

}
