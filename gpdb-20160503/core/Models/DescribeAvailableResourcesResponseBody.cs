// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeAvailableResourcesResponseBody : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61DC563C-F8E4-593A-8D27-CE**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeAvailableResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeAvailableResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The available engine version and specifications.</para>
            /// </summary>
            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourcesResponseBodyResourcesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeAvailableResourcesResponseBodyResourcesSupportedEngines : TeaModel {
                /// <summary>
                /// <para>The instance resource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ecs</b>: elastic storage mode</description></item>
                /// <item><description><b>serverless</b>: Serverless mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The available engine version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.0</para>
                /// </summary>
                [NameInMap("SupportedEngineVersion")]
                [Validation(Required=false)]
                public string SupportedEngineVersion { get; set; }

                /// <summary>
                /// <para>The available specifications.</para>
                /// </summary>
                [NameInMap("SupportedInstanceClasses")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClasses> SupportedInstanceClasses { get; set; }
                public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClasses : TeaModel {
                    /// <summary>
                    /// <para>The instance edition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>HighAvailability</b>: High-availability Edition</description></item>
                    /// <item><description><b>Basic</b>: Basic Edition</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HighAvailability</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The description of compute node specifications.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2C16G</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The specifications of each compute node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2C16G</para>
                    /// </summary>
                    [NameInMap("DisplayClass")]
                    [Validation(Required=false)]
                    public string DisplayClass { get; set; }

                    /// <summary>
                    /// <para>The specifications of each compute node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2C16G</para>
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// <para>Details about the compute nodes.</para>
                    /// </summary>
                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesNodeCount NodeCount { get; set; }
                    public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesNodeCount : TeaModel {
                        /// <summary>
                        /// <para>The maximum number of compute nodes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>256</para>
                        /// </summary>
                        [NameInMap("MaxCount")]
                        [Validation(Required=false)]
                        public string MaxCount { get; set; }

                        /// <summary>
                        /// <para>The minimum number of compute nodes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("MinCount")]
                        [Validation(Required=false)]
                        public string MinCount { get; set; }

                        /// <summary>
                        /// <para>The step size for adding compute nodes.</para>
                        /// <para>For example, if the value of this parameter is 4, compute nodes must be added by multiples of 4.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public string Step { get; set; }

                    }

                    /// <summary>
                    /// <para>Details about the storage capacity of compute nodes.</para>
                    /// </summary>
                    [NameInMap("StorageSize")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesStorageSize StorageSize { get; set; }
                    public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesStorageSize : TeaModel {
                        /// <summary>
                        /// <para>The maximum storage capacity of each compute node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("MaxCount")]
                        [Validation(Required=false)]
                        public string MaxCount { get; set; }

                        /// <summary>
                        /// <para>The minimum storage capacity of each compute node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("MinCount")]
                        [Validation(Required=false)]
                        public string MinCount { get; set; }

                        /// <summary>
                        /// <para>The step size for adding storage capacity for compute nodes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public string Step { get; set; }

                    }

                    /// <summary>
                    /// <para>The storage type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>cloud_essd</b>: enhanced SSD (ESSD)</description></item>
                    /// <item><description><b>cloud_efficiency</b>: ultra disk</description></item>
                    /// <item><description><b>oss</b>: Object Storage Service (OSS)</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_essd</para>
                    /// </summary>
                    [NameInMap("StorageType")]
                    [Validation(Required=false)]
                    public string StorageType { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
