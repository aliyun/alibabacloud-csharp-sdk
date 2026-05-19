// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class ModifyEmbodiedAIPlatformRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DeviceCount")]
        [Validation(Required=false)]
        public string DeviceCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eap_platform</para>
        /// </summary>
        [NameInMap("PlatformName")]
        [Validation(Required=false)]
        public string PlatformName { get; set; }

        [NameInMap("RayConfig")]
        [Validation(Required=false)]
        public ModifyEmbodiedAIPlatformRequestRayConfig RayConfig { get; set; }
        public class ModifyEmbodiedAIPlatformRequestRayConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xlarge</para>
            /// </summary>
            [NameInMap("HeadSpec")]
            [Validation(Required=false)]
            public string HeadSpec { get; set; }

            [NameInMap("WorkerGroups")]
            [Validation(Required=false)]
            public List<ModifyEmbodiedAIPlatformRequestRayConfigWorkerGroups> WorkerGroups { get; set; }
            public class ModifyEmbodiedAIPlatformRequestRayConfigWorkerGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AllocateUnit")]
                [Validation(Required=false)]
                public string AllocateUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("MaxWorkerQuantity")]
                [Validation(Required=false)]
                public int? MaxWorkerQuantity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinWorkerQuantity")]
                [Validation(Required=false)]
                public int? MinWorkerQuantity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100G</para>
                /// </summary>
                [NameInMap("WorkerDiskCapacity")]
                [Validation(Required=false)]
                public string WorkerDiskCapacity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xlarge</para>
                /// </summary>
                [NameInMap("WorkerSpecName")]
                [Validation(Required=false)]
                public string WorkerSpecName { get; set; }

                /// <summary>
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
        public ModifyEmbodiedAIPlatformRequestRayTrainConfig RayTrainConfig { get; set; }
        public class ModifyEmbodiedAIPlatformRequestRayTrainConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CpuAcu")]
            [Validation(Required=false)]
            public long? CpuAcu { get; set; }

            [NameInMap("GpuSpecs")]
            [Validation(Required=false)]
            public List<ModifyEmbodiedAIPlatformRequestRayTrainConfigGpuSpecs> GpuSpecs { get; set; }
            public class ModifyEmbodiedAIPlatformRequestRayTrainConfigGpuSpecs : TeaModel {
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
            public ModifyEmbodiedAIPlatformRequestRayTrainConfigTerminalConfig TerminalConfig { get; set; }
            public class ModifyEmbodiedAIPlatformRequestRayTrainConfigTerminalConfig : TeaModel {
                [NameInMap("AcrConfig")]
                [Validation(Required=false)]
                public ModifyEmbodiedAIPlatformRequestRayTrainConfigTerminalConfigAcrConfig AcrConfig { get; set; }
                public class ModifyEmbodiedAIPlatformRequestRayTrainConfigTerminalConfigAcrConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i-8vb32jdd306b50rodza7</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>large</para>
        /// </summary>
        [NameInMap("WebserverSpecName")]
        [Validation(Required=false)]
        public string WebserverSpecName { get; set; }

    }

}
