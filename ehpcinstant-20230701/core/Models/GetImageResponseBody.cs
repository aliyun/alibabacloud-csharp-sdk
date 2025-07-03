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
            [NameInMap("AdditionalRegionsInfo")]
            [Validation(Required=false)]
            public List<GetImageResponseBodyImageAdditionalRegionsInfo> AdditionalRegionsInfo { get; set; }
            public class GetImageResponseBodyImageAdditionalRegionsInfo : TeaModel {
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("ContainerImageSpec")]
            [Validation(Required=false)]
            public GetImageResponseBodyImageContainerImageSpec ContainerImageSpec { get; set; }
            public class GetImageResponseBodyImageContainerImageSpec : TeaModel {
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

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

                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("RegistryCredential")]
                [Validation(Required=false)]
                public GetImageResponseBodyImageContainerImageSpecRegistryCredential RegistryCredential { get; set; }
                public class GetImageResponseBodyImageContainerImageSpecRegistryCredential : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-23T09:51:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DocumentInfo")]
            [Validation(Required=false)]
            public GetImageResponseBodyImageDocumentInfo DocumentInfo { get; set; }
            public class GetImageResponseBodyImageDocumentInfo : TeaModel {
                [NameInMap("Document")]
                [Validation(Required=false)]
                public string Document { get; set; }

                [NameInMap("DocumentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                [NameInMap("EncodingMode")]
                [Validation(Required=false)]
                public string EncodingMode { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VM</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>app-image</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40 GiB</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>x86_64</para>
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>m-uf60twafjtaart******</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CentOS  7.6 64 bit</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CentOS</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
