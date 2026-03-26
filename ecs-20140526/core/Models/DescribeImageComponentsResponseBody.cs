// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageComponentsResponseBody : TeaModel {
        [NameInMap("ImageComponent")]
        [Validation(Required=false)]
        public DescribeImageComponentsResponseBodyImageComponent ImageComponent { get; set; }
        public class DescribeImageComponentsResponseBodyImageComponent : TeaModel {
            [NameInMap("ImageComponentSet")]
            [Validation(Required=false)]
            public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSet> ImageComponentSet { get; set; }
            public class DescribeImageComponentsResponseBodyImageComponentImageComponentSet : TeaModel {
                [NameInMap("ComponentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                [NameInMap("ComponentVersion")]
                [Validation(Required=false)]
                public string ComponentVersion { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ImageComponentId")]
                [Validation(Required=false)]
                public string ImageComponentId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

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

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SystemType")]
                [Validation(Required=false)]
                public string SystemType { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeImageComponentsResponseBodyImageComponentImageComponentSetTags Tags { get; set; }
                public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeImageComponentsResponseBodyImageComponentImageComponentSetTagsTag> Tag { get; set; }
                    public class DescribeImageComponentsResponseBodyImageComponentImageComponentSetTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

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
