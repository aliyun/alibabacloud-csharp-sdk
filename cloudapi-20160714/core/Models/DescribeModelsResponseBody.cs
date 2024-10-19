// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information about models. It is an array consisting of ModelDetail data.</para>
        /// </summary>
        [NameInMap("ModelDetails")]
        [Validation(Required=false)]
        public DescribeModelsResponseBodyModelDetails ModelDetails { get; set; }
        public class DescribeModelsResponseBodyModelDetails : TeaModel {
            [NameInMap("ModelDetail")]
            [Validation(Required=false)]
            public List<DescribeModelsResponseBodyModelDetailsModelDetail> ModelDetail { get; set; }
            public class DescribeModelsResponseBodyModelDetailsModelDetail : TeaModel {
                /// <summary>
                /// <para>The time when the model was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-29T11:07:48Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>The description of the model definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Model Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the API group to which the model belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30e792398d6c4569b04c0e53a3494381</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>766c0b9538a04bdf974953b5576783ba</para>
                /// </summary>
                [NameInMap("ModelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The URI of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://apigateway.aliyun.com/models/30e792398d6c4569b04c0e53a3494381/766c0b9538a04bdf974953b5576783ba">https://apigateway.aliyun.com/models/30e792398d6c4569b04c0e53a3494381/766c0b9538a04bdf974953b5576783ba</a></para>
                /// </summary>
                [NameInMap("ModelRef")]
                [Validation(Required=false)]
                public string ModelRef { get; set; }

                /// <summary>
                /// <para>The time when the model was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-29T11:07:48Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The definition of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;type\&quot;:\&quot;object\&quot;,\&quot;properties\&quot;:{\&quot;id\&quot;:{\&quot;format\&quot;:\&quot;int64\&quot;,\&quot;maximum\&quot;:100,\&quot;exclusiveMaximum\&quot;:true,\&quot;type\&quot;:\&quot;integer\&quot;},\&quot;name\&quot;:{\&quot;maxLength\&quot;:10,\&quot;type\&quot;:\&quot;string\&quot;}}}</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// <para>The tags of the model.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeModelsResponseBodyModelDetailsModelDetailTags Tags { get; set; }
                public class DescribeModelsResponseBodyModelDetailsModelDetailTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeModelsResponseBodyModelDetailsModelDetailTagsTagInfo> TagInfo { get; set; }
                    public class DescribeModelsResponseBodyModelDetailsModelDetailTagsTagInfo : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ENV</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ST4</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40306469-2FB5-417A-B723-AF1F4A4FA204</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
