// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class BatchSubmitPreBillRequest : TeaModel {
        /// <summary>
        /// <para>A system parameter. You do not need to manually specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.66.54.114</para>
        /// </summary>
        [NameInMap("app_ip")]
        [Validation(Required=false)]
        public string AppIp { get; set; }

        /// <summary>
        /// <para>The bill batch date in the format of yyyy-MM-dd, such as 2026-06-21.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-21</para>
        /// </summary>
        [NameInMap("bill_batch")]
        [Validation(Required=false)]
        public string BillBatch { get; set; }

        /// <summary>
        /// <para>The customer decision. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: bill in the current period.</description></item>
        /// <item><description>2: deferred billing.</description></item>
        /// <item><description>null: bill based on the current billing decision of the record.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("customer_decision")]
        [Validation(Required=false)]
        public int? CustomerDecision { get; set; }

        /// <summary>
        /// <para>The dimension type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: bill ID.</description></item>
        /// <item><description>2: order number.</description></item>
        /// <item><description>3: approval form.</description></item>
        /// <item><description>4: invoice title.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>The values determined by the dimension parameter. For example, if dimension is set to 1, the values should be bill IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
