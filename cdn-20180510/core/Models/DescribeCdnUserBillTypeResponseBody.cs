// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserBillTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the metering methods returned.</para>
        /// </summary>
        [NameInMap("BillTypeData")]
        [Validation(Required=false)]
        public DescribeCdnUserBillTypeResponseBodyBillTypeData BillTypeData { get; set; }
        public class DescribeCdnUserBillTypeResponseBodyBillTypeData : TeaModel {
            [NameInMap("BillTypeDataItem")]
            [Validation(Required=false)]
            public List<DescribeCdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem> BillTypeDataItem { get; set; }
            public class DescribeCdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem : TeaModel {
                /// <summary>
                /// <para>The metering method.</para>
                /// <remarks>
                /// <para>If the metering method is suffixed with \<em>\</em>_overseas\<em>\</em>, the billable region is outside the Chinese mainland. For example, &quot;BillType&quot;: &quot;month_avg_day_bandwidth_overseas&quot; indicates that the metering method is pay by average daily peak bandwidth per month in a billable region outside the Chinese mainland.</para>
                /// </remarks>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hour_flow: pay by hourly data transfer</description></item>
                /// <item><description>day_bandwidth: pay by daily bandwidth</description></item>
                /// <item><description>month_95: pay by monthly 95th percentile bandwidth</description></item>
                /// <item><description>month_avg_day_bandwidth: pay by average daily peak bandwidth per month</description></item>
                /// <item><description>month_4th_day_bandwidth: pay by monthly 4th peak bandwidth</description></item>
                /// <item><description>month_avg_day_95: pay by average daily 95th percentile bandwidth per month</description></item>
                /// <item><description>month_95_night_half: pay by 95th percentile bandwidth with 50% off from 00:00 to 08:00</description></item>
                /// <item><description>hour_vas: pay by value-added services per hour</description></item>
                /// <item><description>quic_hour_count: pay by hourly QUIC requests</description></item>
                /// <item><description>day_count: pay by daily requests</description></item>
                /// <item><description>hour_count: pay by hourly requests</description></item>
                /// <item><description>day_95: pay by daily 95th percentile bandwidth</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>month_avg_day_bandwidth_overseas</para>
                /// </summary>
                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                /// <summary>
                /// <para>The billing cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>month</para>
                /// </summary>
                [NameInMap("BillingCycle")]
                [Validation(Required=false)]
                public string BillingCycle { get; set; }

                /// <summary>
                /// <para>The dimension. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>flow: traffic and bandwidth</description></item>
                /// <item><description>vas: value-added services (HTTPS and requests for dynamic content)</description></item>
                /// <item><description>quic: the number of QUIC requests</description></item>
                /// <item><description>websocket: the WebSocket communications protocol</description></item>
                /// <item><description>rtlog2sls: log entries delivered to Log Service in real time</description></item>
                /// <item><description>stationflow: traffic over the internal network</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>flow</para>
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// <para>The time when the metering method ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-10-31T16:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The name of the product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cdn</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The time when the metering method started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-10-30T16:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
