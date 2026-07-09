// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanRecycleAmountResponseBody : TeaModel {
        /// <summary>
        /// <para>The available balance of the account from which funds are reclaimed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("AvailableAmount")]
        [Validation(Required=false)]
        public string AvailableAmount { get; set; }

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
        /// <para>The metadata of the response struct.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The ID of the source account from which funds are reclaimed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1232122132</para>
        /// </summary>
        [NameInMap("RecycleFromFundAccountId")]
        [Validation(Required=false)]
        public string RecycleFromFundAccountId { get; set; }

        /// <summary>
        /// <para>The list of accounts to which funds can be reclaimed.</para>
        /// </summary>
        [NameInMap("RecycleToFundAccountList")]
        [Validation(Required=false)]
        public List<GetFundAccountCanRecycleAmountResponseBodyRecycleToFundAccountList> RecycleToFundAccountList { get; set; }
        public class GetFundAccountCanRecycleAmountResponseBodyRecycleToFundAccountList : TeaModel {
            /// <summary>
            /// <para>The ID of the target account to which funds can be reclaimed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>122323121</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public string FundAccountId { get; set; }

            /// <summary>
            /// <para>The name of the target account to which funds can be reclaimed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云某的账户</para>
            /// </summary>
            [NameInMap("FundAccountName")]
            [Validation(Required=false)]
            public string FundAccountName { get; set; }

            /// <summary>
            /// <para>The account ID that owns the target account to which funds can be reclaimed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>183221321</para>
            /// </summary>
            [NameInMap("FundAccountOwnerAccountId")]
            [Validation(Required=false)]
            public string FundAccountOwnerAccountId { get; set; }

            /// <summary>
            /// <para>The maximum reclaimable amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxRecyclableAmount")]
            [Validation(Required=false)]
            public string MaxRecyclableAmount { get; set; }

            /// <summary>
            /// <para>The remaining transfer amount that can be reclaimed through the original transfer path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("OriginalTransferRemainAmount")]
            [Validation(Required=false)]
            public string OriginalTransferRemainAmount { get; set; }

        }

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
        /// <para>The transfer ledger balance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TransferAmount")]
        [Validation(Required=false)]
        public string TransferAmount { get; set; }

    }

}
