// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListInstanceModelResponseBody : TeaModel {
        [NameInMap("instanceModelList")]
        [Validation(Required=false)]
        public List<ListInstanceModelResponseBodyInstanceModelList> InstanceModelList { get; set; }
        public class ListInstanceModelResponseBodyInstanceModelList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>hologram_aicombo_public_cn-77xxx</para>
            /// </summary>
            [NameInMap("aiInstanceId")]
            [Validation(Required=false)]
            public string AiInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>small-8core-30G-24G</para>
            /// </summary>
            [NameInMap("aiSpec")]
            [Validation(Required=false)]
            public string AiSpec { get; set; }

            [NameInMap("autoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hologram_aipostpay_public_cn</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            [NameInMap("cpuUsed")]
            [Validation(Required=false)]
            public long? CpuUsed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-01-28T07:44:27.535Z</para>
            /// </summary>
            [NameInMap("expirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            [NameInMap("gpu")]
            [Validation(Required=false)]
            public long? Gpu { get; set; }

            [NameInMap("gpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            [NameInMap("gpuMemoryUsed")]
            [Validation(Required=false)]
            public long? GpuMemoryUsed { get; set; }

            [NameInMap("gpuUsed")]
            [Validation(Required=false)]
            public long? GpuUsed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hgpostcn-cn-yi34hlzdx003</para>
            /// </summary>
            [NameInMap("holoInstanceId")]
            [Validation(Required=false)]
            public string HoloInstanceId { get; set; }

            [NameInMap("holoInstanceName")]
            [Validation(Required=false)]
            public string HoloInstanceName { get; set; }

            [NameInMap("memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            [NameInMap("memoryUsed")]
            [Validation(Required=false)]
            public long? MemoryUsed { get; set; }

            [NameInMap("nodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>small</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ResourceReady</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C2ECDC1-FBAD-14A5-AA4A-96BC787FBDBC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
