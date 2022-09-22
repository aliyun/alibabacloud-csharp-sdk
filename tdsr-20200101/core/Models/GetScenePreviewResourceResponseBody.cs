// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetScenePreviewResourceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetScenePreviewResourceResponseBodyData Data { get; set; }
        public class GetScenePreviewResourceResponseBodyData : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ResourceDirectory")]
            [Validation(Required=false)]
            public GetScenePreviewResourceResponseBodyDataResourceDirectory ResourceDirectory { get; set; }
            public class GetScenePreviewResourceResponseBodyDataResourceDirectory : TeaModel {
                [NameInMap("HotspotTagConfig")]
                [Validation(Required=false)]
                public string HotspotTagConfig { get; set; }

                [NameInMap("ModelConfig")]
                [Validation(Required=false)]
                public string ModelConfig { get; set; }

                [NameInMap("OrthomapConfig")]
                [Validation(Required=false)]
                public string OrthomapConfig { get; set; }

                [NameInMap("RootPath")]
                [Validation(Required=false)]
                public string RootPath { get; set; }

            }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
