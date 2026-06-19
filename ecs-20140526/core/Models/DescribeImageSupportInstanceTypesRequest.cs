// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageSupportInstanceTypesRequest : TeaModel {
        /// <summary>
        /// <para>The scenario in which the image is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateEcs (default): instance creation.</description></item>
        /// <item><description>ChangeOS: replacement of the system disk or operating system.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateEcs</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The list of filter conditions for querying resources.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeImageSupportInstanceTypesRequestFilter> Filter { get; set; }
        public class DescribeImageSupportInstanceTypesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition key. Currently, only filtering by image ID is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>imageId: filters by image ID.</description></item>
            /// <item><description>filter: filters by image ID.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is not effective and will be deprecated soon.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>imageId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter condition value.</para>
            /// <remarks>
            /// <para>This parameter is not effective and will be deprecated soon.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>m-o6w3gy99qf89rkga****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-o6w3gy99qf89rkga****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the image. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
