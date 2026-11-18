// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class GetImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The image details.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public GetImageResponseBodyImage Image { get; set; }
        public class GetImageResponseBodyImage : TeaModel {
            /// <summary>
            /// <para>The list of status information of the image in additional regions.</para>
            /// </summary>
            [NameInMap("AdditionalRegionsInfo")]
            [Validation(Required=false)]
            public List<GetImageResponseBodyImageAdditionalRegionsInfo> AdditionalRegionsInfo { get; set; }
            public class GetImageResponseBodyImageAdditionalRegionsInfo : TeaModel {
                /// <summary>
                /// <para>The image ID in the additional region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-f8abcdef0123456789ab</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The additional region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-heyuan</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of the image in the additional region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ci-vm-0123456789abcdef</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The configuration details of the container image.</para>
            /// </summary>
            [NameInMap("ContainerImageSpec")]
            [Validation(Required=false)]
            public GetImageResponseBodyImageContainerImageSpec ContainerImageSpec { get; set; }
            public class GetImageResponseBodyImageContainerImageSpec : TeaModel {
                /// <summary>
                /// <para>The architecture type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x86_64</para>
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is stored in Container Registry Enterprise Edition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>True: Yes.</description></item>
                /// <item><description>False: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("IsACREnterprise")]
                [Validation(Required=false)]
                public bool? IsACREnterprise { get; set; }

                /// <summary>
                /// <para>Indicates whether the image is stored in Container Registry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>True: Yes.</description></item>
                /// <item><description>False: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("IsACRRegistry")]
                [Validation(Required=false)]
                public bool? IsACRRegistry { get; set; }

                /// <summary>
                /// <para>The specific version identifier of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS  7.6 64 bit</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// <para>The platform type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The authentication information for the private image registry.</para>
                /// </summary>
                [NameInMap("RegistryCredential")]
                [Validation(Required=false)]
                public GetImageResponseBodyImageContainerImageSpecRegistryCredential RegistryCredential { get; set; }
                public class GetImageResponseBodyImageContainerImageSpecRegistryCredential : TeaModel {
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
                    /// <para>The server address of the image registry.</para>
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
            /// <para>The time when the image was created. The time is displayed in the YYYY-MM-DDTHH:mm:ssZ format, where Z represents UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-12-23T09:51:39Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The image description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Application test image</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The application document information associated with the image.</para>
            /// </summary>
            [NameInMap("DocumentInfo")]
            [Validation(Required=false)]
            public GetImageResponseBodyImageDocumentInfo DocumentInfo { get; set; }
            public class GetImageResponseBodyImageDocumentInfo : TeaModel {
                /// <summary>
                /// <para>The content of the application document.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VGhpcyBpcyBhbiBleGFtcGxlIGFwcGxpY2F0aW9uIGRvY3VtZW50Lg==</para>
                /// </summary>
                [NameInMap("Document")]
                [Validation(Required=false)]
                public string Document { get; set; }

                /// <summary>
                /// <para>The application document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("DocumentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                /// <summary>
                /// <para>The encoding method of the application document. Base64 and PlainText are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Base64</para>
                /// </summary>
                [NameInMap("EncodingMode")]
                [Validation(Required=false)]
                public string EncodingMode { get; set; }

            }

            /// <summary>
            /// <para>The image type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VM</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-image</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The image size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40 GiB</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The image status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The configuration details of the virtual machine image.</para>
            /// </summary>
            [NameInMap("VMImageSpec")]
            [Validation(Required=false)]
            public GetImageResponseBodyImageVMImageSpec VMImageSpec { get; set; }
            public class GetImageResponseBodyImageVMImageSpec : TeaModel {
                /// <summary>
                /// <para>The architecture type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>x86_64</para>
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-uf60twafjtaart******</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The specific version identifier of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS  7.6 64 bit</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// <para>The platform type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

            }

            /// <summary>
            /// <para>The version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the process of executing the command and obtaining the result is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of items that meet the request conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
