// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeImageCachesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about image caches.</para>
        /// </summary>
        [NameInMap("ImageCaches")]
        [Validation(Required=false)]
        public List<DescribeImageCachesResponseBodyImageCaches> ImageCaches { get; set; }
        public class DescribeImageCachesResponseBodyImageCaches : TeaModel {
            /// <summary>
            /// <para>The ID of the elastic container instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eci-bp18oq3m15prd9jb****</para>
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// <para>The time when the image cache was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-09T02:24:07Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The elimination policy of the image cache. This parameter is empty by default, which indicates that the image cache is always retained.</para>
            /// <para>You can set this parameter to LRU, which indicates that the image cache can be automatically deleted. When the number of image caches reaches the quota, the system automatically deletes the image caches whose EliminationStrategy parameter is set to LRU and that are least regularly used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LRU</para>
            /// </summary>
            [NameInMap("EliminationStrategy")]
            [Validation(Required=false)]
            public string EliminationStrategy { get; set; }

            /// <summary>
            /// <para>The events of pulling an image to create the image cache.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeImageCachesResponseBodyImageCachesEvents> Events { get; set; }
            public class DescribeImageCachesResponseBodyImageCachesEvents : TeaModel {
                /// <summary>
                /// <para>The number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The time when the event started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-02-09T02:24:48Z</para>
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// <para>The time when the event ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-02-09T02:24:48Z</para>
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// <para>The message about the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Successfully check image cache resource.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The name of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imagetest.1661f31f851a****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The cause of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Started</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The type of the event. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The time when the image cache expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-11-10T09:00:48Z</para>
            /// </summary>
            [NameInMap("ExpireDateTime")]
            [Validation(Required=false)]
            public string ExpireDateTime { get; set; }

            /// <summary>
            /// <para>The ID of the local snapshot. A temporary local snapshot is created if the instant image cache feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp12w3v37sit96t6****</para>
            /// </summary>
            [NameInMap("FlashSnapshotId")]
            [Validation(Required=false)]
            public string FlashSnapshotId { get; set; }

            /// <summary>
            /// <para>The ID of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imc-bp195erqe9o2pb09****</para>
            /// </summary>
            [NameInMap("ImageCacheId")]
            [Validation(Required=false)]
            public string ImageCacheId { get; set; }

            /// <summary>
            /// <para>The name of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imagetest</para>
            /// </summary>
            [NameInMap("ImageCacheName")]
            [Validation(Required=false)]
            public string ImageCacheName { get; set; }

            /// <summary>
            /// <para>The size of the image cache. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ImageCacheSize")]
            [Validation(Required=false)]
            public int? ImageCacheSize { get; set; }

            /// <summary>
            /// <para>The images contained in the image cache.</para>
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// <para>The time when the image cache was last matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-08-18T03:48:10Z</para>
            /// </summary>
            [NameInMap("LastMatchedTime")]
            [Validation(Required=false)]
            public string LastMatchedTime { get; set; }

            /// <summary>
            /// <para>The progress of creating the snapshot that is used to create the image cache.</para>
            /// <remarks>
            /// <para> If the instant image cache feature is enabled, the system creates a temporary local snapshot and then a regular snapshot. In this case, this parameter indicates the progress of creating the regular snapshot.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The region ID of the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the image cache belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-2df3isufhi38****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the snapshot that corresponds to the image cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-2zec5oj8e1yhxijt****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The status of the image cache. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Preparing: The image cache is being prepared.</description></item>
            /// <item><description>Creating: The image is being created.</description></item>
            /// <item><description>Ready: The image cache is created.</description></item>
            /// <item><description>Failed: The image cache failed to be created.</description></item>
            /// <item><description>Updating: The image cache is being updated.</description></item>
            /// <item><description>UpdateFailed: The image cache failed to be updated.</description></item>
            /// </list>
            /// <para>The image cache is ready for use when it is in the Ready state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the image cache.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeImageCachesResponseBodyImageCachesTags> Tags { get; set; }
            public class DescribeImageCachesResponseBodyImageCachesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>imc</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
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
        /// <para>39FC2E43-3DD7-4CEF-9EF4-E4AD6E635301</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
