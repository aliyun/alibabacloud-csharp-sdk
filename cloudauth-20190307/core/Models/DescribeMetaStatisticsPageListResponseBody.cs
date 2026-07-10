// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaStatisticsPageListResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Paginated list data.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeMetaStatisticsPageListResponseBodyItems> Items { get; set; }
        public class DescribeMetaStatisticsPageListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID_PERIOD</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            /// <summary>
            /// <para>Name corresponding to the API:</para>
            /// <list type="bullet">
            /// <item><description><b>ID_CARD_2_META</b>: ID Card Two-Element Verification</description></item>
            /// <item><description><b>ID_PERIOD</b>: ID Card Validity Verification Period</description></item>
            /// <item><description><b>MOBILE_ONLINE_LENGTH</b>: Mobile Online Duration</description></item>
            /// <item><description><b>MOBILE_ONLINE_STATUS</b>: Mobile Online Status</description></item>
            /// <item><description><b>MOBILE_3_META_SIMPLE</b>: Mobile Number Three-Element Verification (Simple)</description></item>
            /// <item><description><b>MOBILE_3_META</b>: Mobile Number Three-Element Verification (Detailed)</description></item>
            /// <item><description><b>MOBILE_2_META</b>: Mobile Number Two-Element Verification</description></item>
            /// <item><description><b>BANK_CARD_N_META</b>: Bank Card Verification (Detailed)</description></item>
            /// <item><description><b>MOBILE_DETECT</b>: Number Detection
            ///  -<b>VEHICLE_N_META</b>: Vehicle Element Verification (Enhanced)</description></item>
            /// <item><description><b>VEHICLE_PENTA_INFO</b>: Vehicle Five-Element Information Recognition</description></item>
            /// <item><description><b>VEHICLE_LICENSE_INFO</b>: Vehicle Information Recognition</description></item>
            /// <item><description><b>VEHICLE_INSURE_DATE</b>: Vehicle Insurance Date Query</description></item>
            /// <item><description><b>VEHICLE_CHECK</b>: Vehicle Element Verification</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>车辆要素核验增强版</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>Number of hits (billed).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("BillCount")]
            [Validation(Required=false)]
            public long? BillCount { get; set; }

            /// <summary>
            /// <para>Hit rate (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("BillRate")]
            [Validation(Required=false)]
            public string BillRate { get; set; }

            /// <summary>
            /// <para>Number of successful mobile number queries (exclusive to Number Detection).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChargeCount")]
            [Validation(Required=false)]
            public long? ChargeCount { get; set; }

            /// <summary>
            /// <para>Date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11/8</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>Carrier name:</para>
            /// <list type="bullet">
            /// <item><description><b>CMCC</b>: China Mobile</description></item>
            /// <item><description><b>CUCC</b>: China Unicom</description></item>
            /// <item><description><b>CTCC</b>: China Telecom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CMCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <para>Number of calls with no record information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("NoRecordCount")]
            [Validation(Required=false)]
            public long? NoRecordCount { get; set; }

            /// <summary>
            /// <para>Number of passed authentications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("PassedCount")]
            [Validation(Required=false)]
            public long? PassedCount { get; set; }

            /// <summary>
            /// <para>Authentication pass rate (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("PassedRate")]
            [Validation(Required=false)]
            public string PassedRate { get; set; }

            /// <summary>
            /// <para>Number of successful requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public long? SuccessCount { get; set; }

            /// <summary>
            /// <para>Call success rate (%).</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccessRate")]
            [Validation(Required=false)]
            public string SuccessRate { get; set; }

            /// <summary>
            /// <para>Total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <para>Number of failed calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnpassedCount")]
            [Validation(Required=false)]
            public long? UnpassedCount { get; set; }

        }

        /// <summary>
        /// <para>Number of data entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C379C9E4-4DA0-5D0B-821B-25E2B8693D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
