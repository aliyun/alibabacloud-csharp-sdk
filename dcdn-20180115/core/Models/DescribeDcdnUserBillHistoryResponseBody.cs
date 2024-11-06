// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserBillHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing history returned.</para>
        /// </summary>
        [NameInMap("BillHistoryData")]
        [Validation(Required=false)]
        public DescribeDcdnUserBillHistoryResponseBodyBillHistoryData BillHistoryData { get; set; }
        public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryData : TeaModel {
            [NameInMap("BillHistoryDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem> BillHistoryDataItem { get; set; }
            public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem : TeaModel {
                /// <summary>
                /// <para>The beginning of the time range that was queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-30T17:00:00Z</para>
                /// </summary>
                [NameInMap("BillTime")]
                [Validation(Required=false)]
                public string BillTime { get; set; }

                /// <summary>
                /// <para>The metering method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>month_4th_day_bandwidth</para>
                /// </summary>
                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                /// <summary>
                /// <para>The billable items.</para>
                /// </summary>
                [NameInMap("BillingData")]
                [Validation(Required=false)]
                public DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData BillingData { get; set; }
                public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData : TeaModel {
                    [NameInMap("BillingDataItem")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem> BillingDataItem { get; set; }
                    public class DescribeDcdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem : TeaModel {
                        /// <summary>
                        /// <para>The bandwidth. Unit: bit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4839</para>
                        /// </summary>
                        [NameInMap("Bandwidth")]
                        [Validation(Required=false)]
                        public float? Bandwidth { get; set; }

                        /// <summary>
                        /// <para>The region for which the billing records are generated. Valid values: <b>CN</b>, <b>OverSeas</b>, <b>AP1</b>, <b>AP2</b>, <b>AP3</b>, <b>NA</b>, <b>SA</b>, <b>EU</b>, and <b>MEAA</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AP1</para>
                        /// </summary>
                        [NameInMap("CdnRegion")]
                        [Validation(Required=false)]
                        public string CdnRegion { get; set; }

                        /// <summary>
                        /// <para>The billing method of the disk. Valid values: <b>StaticHttp</b>, <b>DynamicHttp</b>, and <b>DynamicHttps</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DynamicHttp</para>
                        /// </summary>
                        [NameInMap("ChargeType")]
                        [Validation(Required=false)]
                        public string ChargeType { get; set; }

                        /// <summary>
                        /// <para>The number of billing entries.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>205624</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public float? Count { get; set; }

                        /// <summary>
                        /// <para>The amount of network traffic. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2456</para>
                        /// </summary>
                        [NameInMap("Flow")]
                        [Validation(Required=false)]
                        public float? Flow { get; set; }

                    }

                }

                /// <summary>
                /// <para>The dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vas</para>
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED61C6C3-8241-4187-AAA7-5157AE175CEC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
