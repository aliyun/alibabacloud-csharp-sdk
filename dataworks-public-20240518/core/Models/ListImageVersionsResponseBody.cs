// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListImageVersionsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListImageVersionsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListImageVersionsResponseBodyPagingInfo : TeaModel {
            [NameInMap("ImageVersions")]
            [Validation(Required=false)]
            public List<ListImageVersionsResponseBodyPagingInfoImageVersions> ImageVersions { get; set; }
            public class ListImageVersionsResponseBodyPagingInfoImageVersions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Public</para>
                /// </summary>
                [NameInMap("Accessibility")]
                [Validation(Required=false)]
                public string Accessibility { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-xxx</para>
                /// </summary>
                [NameInMap("AcrAssociatedVpcId")]
                [Validation(Required=false)]
                public string AcrAssociatedVpcId { get; set; }

                /// <summary>
                /// <para>ACR Endpoint</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.cn-hangzhou.aliyuncs.com</para>
                /// </summary>
                [NameInMap("AcrEndpoint")]
                [Validation(Required=false)]
                public string AcrEndpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cri-xxx</para>
                /// </summary>
                [NameInMap("AcrInstanceId")]
                [Validation(Required=false)]
                public string AcrInstanceId { get; set; }

                [NameInMap("BuildConfig")]
                [Validation(Required=false)]
                public ListImageVersionsResponseBodyPagingInfoImageVersionsBuildConfig BuildConfig { get; set; }
                public class ListImageVersionsResponseBodyPagingInfoImageVersionsBuildConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PackageInstallation</para>
                    /// </summary>
                    [NameInMap("BuildType")]
                    [Validation(Required=false)]
                    public string BuildType { get; set; }

                    [NameInMap("PackageInstallationScripts")]
                    [Validation(Required=false)]
                    public List<ListImageVersionsResponseBodyPagingInfoImageVersionsBuildConfigPackageInstallationScripts> PackageInstallationScripts { get; set; }
                    public class ListImageVersionsResponseBodyPagingInfoImageVersionsBuildConfigPackageInstallationScripts : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>requests</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Python3</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Test image created by xxx</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableSyncMaxCompute")]
                [Validation(Required=false)]
                public bool? EnableSyncMaxCompute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Custom_image_xxxx_xxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("ImageTag")]
                [Validation(Required=false)]
                public string ImageTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>registry.cn-hangzhou.aliyuncs.com/xxx/xxx:tag</para>
                /// </summary>
                [NameInMap("ImageUri")]
                [Validation(Required=false)]
                public string ImageUri { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/xxx/xxx:tag</para>
                /// </summary>
                [NameInMap("ImageVpcUri")]
                [Validation(Required=false)]
                public string ImageVpcUri { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public long? LastModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dataworks_image</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>namespace</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Official")]
                [Validation(Required=false)]
                public bool? Official { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acr_image_id</para>
                /// </summary>
                [NameInMap("ProviderImageId")]
                [Validation(Required=false)]
                public string ProviderImageId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACR</para>
                /// </summary>
                [NameInMap("ProviderType")]
                [Validation(Required=false)]
                public string ProviderType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("PublishStage")]
                [Validation(Required=false)]
                public string PublishStage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>repo_name</para>
                /// </summary>
                [NameInMap("RepositoryName")]
                [Validation(Required=false)]
                public string RepositoryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1GB</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Supported")]
                [Validation(Required=false)]
                public ListImageVersionsResponseBodyPagingInfoImageVersionsSupported Supported { get; set; }
                public class ListImageVersionsResponseBodyPagingInfoImageVersionsSupported : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Scheduler</para>
                    /// </summary>
                    [NameInMap("Module")]
                    [Validation(Required=false)]
                    public string Module { get; set; }

                    [NameInMap("TaskTypes")]
                    [Validation(Required=false)]
                    public List<string> TaskTypes { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
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

    }

}
