// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanAllocateCreditAmountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2032123221</para>
        /// </summary>
        [NameInMap("Ecid")]
        [Validation(Required=false)]
        public string Ecid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("EcidAllocatedCreditAmount")]
        [Validation(Required=false)]
        public string EcidAllocatedCreditAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("EcidCreditAmount")]
        [Validation(Required=false)]
        public string EcidCreditAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202321232</para>
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
        /// <para>云某的名称</para>
        /// </summary>
        [NameInMap("FundAccountName")]
        [Validation(Required=false)]
        public string FundAccountName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123433121</para>
        /// </summary>
        [NameInMap("FundAccountOwnerAccountId")]
        [Validation(Required=false)]
        public long? FundAccountOwnerAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("MaxCanAllocateCreditAmount")]
        [Validation(Required=false)]
        public string MaxCanAllocateCreditAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MinCanAllocateCreditAmount")]
        [Validation(Required=false)]
        public string MinCanAllocateCreditAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CC706AAC-75A6-55B5-9AB7-7D171C6C7655</para>
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

    }

}
