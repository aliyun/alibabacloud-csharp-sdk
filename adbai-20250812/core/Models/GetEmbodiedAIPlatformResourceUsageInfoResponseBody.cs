// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class GetEmbodiedAIPlatformResourceUsageInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of ACUs for each component of the Embodied platform.</para>
        /// </summary>
        [NameInMap("AcuDetails")]
        [Validation(Required=false)]
        public GetEmbodiedAIPlatformResourceUsageInfoResponseBodyAcuDetails AcuDetails { get; set; }
        public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyAcuDetails : TeaModel {
            /// <summary>
            /// <para>The number of ACUs for the EAP web server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EapWebserverACUCount")]
            [Validation(Required=false)]
            public double? EapWebserverACUCount { get; set; }

            /// <summary>
            /// <para>The number of ACUs for the Ray head node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RayHeadACUCount")]
            [Validation(Required=false)]
            public double? RayHeadACUCount { get; set; }

            /// <summary>
            /// <para>The number of ACUs for the Ray worker node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RayWorkerACUCount")]
            [Validation(Required=false)]
            public double? RayWorkerACUCount { get; set; }

            /// <summary>
            /// <para>The total number of ACUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalACUCount")]
            [Validation(Required=false)]
            public double? TotalACUCount { get; set; }

        }

        /// <summary>
        /// <para>The GPU usage.</para>
        /// </summary>
        [NameInMap("GpuDetails")]
        [Validation(Required=false)]
        public List<GetEmbodiedAIPlatformResourceUsageInfoResponseBodyGpuDetails> GpuDetails { get; set; }
        public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyGpuDetails : TeaModel {
            /// <summary>
            /// <para>The GPU allocation unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AllocatedUnit")]
            [Validation(Required=false)]
            public int? AllocatedUnit { get; set; }

            /// <summary>
            /// <para>The GPU model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADB.MLLarge.2</para>
            /// </summary>
            [NameInMap("GpuModel")]
            [Validation(Required=false)]
            public string GpuModel { get; set; }

            /// <summary>
            /// <para>The current number of GPUs in use for this model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of registered devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxRegisteredDevices")]
        [Validation(Required=false)]
        public long? MaxRegisteredDevices { get; set; }

        /// <summary>
        /// <para>The number of registered devices.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RegisteredDeviceCount")]
        [Validation(Required=false)]
        public long? RegisteredDeviceCount { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B47EED99-BFA5-529D-8D85-A6642421D390</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The network resource usage information.</para>
        /// </summary>
        [NameInMap("SlbTraffic")]
        [Validation(Required=false)]
        public GetEmbodiedAIPlatformResourceUsageInfoResponseBodySlbTraffic SlbTraffic { get; set; }
        public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodySlbTraffic : TeaModel {
            /// <summary>
            /// <para>The inbound Internet traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalBytesIn")]
            [Validation(Required=false)]
            public long? TotalBytesIn { get; set; }

            /// <summary>
            /// <para>The outbound Internet traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalBytesOut")]
            [Validation(Required=false)]
            public long? TotalBytesOut { get; set; }

        }

        /// <summary>
        /// <para>The storage resource usage information.</para>
        /// </summary>
        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsage StorageUsage { get; set; }
        public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsage : TeaModel {
            /// <summary>
            /// <para>The NAS storage usage.</para>
            /// </summary>
            [NameInMap("Nas")]
            [Validation(Required=false)]
            public GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsageNas Nas { get; set; }
            public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsageNas : TeaModel {
                /// <summary>
                /// <para>The NAS standard storage usage, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

            }

            /// <summary>
            /// <para>The OSS storage usage.</para>
            /// </summary>
            [NameInMap("Oss")]
            [Validation(Required=false)]
            public GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsageOss Oss { get; set; }
            public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsageOss : TeaModel {
                /// <summary>
                /// <para>The OSS standard storage usage, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StandardStorageSize")]
                [Validation(Required=false)]
                public long? StandardStorageSize { get; set; }

            }

        }

    }

}
