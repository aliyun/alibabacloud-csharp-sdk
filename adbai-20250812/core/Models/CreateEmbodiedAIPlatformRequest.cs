// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class CreateEmbodiedAIPlatformRequest : TeaModel {
        /// <summary>
        /// <para>The instance cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ontology count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DeviceCount")]
        [Validation(Required=false)]
        public int? DeviceCount { get; set; }

        /// <summary>
        /// <para>The name of the embodied intelligence multimodal data platform.</para>
        /// <remarks>
        /// <para>The name can contain lowercase letters, digits, and underscores. It must start with a letter and end with a letter or digit. The name can be up to 16 characters in length.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
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
        public CreateEmbodiedAIPlatformRequestRayConfig RayConfig { get; set; }
        public class CreateEmbodiedAIPlatformRequestRayConfig : TeaModel {
            /// <summary>
            /// <para>The Ray cluster type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>BASIC: basic type, non-high-availability.</para>
            /// </description></item>
            /// <item><description><para>HIGH_AVAILABILITY: high-availability type.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The node specifications of the head node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xlarge</para>
            /// </summary>
            [NameInMap("HeadSpec")]
            [Validation(Required=false)]
            public string HeadSpec { get; set; }

            /// <summary>
            /// <para>The list of Ray worker group configurations.</para>
            /// </summary>
            [NameInMap("WorkerGroups")]
            [Validation(Required=false)]
            public List<CreateEmbodiedAIPlatformRequestRayConfigWorkerGroups> WorkerGroups { get; set; }
            public class CreateEmbodiedAIPlatformRequestRayConfigWorkerGroups : TeaModel {
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
                /// <para>test</para>
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
                /// <para>The disk size of the worker node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100G</para>
                /// </summary>
                [NameInMap("WorkerDiskCapacity")]
                [Validation(Required=false)]
                public string WorkerDiskCapacity { get; set; }

                /// <summary>
                /// <para>The node specifications of the worker node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xlarge</para>
                /// </summary>
                [NameInMap("WorkerSpecName")]
                [Validation(Required=false)]
                public string WorkerSpecName { get; set; }

                /// <summary>
                /// <para>The resource type of the worker node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPU</para>
                /// </summary>
                [NameInMap("WorkerSpecType")]
                [Validation(Required=false)]
                public string WorkerSpecType { get; set; }

            }

        }

        /// <summary>
        /// <para>The development and training resource configuration.</para>
        /// </summary>
        [NameInMap("RayTrainConfig")]
        [Validation(Required=false)]
        public CreateEmbodiedAIPlatformRequestRayTrainConfig RayTrainConfig { get; set; }
        public class CreateEmbodiedAIPlatformRequestRayTrainConfig : TeaModel {
            /// <summary>
            /// <para>The number of CPU ACUs to purchase.</para>
            /// </summary>
            [NameInMap("CpuAcu")]
            [Validation(Required=false)]
            public long? CpuAcu { get; set; }

            /// <summary>
            /// <para>The list of GPU model specifications to purchase.</para>
            /// </summary>
            [NameInMap("GpuSpecs")]
            [Validation(Required=false)]
            public List<CreateEmbodiedAIPlatformRequestRayTrainConfigGpuSpecs> GpuSpecs { get; set; }
            public class CreateEmbodiedAIPlatformRequestRayTrainConfigGpuSpecs : TeaModel {
                /// <summary>
                /// <para>The allocation unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;1&quot;</para>
                /// </summary>
                [NameInMap("AllocateUnit")]
                [Validation(Required=false)]
                public string AllocateUnit { get; set; }

                /// <summary>
                /// <para>The number of GPU cards.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The GPU model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADB.MLGrand.4</para>
                /// </summary>
                [NameInMap("SpecName")]
                [Validation(Required=false)]
                public string SpecName { get; set; }

            }

            /// <summary>
            /// <para>The development machine configuration.</para>
            /// </summary>
            [NameInMap("TerminalConfig")]
            [Validation(Required=false)]
            public CreateEmbodiedAIPlatformRequestRayTrainConfigTerminalConfig TerminalConfig { get; set; }
            public class CreateEmbodiedAIPlatformRequestRayTrainConfigTerminalConfig : TeaModel {
                /// <summary>
                /// <para>The image repository configuration.</para>
                /// </summary>
                [NameInMap("AcrConfig")]
                [Validation(Required=false)]
                public CreateEmbodiedAIPlatformRequestRayTrainConfigTerminalConfigAcrConfig AcrConfig { get; set; }
                public class CreateEmbodiedAIPlatformRequestRayTrainConfigTerminalConfigAcrConfig : TeaModel {
                    /// <summary>
                    /// <para>The instance ID of the image repository.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-***</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The list of namespaces.</para>
                    /// </summary>
                    [NameInMap("Namespaces")]
                    [Validation(Required=false)]
                    public List<string> Namespaces { get; set; }

                    /// <summary>
                    /// <para>The address of the image repository instance.</para>
                    /// 
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
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the DescribeRegions operation to query the region ID of a specified Data Lakehouse Edition cluster.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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

}
