// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class DescribeEmbodiedAIPlatformsResponseBody : TeaModel {
        /// <summary>
        /// <para>Use the paged query parameters PageSize, PageNumber, and TotalCount for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Use the paged query parameters PageSize, PageNumber, and TotalCount for paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c3158c2e8acf616501bd5ee05******</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of embodied intelligence multimodal data platforms.</para>
        /// </summary>
        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<DescribeEmbodiedAIPlatformsResponseBodyPlatforms> Platforms { get; set; }
        public class DescribeEmbodiedAIPlatformsResponseBodyPlatforms : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-01 14:55:36</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The webserver configuration of the platform.</para>
            /// </summary>
            [NameInMap("EapConfig")]
            [Validation(Required=false)]
            public DescribeEmbodiedAIPlatformsResponseBodyPlatformsEapConfig EapConfig { get; set; }
            public class DescribeEmbodiedAIPlatformsResponseBodyPlatformsEapConfig : TeaModel {
                /// <summary>
                /// <para>The public network access address of the platform webserver.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://amv-2z******-***-roboto.ads.example.com:80">http://amv-2z******-***-roboto.ads.example.com:80</a></para>
                /// </summary>
                [NameInMap("WebserverAddress")]
                [Validation(Required=false)]
                public string WebserverAddress { get; set; }

                /// <summary>
                /// <para>The webserver specification of the platform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>large</para>
                /// </summary>
                [NameInMap("WebserverSpecName")]
                [Validation(Required=false)]
                public string WebserverSpecName { get; set; }

            }

            /// <summary>
            /// <para>The lake storage name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adb-lake-cn-beijing-5q1w******</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>The platform name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>platform1</para>
            /// </summary>
            [NameInMap("PlatformName")]
            [Validation(Required=false)]
            public string PlatformName { get; set; }

            /// <summary>
            /// <para>The Ray specification information of the platform.</para>
            /// </summary>
            [NameInMap("RayConfig")]
            [Validation(Required=false)]
            public DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayConfig RayConfig { get; set; }
            public class DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayConfig : TeaModel {
                /// <summary>
                /// <para>The Ray cluster type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BASIC: basic type without high availability.</description></item>
                /// <item><description>HIGH_AVAILABILITY: high-availability type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BASIC</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The disk size of the head node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100G</para>
                /// </summary>
                [NameInMap("HeadDiskCapacity")]
                [Validation(Required=false)]
                public string HeadDiskCapacity { get; set; }

                /// <summary>
                /// <para>The node specifications of the head node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>large</para>
                /// </summary>
                [NameInMap("HeadSpec")]
                [Validation(Required=false)]
                public string HeadSpec { get; set; }

                /// <summary>
                /// <para>The resource type of the head node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPU</para>
                /// </summary>
                [NameInMap("HeadSpecType")]
                [Validation(Required=false)]
                public string HeadSpecType { get; set; }

                /// <summary>
                /// <para>The Ray cluster address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-cluster-address.example.com">http://ray-cluster-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayClusterAddress")]
                [Validation(Required=false)]
                public string RayClusterAddress { get; set; }

                /// <summary>
                /// <para>The Ray Dashboard address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-dashboard-address.example.com">http://ray-dashboard-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayDashboardAddress")]
                [Validation(Required=false)]
                public string RayDashboardAddress { get; set; }

                /// <summary>
                /// <para>The Ray Grafana address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://ray-grafana-address.example.com">http://ray-grafana-address.example.com</a></para>
                /// </summary>
                [NameInMap("RayGrafanaAddress")]
                [Validation(Required=false)]
                public string RayGrafanaAddress { get; set; }

                /// <summary>
                /// <para>The list of Ray worker group configurations.</para>
                /// </summary>
                [NameInMap("WorkerGroups")]
                [Validation(Required=false)]
                public List<DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayConfigWorkerGroups> WorkerGroups { get; set; }
                public class DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayConfigWorkerGroups : TeaModel {
                    /// <summary>
                    /// <para>The allocation unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AllocateUnit")]
                    [Validation(Required=false)]
                    public string AllocateUnit { get; set; }

                    /// <summary>
                    /// <para>The name of the worker group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>worker1</para>
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The maximum number of workers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("MaxWorkerQuantity")]
                    [Validation(Required=false)]
                    public int? MaxWorkerQuantity { get; set; }

                    /// <summary>
                    /// <para>The minimum number of workers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinWorkerQuantity")]
                    [Validation(Required=false)]
                    public int? MinWorkerQuantity { get; set; }

                    /// <summary>
                    /// <para>The disk size of each worker.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100G</para>
                    /// </summary>
                    [NameInMap("WorkerDiskCapacity")]
                    [Validation(Required=false)]
                    public string WorkerDiskCapacity { get; set; }

                    /// <summary>
                    /// <para>The worker resource model.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>large</para>
                    /// </summary>
                    [NameInMap("WorkerSpecName")]
                    [Validation(Required=false)]
                    public string WorkerSpecName { get; set; }

                    /// <summary>
                    /// <para>The Ray worker resource type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CPU</para>
                    /// </summary>
                    [NameInMap("WorkerSpecType")]
                    [Validation(Required=false)]
                    public string WorkerSpecType { get; set; }

                }

            }

            [NameInMap("RayTrainConfig")]
            [Validation(Required=false)]
            public DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayTrainConfig RayTrainConfig { get; set; }
            public class DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayTrainConfig : TeaModel {
                [NameInMap("CpuAcu")]
                [Validation(Required=false)]
                public long? CpuAcu { get; set; }

                [NameInMap("GpuSpecs")]
                [Validation(Required=false)]
                public List<DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayTrainConfigGpuSpecs> GpuSpecs { get; set; }
                public class DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayTrainConfigGpuSpecs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;1&quot;</para>
                    /// </summary>
                    [NameInMap("AllocateUnit")]
                    [Validation(Required=false)]
                    public string AllocateUnit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ADB.MLTensor.2</para>
                    /// </summary>
                    [NameInMap("SpecName")]
                    [Validation(Required=false)]
                    public string SpecName { get; set; }

                }

                [NameInMap("TerminalConfig")]
                [Validation(Required=false)]
                public DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayTrainConfigTerminalConfig TerminalConfig { get; set; }
                public class DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayTrainConfigTerminalConfig : TeaModel {
                    [NameInMap("AcrConfig")]
                    [Validation(Required=false)]
                    public DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayTrainConfigTerminalConfigAcrConfig AcrConfig { get; set; }
                    public class DescribeEmbodiedAIPlatformsResponseBodyPlatformsRayTrainConfigTerminalConfigAcrConfig : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>cri-***</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("Namespaces")]
                        [Validation(Required=false)]
                        public List<string> Namespaces { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>example-vpc.example-region.cr.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("Registry")]
                        [Validation(Required=false)]
                        public string Registry { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The running status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B47EED99-BFA5-529D-8D85-A6642421D390</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of platforms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
