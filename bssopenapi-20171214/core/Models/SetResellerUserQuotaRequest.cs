// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetResellerUserQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The quota of a quota ledger. Unit: CNY.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>750</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>You do not need to set the parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The ID of the business.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OD2022040818295234777795624764689</para>
        /// </summary>
        [NameInMap("OutBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
