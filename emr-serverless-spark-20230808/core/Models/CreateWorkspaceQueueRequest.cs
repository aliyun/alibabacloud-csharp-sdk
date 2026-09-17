// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateWorkspaceQueueRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ray Cluster for dev.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of GPU models.</para>
        /// </summary>
        [NameInMap("gpuSpec")]
        [Validation(Required=false)]
        public List<string> GpuSpec { get; set; }

        /// <summary>
        /// <para>The Ray cluster instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray-k7nm8ahl5te4tg91-ey7blpbg</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo: pay-as-you-go</description></item>
        /// <item><description>Pre: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>Indicates whether resource prefetch is enabled.</para>
        /// </summary>
        [NameInMap("preheat")]
        [Validation(Required=false)]
        public bool? Preheat { get; set; }

        /// <summary>
        /// <para>The queue type. Valid values: CPU and GPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("queueCategory")]
        [Validation(Required=false)]
        public string QueueCategory { get; set; }

        /// <summary>
        /// <para>The resource specifications.</para>
        /// </summary>
        [NameInMap("resourceSpec")]
        [Validation(Required=false)]
        public CreateWorkspaceQueueRequestResourceSpec ResourceSpec { get; set; }
        public class CreateWorkspaceQueueRequestResourceSpec : TeaModel {
            /// <summary>
            /// <para>The maximum workspace resource capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("cu")]
            [Validation(Required=false)]
            public long? Cu { get; set; }

            /// <summary>
            /// <para>The number of GPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <para>The number of GPU machines. This parameter is valid only for subscription instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("gpuMachineNum")]
            [Validation(Required=false)]
            public int? GpuMachineNum { get; set; }

            /// <summary>
            /// <para>The maximum number of CUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("maxCu")]
            [Validation(Required=false)]
            public long? MaxCu { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-975bcfda9625****</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The workspace queue name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev_queue</para>
        /// </summary>
        [NameInMap("workspaceQueueName")]
        [Validation(Required=false)]
        public string WorkspaceQueueName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
