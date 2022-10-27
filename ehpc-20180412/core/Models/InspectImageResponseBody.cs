// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InspectImageResponseBody : TeaModel {
        [NameInMap("ImageStatus")]
        [Validation(Required=false)]
        public InspectImageResponseBodyImageStatus ImageStatus { get; set; }
        public class InspectImageResponseBodyImageStatus : TeaModel {
            [NameInMap("ImageInspectInfo")]
            [Validation(Required=false)]
            public InspectImageResponseBodyImageStatusImageInspectInfo ImageInspectInfo { get; set; }
            public class InspectImageResponseBodyImageStatusImageInspectInfo : TeaModel {
                [NameInMap("BootStrap")]
                [Validation(Required=false)]
                public string BootStrap { get; set; }

                [NameInMap("BuildArch")]
                [Validation(Required=false)]
                public string BuildArch { get; set; }

                [NameInMap("BuildDate")]
                [Validation(Required=false)]
                public string BuildDate { get; set; }

                [NameInMap("ContainerVersion")]
                [Validation(Required=false)]
                public string ContainerVersion { get; set; }

                [NameInMap("DefFrom")]
                [Validation(Required=false)]
                public string DefFrom { get; set; }

                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public string SchemaVersion { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
