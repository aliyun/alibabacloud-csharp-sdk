// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageComponentsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the image components.</para>
        /// </summary>
        [NameInMap("ImageComponent")]
        [Validation(Required=false)]
        public DescribeImageComponentsResponseBodyImageComponent ImageComponent { get; set; }
        public class DescribeImageComponentsResponseBodyImageComponent : TeaModel {
            [NameInMap("ImageComponentSet")]
            [Validation(Required=false)]
            public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSet> ImageComponentSet { get; set; }
            public class DescribeImageComponentsResponseBodyImageComponentImageComponentSet : TeaModel {
                /// <summary>
                /// <para>The type of the image component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Build</para>
                /// </summary>
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("ComponentVersion")]
                [Validation(Required=false)]
                public string ComponentVersion { get; set; }

                /// <summary>
                /// <para>The content of the image component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RESTART</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The time when the image component was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-24T06:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the image component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is description.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the image component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ic-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ImageComponentId")]
                [Validation(Required=false)]
                public string ImageComponentId { get; set; }

                /// <summary>
                /// <para>The name of the image component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testComponent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the image component. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SELF: the custom component that you created.</description></item>
                /// <item><description>ALIYUN: the system component provided by Alibaba Cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SELF</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public DescribeImageComponentsResponseBodyImageComponentImageComponentSetParameters Parameters { get; set; }
                public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetParameters : TeaModel {
                    [NameInMap("Parameter")]
                    [Validation(Required=false)]
                    public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSetParametersParameter> Parameter { get; set; }
                    public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetParametersParameter : TeaModel {
                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the resource group to which the image component belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The type of the operating system supported by the image component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Linux</para>
                /// </summary>
                [NameInMap("SystemType")]
                [Validation(Required=false)]
                public string SystemType { get; set; }

                /// <summary>
                /// <para>The tags of the image component.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImageComponentsResponseBodyImageComponentImageComponentSetTags Tags { get; set; }
                public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSetTagsTag> Tag { get; set; }
                    public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetTagsTag : TeaModel {
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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. For information about how to use the returned value, see the &quot;Usage notes&quot; section of this topic.</para>
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
        /// <para>The total number of image components returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
