// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetDailyBillRequest : TeaModel {
        /// <summary>
        /// Bill Owner type. Value Range:</br>
        /// 1: Master account</br>
        /// 2: Sub account</br>
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BillOwner")]
        [Validation(Required=false)]
        public string BillOwner { get; set; }

        /// <summary>
        /// BillType. Value Range:</br>
        /// 
        /// - DailyOrder(Deprecated)
        /// - DailyBill (Deprecated)
        /// - DailyInstanceBill (Deprecated)
        /// - DailyInstanceBillV2
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// Billing date. Format YYYY-MM-DD
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

    }

}
