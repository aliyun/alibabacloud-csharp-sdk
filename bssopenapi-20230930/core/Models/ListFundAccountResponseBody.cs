// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListFundAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFundAccountResponseBodyData> Data { get; set; }
        public class ListFundAccountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the account was created. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-30 12:00:00</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The account ID of the MA user corresponding to the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232121</para>
            /// </summary>
            [NameInMap("FundAccountAdminAccountId")]
            [Validation(Required=false)]
            public string FundAccountAdminAccountId { get; set; }

            /// <summary>
            /// <para>The username of the MA user corresponding to the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Yun\&quot;s account</para>
            /// </summary>
            [NameInMap("FundAccountAdminAccountName")]
            [Validation(Required=false)]
            public string FundAccountAdminAccountName { get; set; }

            /// <summary>
            /// <para>The fund account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1022231</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public string FundAccountId { get; set; }

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
            /// <para>The account ID of the fund account owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132123211</para>
            /// </summary>
            [NameInMap("FundAccountOwnerAccountId")]
            [Validation(Required=false)]
            public string FundAccountOwnerAccountId { get; set; }

            /// <summary>
            /// <para>The account status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>VALID: Valid.</description></item>
            /// <item><description>FROZEN: Frozen. </description></item>
            /// <item><description>CLOSED: Closed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("FundAccountStatus")]
            [Validation(Required=false)]
            public string FundAccountStatus { get; set; }

            /// <summary>
            /// <para>The account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DIRECT_USER: Alibaba Cloud direct customer account. </description></item>
            /// <item><description>RESELLER_QUOTA: Ecosystem account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DIRECT_USER</para>
            /// </summary>
            [NameInMap("FundAccountType")]
            [Validation(Required=false)]
            public string FundAccountType { get; set; }

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
            /// <para>The set of account permissions owned by the user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>using: Use.</description></item>
            /// <item><description>manage: Manage.</description></item>
            /// <item><description>owner: Own.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Permissions")]
            [Validation(Required=false)]
            public List<string> Permissions { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
