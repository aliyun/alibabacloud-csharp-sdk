// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class GetEmbodiedAIPlatformResourceUsageInfoResponseBody : TeaModel {
        [NameInMap("GpuDetails")]
        [Validation(Required=false)]
        public List<GetEmbodiedAIPlatformResourceUsageInfoResponseBodyGpuDetails> GpuDetails { get; set; }
        public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyGpuDetails : TeaModel {
            [NameInMap("AllocatedUnit")]
            [Validation(Required=false)]
            public int? AllocatedUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ADB.MLLarge.2</para>
            /// </summary>
            [NameInMap("GpuModel")]
            [Validation(Required=false)]
            public string GpuModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxRegisteredDevices")]
        [Validation(Required=false)]
        public long? MaxRegisteredDevices { get; set; }

        /// <summary>
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

        [NameInMap("SlbTraffic")]
        [Validation(Required=false)]
        public GetEmbodiedAIPlatformResourceUsageInfoResponseBodySlbTraffic SlbTraffic { get; set; }
        public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodySlbTraffic : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalBytesIn")]
            [Validation(Required=false)]
            public long? TotalBytesIn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TotalBytesOut")]
            [Validation(Required=false)]
            public long? TotalBytesOut { get; set; }

        }

        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsage StorageUsage { get; set; }
        public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsage : TeaModel {
            [NameInMap("Nas")]
            [Validation(Required=false)]
            public GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsageNas Nas { get; set; }
            public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsageNas : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MeteredSize")]
                [Validation(Required=false)]
                public long? MeteredSize { get; set; }

            }

            [NameInMap("Oss")]
            [Validation(Required=false)]
            public GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsageOss Oss { get; set; }
            public class GetEmbodiedAIPlatformResourceUsageInfoResponseBodyStorageUsageOss : TeaModel {
                /// <summary>
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
