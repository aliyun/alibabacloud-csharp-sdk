// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanTransferAmountResponseBody : TeaModel {
        /// <summary>
        /// <para>The available amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AvailableAmount")]
        [Validation(Required=false)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// <para>The cash ledger balance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("CashAmount")]
        [Validation(Required=false)]
        public string CashAmount { get; set; }

        /// <summary>
        /// <para>The currency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>The enterprise entity ID of the fund account owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2032121324</para>
        /// </summary>
        [NameInMap("FundAccountEcid")]
        [Validation(Required=false)]
        public string FundAccountEcid { get; set; }

        /// <summary>
        /// <para>The fund account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12332112</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

        /// <summary>
        /// <para>The fund account name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Yun\&quot;s account</para>
        /// </summary>
        [NameInMap("FundAccountName")]
        [Validation(Required=false)]
        public string FundAccountName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the fund account owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>154738212323</para>
        /// </summary>
        [NameInMap("FundAccountOwnerAccountId")]
        [Validation(Required=false)]
        public long? FundAccountOwnerAccountId { get; set; }

        /// <summary>
        /// <para>The maximum transferable amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxTransferableAmount")]
        [Validation(Required=false)]
        public string MaxTransferableAmount { get; set; }

        /// <summary>
        /// <para>The metadata of the response structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The primary sales site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26842</para>
        /// </summary>
        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

        /// <summary>
        /// <para>The transfer ledger balance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TransferAmount")]
        [Validation(Required=false)]
        public string TransferAmount { get; set; }

    }

}
