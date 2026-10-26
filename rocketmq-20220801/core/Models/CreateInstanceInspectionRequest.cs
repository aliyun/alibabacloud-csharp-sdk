// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class CreateInstanceInspectionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inspection-request-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;templateCode&quot;:&quot;rmq.consumer-health&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;1h&quot;}},{&quot;templateCode&quot;:&quot;rmq.traffic-capacity&quot;,&quot;parameters&quot;:{&quot;lookback&quot;:&quot;6h&quot;}}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<CreateInstanceInspectionRequestItems> Items { get; set; }
        public class CreateInstanceInspectionRequestItems : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;mode&quot;:&quot;All&quot;}</para>
        /// </summary>
        [NameInMap("resourceScope")]
        [Validation(Required=false)]
        public CreateInstanceInspectionRequestResourceScope ResourceScope { get; set; }
        public class CreateInstanceInspectionRequestResourceScope : TeaModel {
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
        /// <para>{&quot;enabled&quot;:true,&quot;cron&quot;:&quot;0 3 * * *&quot;}</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public CreateInstanceInspectionRequestSchedule Schedule { get; set; }
        public class CreateInstanceInspectionRequestSchedule : TeaModel {
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
