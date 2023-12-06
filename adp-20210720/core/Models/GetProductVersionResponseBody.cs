// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetProductVersionResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProductVersionResponseBodyData Data { get; set; }
        public class GetProductVersionResponseBodyData : TeaModel {
            [NameInMap("continuousIntegration")]
            [Validation(Required=false)]
            public bool? ContinuousIntegration { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("documentations")]
            [Validation(Required=false)]
            public List<GetProductVersionResponseBodyDataDocumentations> Documentations { get; set; }
            public class GetProductVersionResponseBodyDataDocumentations : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("extendedResources")]
            [Validation(Required=false)]
            public List<GetProductVersionResponseBodyDataExtendedResources> ExtendedResources { get; set; }
            public class GetProductVersionResponseBodyDataExtendedResources : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("foundationVersionUID")]
            [Validation(Required=false)]
            public string FoundationVersionUID { get; set; }

            [NameInMap("packageURL")]
            [Validation(Required=false)]
            public string PackageURL { get; set; }

            [NameInMap("platforms")]
            [Validation(Required=false)]
            public List<Platform> Platforms { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("productUID")]
            [Validation(Required=false)]
            public string ProductUID { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
