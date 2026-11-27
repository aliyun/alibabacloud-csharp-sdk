// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acc20240402.Models
{
    public class CreateImageCacheRequest : TeaModel {
        /// <summary>
        /// <para>The ACR Enterprise instance information.</para>
        /// </summary>
        [NameInMap("AcrRegistryInfos")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestAcrRegistryInfos> AcrRegistryInfos { get; set; }
        public class CreateImageCacheRequestAcrRegistryInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the ACR Enterprise instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-nwj395hgf6f*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region to which the ACR Enterprise instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7f3a2c18-6c47-4eb7-a6bb-8432a394a620</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable base image cache matching. Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableBaseImageCacheMatch")]
        [Validation(Required=false)]
        public bool? EnableBaseImageCacheMatch { get; set; }

        /// <summary>
        /// <para>The name of the image cache.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-imc</para>
        /// </summary>
        [NameInMap("ImageCacheName")]
        [Validation(Required=false)]
        public string ImageCacheName { get; set; }

        /// <summary>
        /// <para>The credentials of the image registry.</para>
        /// </summary>
        [NameInMap("ImageRegistryCredentials")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestImageRegistryCredentials> ImageRegistryCredentials { get; set; }
        public class CreateImageCacheRequestImageRegistryCredentials : TeaModel {
            /// <summary>
            /// <para>The password of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mypassword</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The address of the image registry without the http:// or https:// prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            /// <summary>
            /// <para>Specifies whether to skip certificate verification when you create an image cache by using images from a self-managed image registry that uses a self-signed certificate to prevent image pull failures caused by certificate verification failures.
            /// Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SkipCertVerification")]
            [Validation(Required=false)]
            public bool? SkipCertVerification { get; set; }

            /// <summary>
            /// <para>Specifies whether the service uses the HTTP protocol to pull images to prevent image pull failures caused by protocol mismatches.
            /// Default value: <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UsePlainHttp")]
            [Validation(Required=false)]
            public bool? UsePlainHttp { get; set; }

            /// <summary>
            /// <para>The username of the image registry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myusername</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <para>The container images used to create the image cache. Currently, only one image is supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The network configurations for pulling images when creating the image cache.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NetworkConfig")]
        [Validation(Required=false)]
        public CreateImageCacheRequestNetworkConfig NetworkConfig { get; set; }
        public class CreateImageCacheRequestNetworkConfig : TeaModel {
            /// <summary>
            /// <para>The configurations of the elastic IP address (EIP) instance.</para>
            /// </summary>
            [NameInMap("EipInstance")]
            [Validation(Required=false)]
            public CreateImageCacheRequestNetworkConfigEipInstance EipInstance { get; set; }
            public class CreateImageCacheRequestNetworkConfigEipInstance : TeaModel {
                /// <summary>
                /// <para>Specifies whether automatic creation of an EIP is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoCreate")]
                [Validation(Required=false)]
                public bool? AutoCreate { get; set; }

                /// <summary>
                /// <para>The bandwidth of the EIP for automatic creation. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The elastic IP address. This parameter takes precedence. If you specify this parameter, other parameters are ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eip-0jl0bx3fnpnjc9i4*****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-0jlgektkddwa42n*****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The IDs of the vSwitches. You can specify up to 10 vSwitch IDs. One of the vSwitches is selected to pull the image.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

        }

        /// <summary>
        /// <para>The platform type of the image cache. Valid values: linux/amd64 and windows/amd64. Default value: linux/amd64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>windows/amd64</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzh43v*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the image cache. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateImageCacheRequestTags> Tags { get; set; }
        public class CreateImageCacheRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imc</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the image cache. Valid values: <c>General</c> and <c>Base</c>. Default value: <c>General</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
