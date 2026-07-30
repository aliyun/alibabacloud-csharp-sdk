// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class VasBillSettlementQueryRequest : TeaModel {
        /// <summary>
        /// <para>The approval ID.</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// <para>The bill batch in yyyyMMdd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250501</para>
        /// </summary>
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        /// <summary>
        /// <para>The bill recording end time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02</para>
        /// </summary>
        [NameInMap("bill_record_time_end")]
        [Validation(Required=false)]
        public string BillRecordTimeEnd { get; set; }

        /// <summary>
        /// <para>The bill recording start time in yyyy-MM-dd or yyyy-MM-dd HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01</para>
        /// </summary>
        [NameInMap("bill_record_time_start")]
        [Validation(Required=false)]
        public string BillRecordTimeStart { get; set; }

        /// <summary>
        /// <para>The ID of the service provider.</para>
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
        /// <para>The page number to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_no")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing update end date in yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01</para>
        /// </summary>
        [NameInMap("period_end")]
        [Validation(Required=false)]
        public string PeriodEnd { get; set; }

        /// <summary>
        /// <para>The billing update start date in yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-01</para>
        /// </summary>
        [NameInMap("period_start")]
        [Validation(Required=false)]
        public string PeriodStart { get; set; }

        /// <summary>
        /// <para>The scroll ID. In scroll mode, this value can be used as the input parameter for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAESBgoEIgIIABgAIhkKFwMSAAAAMUw4MDAwMDAwMDA3MjdkMzgw</para>
        /// </summary>
        [NameInMap("scroll_id")]
        [Validation(Required=false)]
        public string ScrollId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use scroll mode for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("scroll_mod")]
        [Validation(Required=false)]
        public bool? ScrollMod { get; set; }

    }

}
