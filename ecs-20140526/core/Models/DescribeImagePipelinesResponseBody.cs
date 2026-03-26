// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelinesResponseBody : TeaModel {
        [NameInMap("ImagePipeline")]
        [Validation(Required=false)]
        public DescribeImagePipelinesResponseBodyImagePipeline ImagePipeline { get; set; }
        public class DescribeImagePipelinesResponseBodyImagePipeline : TeaModel {
            [NameInMap("ImagePipelineSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet> ImagePipelineSet { get; set; }
            public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet : TeaModel {
                [NameInMap("AddAccounts")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts AddAccounts { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts : TeaModel {
                    [NameInMap("AddAccount")]
                    [Validation(Required=false)]
                    public List<string> AddAccount { get; set; }

                }

                [NameInMap("AdvancedOptions")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAdvancedOptions AdvancedOptions { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAdvancedOptions : TeaModel {
                    [NameInMap("ImageNameSuffix")]
                    [Validation(Required=false)]
                    public string ImageNameSuffix { get; set; }

                    [NameInMap("RetainCloudAssistant")]
                    [Validation(Required=false)]
                    public bool? RetainCloudAssistant { get; set; }

                }

                [NameInMap("BaseImage")]
                [Validation(Required=false)]
                public string BaseImage { get; set; }

                [NameInMap("BaseImageType")]
                [Validation(Required=false)]
                public string BaseImageType { get; set; }

                [NameInMap("BuildContent")]
                [Validation(Required=false)]
                public string BuildContent { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DeleteInstanceOnFailure")]
                [Validation(Required=false)]
                public bool? DeleteInstanceOnFailure { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <term><b>Obsolete</b></term>
                [NameInMap("ImageFamily")]
                [Validation(Required=false)]
                [Obsolete]
                public string ImageFamily { get; set; }

                /// <term><b>Obsolete</b></term>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                [Obsolete]
                public string ImageName { get; set; }

                [NameInMap("ImageOptions")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImageOptions ImageOptions { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImageOptions : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("ImageFamily")]
                    [Validation(Required=false)]
                    public string ImageFamily { get; set; }

                    [NameInMap("ImageFeatures")]
                    [Validation(Required=false)]
                    public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImageOptionsImageFeatures ImageFeatures { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImageOptionsImageFeatures : TeaModel {
                        [NameInMap("NvmeSupport")]
                        [Validation(Required=false)]
                        public string NvmeSupport { get; set; }

                    }

                    [NameInMap("ImageName")]
                    [Validation(Required=false)]
                    public string ImageName { get; set; }

                    [NameInMap("ImageTags")]
                    [Validation(Required=false)]
                    public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImageOptionsImageTags ImageTags { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImageOptionsImageTags : TeaModel {
                        [NameInMap("ImageTag")]
                        [Validation(Required=false)]
                        public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImageOptionsImageTagsImageTag> ImageTag { get; set; }
                        public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImageOptionsImageTagsImageTag : TeaModel {
                            [NameInMap("TagKey")]
                            [Validation(Required=false)]
                            public string TagKey { get; set; }

                            [NameInMap("TagValue")]
                            [Validation(Required=false)]
                            public string TagValue { get; set; }

                        }

                    }

                }

                [NameInMap("ImagePipelineId")]
                [Validation(Required=false)]
                public string ImagePipelineId { get; set; }

                [NameInMap("ImportImageOptions")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptions ImportImageOptions { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptions : TeaModel {
                    [NameInMap("Architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    [NameInMap("BootMode")]
                    [Validation(Required=false)]
                    public string BootMode { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("DiskDeviceMappings")]
                    [Validation(Required=false)]
                    public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsDiskDeviceMappings DiskDeviceMappings { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsDiskDeviceMappings : TeaModel {
                        [NameInMap("DiskDeviceMapping")]
                        [Validation(Required=false)]
                        public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsDiskDeviceMappingsDiskDeviceMapping> DiskDeviceMapping { get; set; }
                        public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsDiskDeviceMappingsDiskDeviceMapping : TeaModel {
                            [NameInMap("DiskImageSize")]
                            [Validation(Required=false)]
                            public int? DiskImageSize { get; set; }

                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                            [NameInMap("OSSBucket")]
                            [Validation(Required=false)]
                            public string OSSBucket { get; set; }

                            [NameInMap("OSSObject")]
                            [Validation(Required=false)]
                            public string OSSObject { get; set; }

                        }

                    }

                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsFeatures Features { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsFeatures : TeaModel {
                        [NameInMap("ImdsSupport")]
                        [Validation(Required=false)]
                        public string ImdsSupport { get; set; }

                        [NameInMap("NvmeSupport")]
                        [Validation(Required=false)]
                        public string NvmeSupport { get; set; }

                    }

                    [NameInMap("ImageName")]
                    [Validation(Required=false)]
                    public string ImageName { get; set; }

                    [NameInMap("ImportImageTags")]
                    [Validation(Required=false)]
                    public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsImportImageTags ImportImageTags { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsImportImageTags : TeaModel {
                        [NameInMap("ImportImageTag")]
                        [Validation(Required=false)]
                        public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsImportImageTagsImportImageTag> ImportImageTag { get; set; }
                        public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetImportImageOptionsImportImageTagsImportImageTag : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    [NameInMap("LicenseType")]
                    [Validation(Required=false)]
                    public string LicenseType { get; set; }

                    [NameInMap("OSType")]
                    [Validation(Required=false)]
                    public string OSType { get; set; }

                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    [NameInMap("RetainImportedImage")]
                    [Validation(Required=false)]
                    public bool? RetainImportedImage { get; set; }

                    [NameInMap("RetentionStrategy")]
                    [Validation(Required=false)]
                    public string RetentionStrategy { get; set; }

                    [NameInMap("RoleName")]
                    [Validation(Required=false)]
                    public string RoleName { get; set; }

                }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <term><b>Obsolete</b></term>
                [NameInMap("NvmeSupport")]
                [Validation(Required=false)]
                [Obsolete]
                public string NvmeSupport { get; set; }

                [NameInMap("RepairMode")]
                [Validation(Required=false)]
                public string RepairMode { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags Tags { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("TestContent")]
                [Validation(Required=false)]
                public string TestContent { get; set; }

                [NameInMap("ToRegionIds")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds ToRegionIds { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds : TeaModel {
                    [NameInMap("ToRegionId")]
                    [Validation(Required=false)]
                    public List<string> ToRegionId { get; set; }

                }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. For information about how to use the return value, see the &quot;Usage notes&quot; section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of image templates returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
