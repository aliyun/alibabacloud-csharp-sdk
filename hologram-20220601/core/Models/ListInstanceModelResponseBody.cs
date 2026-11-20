// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListInstanceModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of AI resources.</para>
        /// </summary>
        [NameInMap("instanceModelList")]
        [Validation(Required=false)]
        public List<ListInstanceModelResponseBodyInstanceModelList> InstanceModelList { get; set; }
        public class ListInstanceModelResponseBodyInstanceModelList : TeaModel {
            /// <summary>
            /// <para>The ID of the AI node instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hologram_aicombo_public_cn-77xxx</para>
            /// </summary>
            [NameInMap("aiInstanceId")]
            [Validation(Required=false)]
            public string AiInstanceId { get; set; }

            /// <summary>
            /// <para>The <b>AI specifications</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>small-8core-30G-24G</para>
            /// </summary>
            [NameInMap("aiSpec")]
            [Validation(Required=false)]
            public string AiSpec { get; set; }

            /// <summary>
            /// <para>Specifies whether <b>auto-renewal</b> is enabled.</para>
            /// </summary>
            [NameInMap("autoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrePaid: subscription.</description></item>
            /// <item><description>PostPaid: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hologram_aipostpay_public_cn</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The CPU specifications. This parameter applies only to Hologres AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// <para>The total CPU usage of the node. This parameter applies only to Hologres AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("cpuUsed")]
            [Validation(Required=false)]
            public long? CpuUsed { get; set; }

            /// <summary>
            /// <para>The expiration time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-28T07:44:27.535Z</para>
            /// </summary>
            [NameInMap("expirationTime")]
            [Validation(Required=false)]
            public string ExpirationTime { get; set; }

            /// <summary>
            /// <para>The number of GPUs. This parameter applies only to Hologres AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("gpu")]
            [Validation(Required=false)]
            public long? Gpu { get; set; }

            /// <summary>
            /// <para>The GPU memory size. Unit: GB. This parameter applies only to Hologres AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("gpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            /// <summary>
            /// <para>The total GPU memory usage of the node. This parameter applies only to Hologres AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("gpuMemoryUsed")]
            [Validation(Required=false)]
            public long? GpuMemoryUsed { get; set; }

            /// <summary>
            /// <para>The total GPU usage of the node. This parameter applies only to Hologres AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("gpuUsed")]
            [Validation(Required=false)]
            public long? GpuUsed { get; set; }

            /// <summary>
            /// <para>The <b>Hologres instance ID</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hgpostcn-cn-yi34hlzdx003</para>
            /// </summary>
            [NameInMap("holoInstanceId")]
            [Validation(Required=false)]
            public string HoloInstanceId { get; set; }

            /// <summary>
            /// <para>The <b>Hologres instance name</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myInstance</para>
            /// </summary>
            [NameInMap("holoInstanceName")]
            [Validation(Required=false)]
            public string HoloInstanceName { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GiB. This parameter applies only to Hologres AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <para>The total memory usage of the node. This parameter applies only to Hologres AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("memoryUsed")]
            [Validation(Required=false)]
            public long? MemoryUsed { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>small</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The <b>status</b>.</para>
            /// 
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
