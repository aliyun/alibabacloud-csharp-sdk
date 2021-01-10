// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateHasCloudarchIaasakemetadataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public CreateHasCloudarchIaasakemetadataResponseBodyResultContent ResultContent { get; set; }
        public class CreateHasCloudarchIaasakemetadataResponseBodyResultContent : TeaModel {
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public CreateHasCloudarchIaasakemetadataResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class CreateHasCloudarchIaasakemetadataResponseBodyResultContentTopErrorCode : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("ExceptionCode")]
                [Validation(Required=false)]
                public string ExceptionCode { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("ExceptionCodeDescription")]
                [Validation(Required=false)]
                public string ExceptionCodeDescription { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

            }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public CreateHasCloudarchIaasakemetadataResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class CreateHasCloudarchIaasakemetadataResponseBodyResultContentTopErrorReason : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
        };

    }

}
