// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SubmitSlaCouponApplyRequest : TeaModel {
        /// <summary>
        /// <para>Optional. Damaged record IDs.</para>
        /// </summary>
        [NameInMap("DamagedIds")]
        [Validation(Required=false)]
        public List<string> DamagedIds { get; set; }

        /// <summary>
        /// <para>Enterprise and account list. If empty, the current account itself is queried.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<SubmitSlaCouponApplyRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class SubmitSlaCouponApplyRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>List of accounts to access. If empty, all accounts under the current entity ID are selected.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>Enterprise entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1501603440974415</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>Required. Application month in the yyyyMM format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202603</para>
        /// </summary>
        [NameInMap("Month")]
        [Validation(Required=false)]
        public int? Month { get; set; }

        /// <summary>
        /// <para>Primary marketplace ID. If empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
