// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelinesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the image templates.</para>
        /// </summary>
        [NameInMap("ImagePipeline")]
        [Validation(Required=false)]
        public DescribeImagePipelinesResponseBodyImagePipeline ImagePipeline { get; set; }
        public class DescribeImagePipelinesResponseBodyImagePipeline : TeaModel {
            [NameInMap("ImagePipelineSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet> ImagePipelineSet { get; set; }
            public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSet : TeaModel {
                /// <summary>
                /// <para>The IDs of Alibaba Cloud accounts to which to share the image that will be created based on the image template.</para>
                /// </summary>
                [NameInMap("AddAccounts")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts AddAccounts { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetAddAccounts : TeaModel {
                    [NameInMap("AddAccount")]
                    [Validation(Required=false)]
                    public List<string> AddAccount { get; set; }

                }

                /// <summary>
                /// <para>The source image.</para>
                /// <list type="bullet">
                /// <item><description>When <c>BaseImageType</c> is set to IMAGE, the value of this parameter is the ID of a custom image.</description></item>
                /// <item><description>When <c>BaseImageType</c> is set to IMAGE_FAMILY, the value of this parameter is the name of an image family.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("BaseImage")]
                [Validation(Required=false)]
                public string BaseImage { get; set; }

                /// <summary>
                /// <para>The type of the source image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IMAGE: custom image</description></item>
                /// <item><description>IMAGE_FAMILY: image family</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IMAGE</para>
                /// </summary>
                [NameInMap("BaseImageType")]
                [Validation(Required=false)]
                public string BaseImageType { get; set; }

                /// <summary>
                /// <para>The content of the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FROM IMAGE:m-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("BuildContent")]
                [Validation(Required=false)]
                public string BuildContent { get; set; }

                /// <summary>
                /// <para>The time when the image template was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-24T06:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Indicates whether to release the intermediate instance when the image fails to be created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteInstanceOnFailure")]
                [Validation(Required=false)]
                public bool? DeleteInstanceOnFailure { get; set; }

                /// <summary>
                /// <para>The description of the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name prefix of the image to be created based on the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testImageName</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The ID of the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip-2ze5tsl5bp6nf2b3****</para>
                /// </summary>
                [NameInMap("ImagePipelineId")]
                [Validation(Required=false)]
                public string ImagePipelineId { get; set; }

                /// <summary>
                /// <para>The instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.g6.large</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>The size of the outbound public bandwidth for the intermediate instance. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InternetMaxBandwidthOut")]
                [Validation(Required=false)]
                public int? InternetMaxBandwidthOut { get; set; }

                /// <summary>
                /// <para>The name of the image template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testImagePipeline</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The system disk size of the intermediate instance. Unit: GiB</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public int? SystemDiskSize { get; set; }

                /// <summary>
                /// <para>The tags of the image template.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags Tags { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestKey</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>TestValue</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// <para>The IDs of regions to which to distribute the image that will be created based on the image template.</para>
                /// </summary>
                [NameInMap("ToRegionIds")]
                [Validation(Required=false)]
                public DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds ToRegionIds { get; set; }
                public class DescribeImagePipelinesResponseBodyImagePipelineImagePipelineSetToRegionIds : TeaModel {
                    [NameInMap("ToRegionId")]
                    [Validation(Required=false)]
                    public List<string> ToRegionId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the vSwitch in the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp67acfmxazb4p****</para>
                /// </summary>
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
