// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class GetInstanceModelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hologram_aicombo_public_cn-77xxx</para>
        /// </summary>
        [NameInMap("aiInstanceId")]
        [Validation(Required=false)]
        public string AiInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PrePaid</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("gpu")]
        [Validation(Required=false)]
        public long? Gpu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("gpuMemory")]
        [Validation(Required=false)]
        public long? GpuMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("gpuMemoryUsed")]
        [Validation(Required=false)]
        public long? GpuMemoryUsed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("gpuUsed")]
        [Validation(Required=false)]
        public long? GpuUsed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("memoryUsed")]
        [Validation(Required=false)]
        public long? MemoryUsed { get; set; }

        [NameInMap("modelServiceList")]
        [Validation(Required=false)]
        public List<GetInstanceModelResponseBodyModelServiceList> ModelServiceList { get; set; }
        public class GetInstanceModelResponseBodyModelServiceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sk-42f6c8xxxxxb</para>
            /// </summary>
            [NameInMap("apiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("gpu")]
            [Validation(Required=false)]
            public long? Gpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("gpuMemory")]
            [Validation(Required=false)]
            public long? GpuMemory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("instanceRegion")]
            [Validation(Required=false)]
            public string InstanceRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Failed</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my_model</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;timeout&quot;:600,&quot;max_retries&quot;:10,&quot;max_retry_delay&quot;:8,&quot;initial_retry_delay&quot;:0.5}</para>
            /// </summary>
            [NameInMap("modelParams")]
            [Validation(Required=false)]
            public string ModelParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen3.5-plus</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("serviceCount")]
            [Validation(Required=false)]
            public long? ServiceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("serviceDeployRegion")]
            [Validation(Required=false)]
            public string ServiceDeployRegion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>embedding</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1.1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nodeCount")]
        [Validation(Required=false)]
        public long? NodeCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>819A7F0F-2951-540F-BD94-6A41ECF0281F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>middle</para>
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

}
