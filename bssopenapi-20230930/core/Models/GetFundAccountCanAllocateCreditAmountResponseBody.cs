// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetFundAccountCanAllocateCreditAmountResponseBody : TeaModel {
        /// <summary>
        /// <para>The enterprise entity ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2032123221</para>
        /// </summary>
        [NameInMap("Ecid")]
        [Validation(Required=false)]
        public string Ecid { get; set; }

        /// <summary>
        /// <para>The allocated credit limit of the enterprise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("EcidAllocatedCreditAmount")]
        [Validation(Required=false)]
        public string EcidAllocatedCreditAmount { get; set; }

        /// <summary>
        /// <para>The enterprise credit quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("EcidCreditAmount")]
        [Validation(Required=false)]
        public string EcidCreditAmount { get; set; }

        /// <summary>
        /// <para>The account ECID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202321232</para>
        /// </summary>
        [NameInMap("FundAccountEcid")]
        [Validation(Required=false)]
        public string FundAccountEcid { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12332112</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public long? FundAccountId { get; set; }

        /// <summary>
        /// <para>The account name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>云某的名称</para>
        /// </summary>
        [NameInMap("FundAccountName")]
        [Validation(Required=false)]
        public string FundAccountName { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the account owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123433121</para>
        /// </summary>
        [NameInMap("FundAccountOwnerAccountId")]
        [Validation(Required=false)]
        public long? FundAccountOwnerAccountId { get; set; }

        /// <summary>
        /// <para>The maximum allocatable credit limit of the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("MaxCanAllocateCreditAmount")]
        [Validation(Required=false)]
        public string MaxCanAllocateCreditAmount { get; set; }

        /// <summary>
        /// <para>Response structure metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The minimum allocatable credit limit of the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MinCanAllocateCreditAmount")]
        [Validation(Required=false)]
        public string MinCanAllocateCreditAmount { get; set; }

        /// <summary>
        /// <para>The primary marketplace.</para>
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
        /// <para>CC706AAC-75A6-55B5-9AB7-7D171C6C7655</para>
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

    }

}
