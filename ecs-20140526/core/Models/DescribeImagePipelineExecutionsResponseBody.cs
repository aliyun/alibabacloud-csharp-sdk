// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImagePipelineExecutionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the image creation task.</para>
        /// </summary>
        [NameInMap("ImagePipelineExecution")]
        [Validation(Required=false)]
        public DescribeImagePipelineExecutionsResponseBodyImagePipelineExecution ImagePipelineExecution { get; set; }
        public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecution : TeaModel {
            [NameInMap("ImagePipelineExecutionSet")]
            [Validation(Required=false)]
            public List<DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSet> ImagePipelineExecutionSet { get; set; }
            public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSet : TeaModel {
                /// <summary>
                /// <para>The time when the image creation task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-24T06:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the image creation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exec-5fb8facb8ed7427c****</para>
                /// </summary>
                [NameInMap("ExecutionId")]
                [Validation(Required=false)]
                public string ExecutionId { get; set; }

                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

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
                /// <para>The data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Create transition vpc &quot;vpc-2ze70rc7093j9idu6****&quot; success!</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The last modification time of the image creation task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-25T06:00:00Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

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
                /// <para>The status of the image creation task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BUILDING</description></item>
                /// <item><description>DISTRIBUTING</description></item>
                /// <item><description>RELEASING</description></item>
                /// <item><description>SUCCESS</description></item>
                /// <item><description>FAILED</description></item>
                /// <item><description>CANCELLING</description></item>
                /// <item><description>CANCELLED</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BUILDING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <remarks>
                /// <para>This parameter is not publicly available.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTags Tags { get; set; }
                public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTagsTag> Tag { get; set; }
                    public class DescribeImagePipelineExecutionsResponseBodyImagePipelineExecutionImagePipelineExecutionSetTagsTag : TeaModel {
                        /// <summary>
                        /// <remarks>
                        /// <para>This parameter is not publicly available.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// <remarks>
                        /// <para>This parameter is not publicly available.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>null</para>
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists. For information about how to use the returned value, see the &quot;Usage notes&quot; section in this topic.</para>
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
        /// <para>The total number of returned image components.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
