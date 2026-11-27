// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acc20240402.Models
{
    public class ListImageCachesRequest : TeaModel {
        /// <summary>
        /// <para>The container image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>egs-registry.cn-hangzhou.cr.aliyuncs.com/egs/vllm:0.9.0.1-pytorch2.7-cu128-20250612</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The name of the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-imc</para>
        /// </summary>
        [NameInMap("ImageCacheName")]
        [Validation(Required=false)]
        public string ImageCacheName { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set the value to the NextToken value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The cache status of the image cache.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the image cache. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListImageCachesRequestTags> Tags { get; set; }
        public class ListImageCachesRequestTags : TeaModel {
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

    }

}
