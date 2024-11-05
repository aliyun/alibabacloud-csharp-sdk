// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetDailyBillRequest : TeaModel {
        /// <summary>
        /// <para>Bill Owner type. Value Range:</br>
        /// 1: Master account</br>
        /// 2: Sub account</br></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BillOwner")]
        [Validation(Required=false)]
        public string BillOwner { get; set; }

        /// <summary>
        /// <para>BillType. Value Range:</br></para>
        /// <list type="bullet">
        /// <item><description>DailyOrder(Deprecated)</description></item>
        /// <item><description>DailyBill (Deprecated)</description></item>
        /// <item><description>DailyInstanceBill (Deprecated)</description></item>
        /// <item><description>DailyInstanceBillV2</description></item>
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
