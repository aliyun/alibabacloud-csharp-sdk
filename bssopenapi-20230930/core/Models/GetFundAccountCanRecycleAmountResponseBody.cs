// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanRecycleAmountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("AvailableAmount")]
        [Validation(Required=false)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("Currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1232122132</para>
        /// </summary>
        [NameInMap("RecycleFromFundAccountId")]
        [Validation(Required=false)]
        public string RecycleFromFundAccountId { get; set; }

        [NameInMap("RecycleToFundAccountList")]
        [Validation(Required=false)]
        public List<GetFundAccountCanRecycleAmountResponseBodyRecycleToFundAccountList> RecycleToFundAccountList { get; set; }
        public class GetFundAccountCanRecycleAmountResponseBodyRecycleToFundAccountList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>122323121</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public string FundAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>云某的账户</para>
            /// </summary>
            [NameInMap("FundAccountName")]
            [Validation(Required=false)]
            public string FundAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>183221321</para>
            /// </summary>
            [NameInMap("FundAccountOwnerAccountId")]
            [Validation(Required=false)]
            public string FundAccountOwnerAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("MaxRecyclableAmount")]
            [Validation(Required=false)]
            public string MaxRecyclableAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("OriginalTransferRemainAmount")]
            [Validation(Required=false)]
            public string OriginalTransferRemainAmount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TransferAmount")]
        [Validation(Required=false)]
        public string TransferAmount { get; set; }

    }

}
