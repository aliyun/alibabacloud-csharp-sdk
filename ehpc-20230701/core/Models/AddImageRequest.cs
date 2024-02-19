// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20230701.Models
{
    public class AddImageRequest : TeaModel {
        [NameInMap("ContainerImageSpec")]
        [Validation(Required=false)]
        public AddImageRequestContainerImageSpec ContainerImageSpec { get; set; }
        public class AddImageRequestContainerImageSpec : TeaModel {
            [NameInMap("IsACREnterprise")]
            [Validation(Required=false)]
            public bool? IsACREnterprise { get; set; }

            [NameInMap("IsACRRegistry")]
            [Validation(Required=false)]
            public bool? IsACRRegistry { get; set; }

            [NameInMap("RegistryCredential")]
            [Validation(Required=false)]
            public AddImageRequestContainerImageSpecRegistryCredential RegistryCredential { get; set; }
            public class AddImageRequestContainerImageSpecRegistryCredential : TeaModel {
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

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("VMImageSpec")]
        [Validation(Required=false)]
        public AddImageRequestVMImageSpec VMImageSpec { get; set; }
        public class AddImageRequestVMImageSpec : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

        }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
