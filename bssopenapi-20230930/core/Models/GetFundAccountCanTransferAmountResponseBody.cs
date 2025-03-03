// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanTransferAmountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AvailableAmount")]
        [Validation(Required=false)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("CashAmount")]
        [Validation(Required=false)]
        public string CashAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2032121324</para>
        /// </summary>
        [NameInMap("FundAccountEcid")]
        [Validation(Required=false)]
        public string FundAccountEcid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12332112</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>云某的账户</para>
        /// </summary>
        [NameInMap("FundAccountName")]
        [Validation(Required=false)]
        public string FundAccountName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>154738212323</para>
        /// </summary>
        [NameInMap("FundAccountOwnerAccountId")]
        [Validation(Required=false)]
        public long? FundAccountOwnerAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxTransferableAmount")]
        [Validation(Required=false)]
        public string MaxTransferableAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26842</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TransferAmount")]
        [Validation(Required=false)]
        public string TransferAmount { get; set; }

    }

}
