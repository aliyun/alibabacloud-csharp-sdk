// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetDailyBillRequest : TeaModel {
        /// <summary>
        /// <para>The type of the bill owner. Valid values:</para>
        /// <para>1: reseller partner account </para>
        /// <para>2: reseller customer account</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BillOwner")]
        [Validation(Required=false)]
        public string BillOwner { get; set; }

        /// <summary>
        /// <para>The bill type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DailyOrder (deprecated)</para>
        /// </description></item>
        /// <item><description><para>DailyBill (deprecated)</para>
        /// </description></item>
        /// <item><description><para>DailyInstanceBill (deprecated) </para>
        /// </description></item>
        /// <item><description><para>DailyInstanceBillV2</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DailyInstanceBillV2</para>
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// <para>Billing date. Format YYYY-MM-DD</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-24</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

    }

}
