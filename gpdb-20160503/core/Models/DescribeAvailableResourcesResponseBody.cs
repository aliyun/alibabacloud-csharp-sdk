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
        /// <para>The available resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeAvailableResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeAvailableResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>Details of the supported engines and instance types.</para>
            /// </summary>
            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourcesResponseBodyResourcesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeAvailableResourcesResponseBodyResourcesSupportedEngines : TeaModel {
                /// <summary>
                /// <para>The instance resource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ecs</b>: Elastic storage mode.</para>
                /// </description></item>
                /// <item><description><para><b>serverless</b>: Serverless mode.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The supported engine version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.0</para>
                /// </summary>
                [NameInMap("SupportedEngineVersion")]
                [Validation(Required=false)]
                public string SupportedEngineVersion { get; set; }

                /// <summary>
                /// <para>The supported instance types.</para>
                /// </summary>
                [NameInMap("SupportedInstanceClasses")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClasses> SupportedInstanceClasses { get; set; }
                public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClasses : TeaModel {
                    /// <summary>
                    /// <para>The instance series. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>HighAvailability</b>: High-availability edition.</para>
                    /// </description></item>
                    /// <item><description><para><b>Basic</b>: Basic edition</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HighAvailability</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The description of the segment node instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Single-segment node with 2 cores and 16 GB of memory.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The display name of the segment node instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2C16G</para>
                    /// </summary>
                    [NameInMap("DisplayClass")]
                    [Validation(Required=false)]
                    public string DisplayClass { get; set; }

                    /// <summary>
                    /// <para>The instance type of the segment node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2C16G</para>
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// <para>Details of the segment nodes.</para>
                    /// </summary>
                    [NameInMap("NodeCount")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesNodeCount NodeCount { get; set; }
                    public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesNodeCount : TeaModel {
                        /// <summary>
                        /// <para>The maximum number of Segment nodes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>256</para>
                        /// </summary>
                        [NameInMap("MaxCount")]
                        [Validation(Required=false)]
                        public string MaxCount { get; set; }

                        /// <summary>
                        /// <para>The minimum number of Segment nodes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("MinCount")]
                        [Validation(Required=false)]
                        public string MinCount { get; set; }

                        /// <summary>
                        /// <para>The step size for adding nodes.</para>
                        /// <para>For example, if this parameter is set to 4, the number of nodes added must be a multiple of 4 when adding Segment nodes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Step")]
                        [Validation(Required=false)]
                        public string Step { get; set; }

                    }

                    /// <summary>
                    /// <para>The Segment storage capacity.</para>
                    /// </summary>
                    [NameInMap("StorageSize")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesStorageSize StorageSize { get; set; }
                    public class DescribeAvailableResourcesResponseBodyResourcesSupportedEnginesSupportedInstanceClassesStorageSize : TeaModel {
                        /// <summary>
                        /// <para>The maximum Segment storage capacity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("MaxCount")]
                        [Validation(Required=false)]
                        public string MaxCount { get; set; }

                        /// <summary>
                        /// <para>The minimum Segment storage capacity.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("MinCount")]
                        [Validation(Required=false)]
                        public string MinCount { get; set; }

                        /// <summary>
                        /// <para>The Segment storage expansion step size.</para>
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
                    /// <item><description><para><b>cloud_essd</b>: ESSD cloud disk.</para>
                    /// </description></item>
                    /// <item><description><para><b>cloud_efficiency</b>: Standard cloud disk.</para>
                    /// </description></item>
                    /// <item><description><para><b>oss</b>:OSS.</para>
                    /// </description></item>
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
            /// <para>The zone ID.</para>
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
