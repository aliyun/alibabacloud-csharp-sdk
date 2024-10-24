// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class AddImageRequest : TeaModel {
        [NameInMap("ContainerImageSpec")]
        [Validation(Required=false)]
        public AddImageRequestContainerImageSpec ContainerImageSpec { get; set; }
        public class AddImageRequestContainerImageSpec : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsACREnterprise")]
            [Validation(Required=false)]
            public bool? IsACREnterprise { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsACRRegistry")]
            [Validation(Required=false)]
            public bool? IsACRRegistry { get; set; }

            [NameInMap("RegistryCredential")]
            [Validation(Required=false)]
            public AddImageRequestContainerImageSpecRegistryCredential RegistryCredential { get; set; }
            public class AddImageRequestContainerImageSpecRegistryCredential : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>userpassword</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cri-xyz795ygf8k9****</para>
            /// </summary>
            [NameInMap("RegistryCriId")]
            [Validation(Required=false)]
            public string RegistryCriId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/ehpc_open/nginx:latest</para>
            /// </summary>
            [NameInMap("RegistryUrl")]
            [Validation(Required=false)]
            public string RegistryUrl { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>V1.0</para>
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-image</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("VMImageSpec")]
        [Validation(Required=false)]
        public AddImageRequestVMImageSpec VMImageSpec { get; set; }
        public class AddImageRequestVMImageSpec : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>m-bp1akkkr1rkxtb******</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

        }

    }

}
