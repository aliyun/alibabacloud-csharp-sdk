// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class AddImageRequest : TeaModel {
        /// <summary>
        /// <para>The container image configuration.</para>
        /// </summary>
        [NameInMap("ContainerImageSpec")]
        [Validation(Required=false)]
        public AddImageRequestContainerImageSpec ContainerImageSpec { get; set; }
        public class AddImageRequestContainerImageSpec : TeaModel {
            /// <summary>
            /// <para>Specifies whether the image is stored in Alibaba Cloud Container Registry Enterprise Edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: yes</description></item>
            /// <item><description>False: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsACREnterprise")]
            [Validation(Required=false)]
            public bool? IsACREnterprise { get; set; }

            /// <summary>
            /// <para>Specifies whether the image is stored in Alibaba Cloud Container Registry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: yes</description></item>
            /// <item><description>False: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("IsACRRegistry")]
            [Validation(Required=false)]
            public bool? IsACRRegistry { get; set; }

            /// <summary>
            /// <para>The authentication credentials for the private image repository.</para>
            /// </summary>
            [NameInMap("RegistryCredential")]
            [Validation(Required=false)]
            public AddImageRequestContainerImageSpecRegistryCredential RegistryCredential { get; set; }
            public class AddImageRequestContainerImageSpecRegistryCredential : TeaModel {
                /// <summary>
                /// <para>The logon password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userpassword</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The registry address of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("Server")]
                [Validation(Required=false)]
                public string Server { get; set; }

                /// <summary>
                /// <para>The logon username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>username</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-xyz795ygf8k9****</para>
            /// </summary>
            [NameInMap("RegistryCriId")]
            [Validation(Required=false)]
            public string RegistryCriId { get; set; }

            /// <summary>
            /// <para>The access URL of the container image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/ehpc_open/nginx:latest</para>
            /// </summary>
            [NameInMap("RegistryUrl")]
            [Validation(Required=false)]
            public string RegistryUrl { get; set; }

        }

        /// <summary>
        /// <para>The image description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VM: virtual machine image</description></item>
        /// <item><description>Container: container image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VM</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The image version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V1.0</para>
        /// </summary>
        [NameInMap("ImageVersion")]
        [Validation(Required=false)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// <para>The image name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-image</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The virtual machine image configuration.</para>
        /// </summary>
        [NameInMap("VMImageSpec")]
        [Validation(Required=false)]
        public AddImageRequestVMImageSpec VMImageSpec { get; set; }
        public class AddImageRequestVMImageSpec : TeaModel {
            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-bp1akkkr1rkxtb******</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

        }

    }

}
