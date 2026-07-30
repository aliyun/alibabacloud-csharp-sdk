// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CooperatorFlightBillSettlementQueryRequest : TeaModel {
        /// <summary>
        /// <para>The approval ID.</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// <para>The bill batch in the format yyyyMMdd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250101</para>
        /// </summary>
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        /// <summary>
        /// <para>The bill recording end time in the format yyyy-MM-dd or yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02</para>
        /// </summary>
        [NameInMap("bill_record_time_end")]
        [Validation(Required=false)]
        public string BillRecordTimeEnd { get; set; }

        /// <summary>
        /// <para>The bill recording start time in the format yyyy-MM-dd or yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01</para>
        /// </summary>
        [NameInMap("bill_record_time_start")]
        [Validation(Required=false)]
        public string BillRecordTimeStart { get; set; }

        /// <summary>
        /// <para>The service provider ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cooperator_alibtrip</para>
        /// </summary>
        [NameInMap("cooperator_id")]
        [Validation(Required=false)]
        public string CooperatorId { get; set; }

        /// <summary>
        /// <para>The business travel order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// <para>Default value: 10. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The end time for querying billing data.</para>
        /// <list type="bullet">
        /// <item><description>Format: yyyy-MM-dd or yyyy-MM-dd HH:mm:ss.</description></item>
        /// <item><description>Maximum value: current time - 1h.</description></item>
        /// <item><description>Range requirement: billing data end time - billing data start time ≤ 1 day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-02</para>
        /// </summary>
        [NameInMap("period_end")]
        [Validation(Required=false)]
        public string PeriodEnd { get; set; }

        /// <summary>
        /// <para>The start time for querying billing data.</para>
        /// <list type="bullet">
        /// <item><description>Format: <c>yyyy-MM-dd or yyyy-MM-dd HH:mm:ss</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-01</para>
        /// </summary>
        [NameInMap("period_start")]
        [Validation(Required=false)]
        public string PeriodStart { get; set; }

        /// <summary>
        /// <para>The scroll ID. In scroll mode, pass the scroll ID returned from the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1qawe</para>
        /// </summary>
        [NameInMap("scroll_id")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use scroll mode. Default value: false. Scroll mode bypasses the query limit. Otherwise, only one day of data can be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scroll_mod")]
        [Validation(Required=false)]
        public bool? ScrollMod { get; set; }

    }

}
