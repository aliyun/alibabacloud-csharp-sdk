// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acc20240402.Models
{
    public class ListImageCachesResponseBody : TeaModel {
        /// <summary>
        /// <para>The image cache information.</para>
        /// </summary>
        [NameInMap("ImageCaches")]
        [Validation(Required=false)]
        public List<ListImageCachesResponseBodyImageCaches> ImageCaches { get; set; }
        public class ListImageCachesResponseBodyImageCaches : TeaModel {
            /// <summary>
            /// <para>The time when the image cache was created. The time follows the ISO 8601 standard and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-**-**T07:55:25Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imc-bp1dj*****</para>
            /// </summary>
            [NameInMap("ImageCacheId")]
            [Validation(Required=false)]
            public string ImageCacheId { get; set; }

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
            /// <para>The container images in the image cache.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// <para>Available time when the image cache became available. Available time follows the ISO 8601 standard and is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-**-**T07:58:25Z</para>
            /// </summary>
            [NameInMap("ReadyTime")]
            [Validation(Required=false)]
            public string ReadyTime { get; set; }

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
            /// <para>The size of the image cache. Unit: GiB. Minimum value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The cache status of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
        /// <para>The pagination token returned for this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E234675-3465-4CC3-9D0F-9A864BC*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of results returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
