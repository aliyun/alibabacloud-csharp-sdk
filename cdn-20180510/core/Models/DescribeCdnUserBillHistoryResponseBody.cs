// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing history returned.</para>
        /// </summary>
        [NameInMap("BillHistoryData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillHistoryResponseBodyBillHistoryData BillHistoryData { get; set; }
        public class DescribeCdnUserBillHistoryResponseBodyBillHistoryData : TeaModel {
            [NameInMap("BillHistoryDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem> BillHistoryDataItem { get; set; }
            public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItem : TeaModel {
                /// <summary>
                /// <para>The beginning of the time range that was queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-30T16:00:00Z</para>
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
                public DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData BillingData { get; set; }
                public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingData : TeaModel {
                    [NameInMap("BillingDataItem")]
                    [Validation(Required=false)]
                    public List<DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem> BillingDataItem { get; set; }
                    public class DescribeCdnUserBillHistoryResponseBodyBillHistoryDataBillHistoryDataItemBillingDataBillingDataItem : TeaModel {
                        /// <summary>
                        /// <para>The bandwidth. Unit: bit/s.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4041</para>
                        /// </summary>
                        [NameInMap("Bandwidth")]
                        [Validation(Required=false)]
                        public float? Bandwidth { get; set; }

                        /// <summary>
                        /// <para>The billable region. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>CN</b>: Chinese mainland</description></item>
                        /// <item><description><b>OverSeas</b>: outside the Chinese mainland</description></item>
                        /// <item><description><b>AP1</b>: Asia Pacific 1</description></item>
                        /// <item><description><b>AP2</b>: Asia Pacific 2</description></item>
                        /// <item><description><b>AP3</b>: Asia Pacific 3</description></item>
                        /// <item><description><b>NA</b>: North America</description></item>
                        /// <item><description><b>SA</b>: South America</description></item>
                        /// <item><description><b>EU</b>: Europe</description></item>
                        /// <item><description><b>MEAA</b>: Middle East and Africa</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AP1</para>
                        /// </summary>
                        [NameInMap("CdnRegion")]
                        [Validation(Required=false)]
                        public string CdnRegion { get; set; }

                        /// <summary>
                        /// <para>The billing method. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>StaticHttp</b>: static HTTP requests</description></item>
                        /// <item><description><b>DynamicHttp</b>: dynamic HTTP requests</description></item>
                        /// <item><description><b>DynamicHttps</b>: dynamic HTTPS requests</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DynamicHttp</para>
                        /// </summary>
                        [NameInMap("ChargeType")]
                        [Validation(Required=false)]
                        public string ChargeType { get; set; }

                        /// <summary>
                        /// <para>The number of requests.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>203601</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public float? Count { get; set; }

                        /// <summary>
                        /// <para>The amount of network traffic. Unit: bytes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>24567</para>
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
                /// <para>flow</para>
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
