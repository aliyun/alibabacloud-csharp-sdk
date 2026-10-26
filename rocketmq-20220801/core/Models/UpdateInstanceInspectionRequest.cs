// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceInspectionRequest : TeaModel {
        /// <summary>
        /// <para>同一实例配置生命周期内有效 24 小时；同 token 同请求返回首次成功结果，不同请求返回冲突。新请求仍须携带当前 revision。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>update-inspection-1</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;templateCode&quot;:&quot;rmq.consumer-health&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;1h&quot;}},{&quot;templateCode&quot;:&quot;rmq.traffic-capacity&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;6h&quot;}}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<UpdateInstanceInspectionRequestItems> Items { get; set; }
        public class UpdateInstanceInspectionRequestItems : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;lookback&quot;:&quot;1h&quot;,&quot;consumerDelayThresholdSeconds&quot;:600}</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public object Parameters { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rmq.consumer-health</para>
            /// </summary>
            [NameInMap("templateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;mode&quot;:&quot;All&quot;}</para>
        /// </summary>
        [NameInMap("resourceScope")]
        [Validation(Required=false)]
        public UpdateInstanceInspectionRequestResourceScope ResourceScope { get; set; }
        public class UpdateInstanceInspectionRequestResourceScope : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;orders-g1&quot;]</para>
            /// </summary>
            [NameInMap("consumerGroups")]
            [Validation(Required=false)]
            public List<string> ConsumerGroups { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;orders&quot;]</para>
            /// </summary>
            [NameInMap("topics")]
            [Validation(Required=false)]
            public List<string> Topics { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public long? Revision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;enabled&quot;:true,&quot;cron&quot;:&quot;0 3 * * *&quot;}</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public UpdateInstanceInspectionRequestSchedule Schedule { get; set; }
        public class UpdateInstanceInspectionRequestSchedule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0 3 * * *</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
