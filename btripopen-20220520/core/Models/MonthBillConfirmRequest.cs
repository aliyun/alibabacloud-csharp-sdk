// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillConfirmRequest : TeaModel {
        /// <summary>
        /// <para>The billing date.</para>
        /// <list type="bullet">
        /// <item><description>Format: yyyyMMdd.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20000101</para>
        /// </summary>
        [NameInMap("mail_bill_date")]
        [Validation(Required=false)]
        public int? MailBillDate { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
