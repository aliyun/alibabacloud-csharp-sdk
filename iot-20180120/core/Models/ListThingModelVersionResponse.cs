// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListThingModelVersionResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListThingModelVersionResponseData Data { get; set; }
        public class ListThingModelVersionResponseData : TeaModel {
            [NameInMap("ModelVersions")]
            [Validation(Required=true)]
            public List<ListThingModelVersionResponseDataModelVersions> ModelVersions { get; set; }
            public class ListThingModelVersionResponseDataModelVersions : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=true)]
                public long? GmtCreate { get; set; }

                [NameInMap("ModelVersion")]
                [Validation(Required=true)]
                public string ModelVersion { get; set; }

            }

        }

    }

}
