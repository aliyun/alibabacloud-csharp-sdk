// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListThingModelVersionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListThingModelVersionResponseBodyData Data { get; set; }
        public class ListThingModelVersionResponseBodyData : TeaModel {
            [NameInMap("ModelVersions")]
            [Validation(Required=false)]
            public List<ListThingModelVersionResponseBodyDataModelVersions> ModelVersions { get; set; }
            public class ListThingModelVersionResponseBodyDataModelVersions : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("ModelVersion")]
                [Validation(Required=false)]
                public string ModelVersion { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
