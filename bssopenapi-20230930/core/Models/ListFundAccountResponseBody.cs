// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListFundAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>Data list</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFundAccountResponseBodyData> Data { get; set; }
        public class ListFundAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Account creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-30 12:00:00</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>Account ID of the MA user associated with the account</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232121</para>
            /// </summary>
            [NameInMap("FundAccountAdminAccountId")]
            [Validation(Required=false)]
            public string FundAccountAdminAccountId { get; set; }

            /// <summary>
            /// <para>Name of the MA user associated with the account</para>
            /// 
            /// <b>Example:</b>
            /// <para>云某的账户</para>
            /// </summary>
            [NameInMap("FundAccountAdminAccountName")]
            [Validation(Required=false)]
            public string FundAccountAdminAccountName { get; set; }

            /// <summary>
            /// <para>Account ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1022231</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public string FundAccountId { get; set; }

            /// <summary>
            /// <para>Account name</para>
            /// 
            /// <b>Example:</b>
            /// <para>云某的账户</para>
            /// </summary>
            [NameInMap("FundAccountName")]
            [Validation(Required=false)]
            public string FundAccountName { get; set; }

            /// <summary>
            /// <para>Account ID of the fund account owner</para>
            /// 
            /// <b>Example:</b>
            /// <para>132123211</para>
            /// </summary>
            [NameInMap("FundAccountOwnerAccountId")]
            [Validation(Required=false)]
            public string FundAccountOwnerAccountId { get; set; }

            /// <summary>
            /// <para>Account status.
            /// VALID: valid.
            /// FROZEN: frozen.
            /// CLOSED: closed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("FundAccountStatus")]
            [Validation(Required=false)]
            public string FundAccountStatus { get; set; }

            /// <summary>
            /// <para>Account type.
            /// DIRECT_USER: Alibaba Cloud direct customer account.
            /// RESELLER_QUOTA: ecosystem account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DIRECT_USER</para>
            /// </summary>
            [NameInMap("FundAccountType")]
            [Validation(Required=false)]
            public string FundAccountType { get; set; }

            /// <summary>
            /// <para>Level-1 marketplace</para>
            /// 
            /// <b>Example:</b>
            /// <para>2684210001</para>
            /// </summary>
            [NameInMap("Nbid")]
            [Validation(Required=false)]
            public string Nbid { get; set; }

            /// <summary>
            /// <para>Set of account permissions that the user has.
            /// using: use.
            /// manage: manage.
            /// owner: own.</para>
            /// </summary>
            [NameInMap("Permissions")]
            [Validation(Required=false)]
            public List<string> Permissions { get; set; }

            /// <summary>
            /// <para>Site</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

        }

        /// <summary>
        /// <para>Response metadata</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
