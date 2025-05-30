// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class GetUrgentDemandItemListResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUrgentDemandItemListResponseBodyData Data { get; set; }
        public class GetUrgentDemandItemListResponseBodyData : TeaModel {
            [NameInMap("current")]
            [Validation(Required=false)]
            public long? Current { get; set; }

            [NameInMap("pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetUrgentDemandItemListResponseBodyDataRecords> Records { get; set; }
            public class GetUrgentDemandItemListResponseBodyDataRecords : TeaModel {
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }

                [NameInMap("accountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("commodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("commodityNum")]
                [Validation(Required=false)]
                public long? CommodityNum { get; set; }

                [NameInMap("commodityTypeCode")]
                [Validation(Required=false)]
                public string CommodityTypeCode { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("creatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                [NameInMap("effectTime")]
                [Validation(Required=false)]
                public string EffectTime { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("modifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                [NameInMap("networkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("payDuration")]
                [Validation(Required=false)]
                public long? PayDuration { get; set; }

                [NameInMap("payDurationUnit")]
                [Validation(Required=false)]
                public string PayDurationUnit { get; set; }

                [NameInMap("payType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("planId")]
                [Validation(Required=false)]
                public long? PlanId { get; set; }

                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("urgentDemandEbsRequest")]
                [Validation(Required=false)]
                public GetUrgentDemandItemListResponseBodyDataRecordsUrgentDemandEbsRequest UrgentDemandEbsRequest { get; set; }
                public class GetUrgentDemandItemListResponseBodyDataRecordsUrgentDemandEbsRequest : TeaModel {
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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("dataDiskSize")]
                    [Validation(Required=false)]
                    public long? DataDiskSize { get; set; }

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
                public GetUrgentDemandItemListResponseBodyDataRecordsUrgentDemandEcsRequest UrgentDemandEcsRequest { get; set; }
                public class GetUrgentDemandItemListResponseBodyDataRecordsUrgentDemandEcsRequest : TeaModel {
                    [NameInMap("commodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    [NameInMap("commodityNum")]
                    [Validation(Required=false)]
                    public long? CommodityNum { get; set; }

                    [NameInMap("commodityTypeCode")]
                    [Validation(Required=false)]
                    public string CommodityTypeCode { get; set; }

                    [NameInMap("itemId")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    [NameInMap("vcpuCount")]
                    [Validation(Required=false)]
                    public long? VcpuCount { get; set; }

                }

            }

            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
