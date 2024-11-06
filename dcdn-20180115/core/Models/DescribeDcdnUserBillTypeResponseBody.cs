// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserBillTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the metering method.</para>
        /// </summary>
        [NameInMap("BillTypeData")]
        [Validation(Required=false)]
        public DescribeDcdnUserBillTypeResponseBodyBillTypeData BillTypeData { get; set; }
        public class DescribeDcdnUserBillTypeResponseBodyBillTypeData : TeaModel {
            [NameInMap("BillTypeDataItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem> BillTypeDataItem { get; set; }
            public class DescribeDcdnUserBillTypeResponseBodyBillTypeDataBillTypeDataItem : TeaModel {
                /// <summary>
                /// <para>The metering method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>hour_flow</b>: pay by hourly traffic</description></item>
                /// <item><description><b>day_bandwidth</b>: pay by daily bandwidth</description></item>
                /// <item><description><b>month_95</b>: pay by monthly 95th percentile</description></item>
                /// <item><description><b>month_avg_day_bandwidth</b>: pay by average daily peak bandwidth per month</description></item>
                /// <item><description><b>month_4th_day_bandwidth</b>: pay by 4th peak bandwidth per month</description></item>
                /// <item><description><b>month_avg_day_95</b>: pay by average daily 95th percentile per month</description></item>
                /// <item><description><b>month_95_night_half</b>: pay by 95th percentile (50% off during nighttime)</description></item>
                /// <item><description><b>hour_vas</b>: pay by value-added service per month</description></item>
                /// <item><description><b>quic_hour_count</b>: pay by QUIC request per hour</description></item>
                /// <item><description><b>hour_count</b>: pay by request per hour</description></item>
                /// <item><description><b>rtlog_count_day</b>: pay by the number of real-time logs per day</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>month_avg_day_bandwidth_overseas</para>
                /// </summary>
                [NameInMap("BillType")]
                [Validation(Required=false)]
                public string BillType { get; set; }

                /// <summary>
                /// <para>The metering cycle.</para>
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
                /// <item><description><b>flow</b>: network traffic and bandwidth</description></item>
                /// <item><description><b>vas</b>: value-added services (HTTPS and requests for dynamic content)</description></item>
                /// <item><description><b>websocket</b>: WebSocket</description></item>
                /// <item><description><b>quic</b>: QUIC requests</description></item>
                /// <item><description><b>rtlog2sls</b>: log entries delivered to Log Service in real time</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>flow</para>
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// <para>The time when the metering method ends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-10-31T16:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dcdn</para>
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// <para>The time when the metering method takes effect.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
