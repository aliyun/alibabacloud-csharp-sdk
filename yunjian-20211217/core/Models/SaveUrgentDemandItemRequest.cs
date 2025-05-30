// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class SaveUrgentDemandItemRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12321312</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111222</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-12-27 00:00:00</para>
        /// </summary>
        [NameInMap("effectTime")]
        [Validation(Required=false)]
        public string EffectTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111222</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>网络类型 vpc（私有网络）/classic（经典网络）</para>
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("payDuration")]
        [Validation(Required=false)]
        public string PayDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>购买时长单位(month(月)，week(周)，day(天))</para>
        /// </summary>
        [NameInMap("payDurationUnit")]
        [Validation(Required=false)]
        public string PayDurationUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>付费类型 prepay(预付费)/postpay（后付费）</para>
        /// </summary>
        [NameInMap("payType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111222</para>
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public long? PlanId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("urgentDemandEbsRequest")]
        [Validation(Required=false)]
        public SaveUrgentDemandItemRequestUrgentDemandEbsRequest UrgentDemandEbsRequest { get; set; }
        public class SaveUrgentDemandItemRequestUrgentDemandEbsRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("commodityNum")]
            [Validation(Required=false)]
            public long? CommodityNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yundisk</para>
            /// </summary>
            [NameInMap("commodityTypeCode")]
            [Validation(Required=false)]
            public string CommodityTypeCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111222</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("performanceLevel")]
            [Validation(Required=false)]
            public long? PerformanceLevel { get; set; }

        }

        [NameInMap("urgentDemandEcsRequest")]
        [Validation(Required=false)]
        public SaveUrgentDemandItemRequestUrgentDemandEcsRequest UrgentDemandEcsRequest { get; set; }
        public class SaveUrgentDemandItemRequestUrgentDemandEcsRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.sn2ne.6xlarge</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("commodityNum")]
            [Validation(Required=false)]
            public long? CommodityNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("commodityTypeCode")]
            [Validation(Required=false)]
            public string CommodityTypeCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111222</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("vCpuCount")]
            [Validation(Required=false)]
            public long? VCpuCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing-a</para>
        /// </summary>
        [NameInMap("zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
