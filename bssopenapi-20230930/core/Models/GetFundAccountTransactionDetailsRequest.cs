// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountTransactionDetailsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2023212312321</para>
        /// </summary>
        [NameInMap("BillNumber")]
        [Validation(Required=false)]
        public string BillNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20250312334312322</para>
        /// </summary>
        [NameInMap("ChannelTransactionNumber")]
        [Validation(Required=false)]
        public string ChannelTransactionNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1735664561000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123221232</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1735664461000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TransactionChannelList")]
        [Validation(Required=false)]
        public List<string> TransactionChannelList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IN</para>
        /// </summary>
        [NameInMap("TransactionDirection")]
        [Validation(Required=false)]
        public string TransactionDirection { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>543231231</para>
        /// </summary>
        [NameInMap("TransactionNumber")]
        [Validation(Required=false)]
        public long? TransactionNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CHARGE</para>
        /// </summary>
        [NameInMap("TransactionType")]
        [Validation(Required=false)]
        public string TransactionType { get; set; }

        [NameInMap("TransactionTypeList")]
        [Validation(Required=false)]
        public List<string> TransactionTypeList { get; set; }

    }

}
