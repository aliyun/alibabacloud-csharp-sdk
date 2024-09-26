// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeDataCachesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the data caches.</para>
        /// </summary>
        [NameInMap("DataCaches")]
        [Validation(Required=false)]
        public List<DescribeDataCachesResponseBodyDataCaches> DataCaches { get; set; }
        public class DescribeDataCachesResponseBodyDataCaches : TeaModel {
            /// <summary>
            /// <para>The bucket that stores the data cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// <para>The ID of the elastic container instance that was generated when the data cache was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eci-8vb1y2w1dv7zeirn****</para>
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// <para>The time when the data cache was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-16T02:43Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the data cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edc-bp15l4vvys94oo******</para>
            /// </summary>
            [NameInMap("DataCacheId")]
            [Validation(Required=false)]
            public string DataCacheId { get; set; }

            /// <summary>
            /// <para>The information about the data source.</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public DescribeDataCachesResponseBodyDataCachesDataSource DataSource { get; set; }
            public class DescribeDataCachesResponseBodyDataCachesDataSource : TeaModel {
                /// <summary>
                /// <para>The parameters that are configured for the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///       &quot;options&quot;: {
                ///             &quot;path&quot;: &quot;/&quot;,
                ///             &quot;server&quot;: &quot;0ce1f4****-or***.cn-hangzhou.nas.aliyuncs.com&quot;,
                ///             &quot;vers&quot;: &quot;3&quot;,
                ///             &quot;options&quot;: &quot;nolock,proto=tcp,rsize=1048576,wsize=1048576,hard,timeo=600,retrans=2,noresvport&quot;
                ///       },
                ///       &quot;type&quot;: &quot;NAS&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// <para>The type of the data source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NAS</description></item>
                /// <item><description>OSS</description></item>
                /// <item><description>URL</description></item>
                /// <item><description>SNAPSHOT</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>URL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The events.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeDataCachesResponseBodyDataCachesEvents> Events { get; set; }
            public class DescribeDataCachesResponseBodyDataCachesEvents : TeaModel {
                /// <summary>
                /// <para>The number of times that the event occurred.</para>
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
                /// <para>2021-06-16T02:14:48Z</para>
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// <para>The time when the event ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-16T02:24:48Z</para>
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// <para>The message about the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Successfully check data cache resource.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The event name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datacache</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The reason for the transition into the current status of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Started</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The type of the event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal</description></item>
                /// <item><description>Warning</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The time when the data cache expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-26T02:43Z</para>
            /// </summary>
            [NameInMap("ExpireDateTime")]
            [Validation(Required=false)]
            public string ExpireDateTime { get; set; }

            /// <summary>
            /// <para>The ID of the on-premises snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-bp12w3v37sit96t6****</para>
            /// </summary>
            [NameInMap("FlashSnapshotId")]
            [Validation(Required=false)]
            public string FlashSnapshotId { get; set; }

            /// <summary>
            /// <para>The time when the data cache was last matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-18T02:43Z</para>
            /// </summary>
            [NameInMap("LastMatchedTime")]
            [Validation(Required=false)]
            public string LastMatchedTime { get; set; }

            /// <summary>
            /// <para>The name of the data cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The directory in which the virtual host of the data cache resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/data/models/</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The creation progress of the data cache.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
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
            /// <para>rg-aek2hlt3ux4****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The size of the data cache. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The snapshot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-2zec5oj8e1yhxijt****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The status of the data cache. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Loading: The data cache is loading data.</description></item>
            /// <item><description>Creating: The data cache is being created.</description></item>
            /// <item><description>Available: The data cache is created.</description></item>
            /// <item><description>Failed: The data cache failed to be created.</description></item>
            /// <item><description>Updating: The data cache is being updated.</description></item>
            /// <item><description>UpdateFailed: The data cache failed to be updated.</description></item>
            /// </list>
            /// <para>If the data cache is in the Available state, the data cache can be used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags that are attached to the data cache.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDataCachesResponseBodyDataCachesTags> Tags { get; set; }
            public class DescribeDataCachesResponseBodyDataCachesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testkey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testvalue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The query token. Set the value to the NextToken value that is returned in the previous call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d78f2dd8-5979-42fe-xaee-b16db43be5bc</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8756BA0-6452-419C-9727-37A6209C85E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
