// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetImageResponseBody : TeaModel {
        [NameInMap("Image")]
        [Validation(Required=false)]
        public GetImageResponseBodyImage Image { get; set; }
        public class GetImageResponseBodyImage : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("ContainerImageSpec")]
            [Validation(Required=false)]
            public GetImageResponseBodyImageContainerImageSpec ContainerImageSpec { get; set; }
            public class GetImageResponseBodyImageContainerImageSpec : TeaModel {
                [NameInMap("IsACREnterprise")]
                [Validation(Required=false)]
                public bool? IsACREnterprise { get; set; }

                [NameInMap("IsACRRegistry")]
                [Validation(Required=false)]
                public bool? IsACRRegistry { get; set; }

                [NameInMap("RegistryCredential")]
                [Validation(Required=false)]
                public GetImageResponseBodyImageContainerImageSpecRegistryCredential RegistryCredential { get; set; }
                public class GetImageResponseBodyImageContainerImageSpecRegistryCredential : TeaModel {
                    [NameInMap("Password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    [NameInMap("Server")]
                    [Validation(Required=false)]
                    public string Server { get; set; }

                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                [NameInMap("RegistryCriId")]
                [Validation(Required=false)]
                public string RegistryCriId { get; set; }

                [NameInMap("RegistryUrl")]
                [Validation(Required=false)]
                public string RegistryUrl { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VMImageSpec")]
            [Validation(Required=false)]
            public GetImageResponseBodyImageVMImageSpec VMImageSpec { get; set; }
            public class GetImageResponseBodyImageVMImageSpec : TeaModel {
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

            }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
