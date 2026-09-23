// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostByCostCenterRequest : TeaModel {
        /// <summary>
        /// <para>The billing cycle month in the format of YYYYMM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202506</para>
        /// </summary>
        [NameInMap("BillingMonth")]
        [Validation(Required=false)]
        public int? BillingMonth { get; set; }

        /// <summary>
        /// <para>Specifies whether to display data rows with a payable amount of 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisplayZeroAmountBills")]
        [Validation(Required=false)]
        public bool? DisplayZeroAmountBills { get; set; }

        /// <summary>
        /// <para>Specifies whether to display results grouped by financial unit level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GroupByCostCenterLevel")]
        [Validation(Required=false)]
        public bool? GroupByCostCenterLevel { get; set; }

        /// <summary>
        /// <para>The cost type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQUIRE_AMOUNT</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The account ID of the resource ownership.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1374729705039203</para>
        /// </summary>
        [NameInMap("OwnerAccountId")]
        [Validation(Required=false)]
        public long? OwnerAccountId { get; set; }

    }

}
