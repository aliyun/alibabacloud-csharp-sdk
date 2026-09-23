// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SubmitSlaCouponApplyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the damaged records. This parameter is optional.</para>
        /// </summary>
        [NameInMap("DamagedIds")]
        [Validation(Required=false)]
        public List<string> DamagedIds { get; set; }

        /// <summary>
        /// <para>The list of enterprises and accounts. If this parameter is left empty, the current account is queried.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<SubmitSlaCouponApplyRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class SubmitSlaCouponApplyRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>The list of accounts to access. If this parameter is left empty, all accounts under the current entity ID are selected.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>The enterprise entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1501603440974415</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>The claim month. This parameter is required. Format: yyyyMM.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202603</para>
        /// </summary>
        [NameInMap("Month")]
        [Validation(Required=false)]
        public int? Month { get; set; }

        /// <summary>
        /// <para>The primary marketplace ID. If this parameter is left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
