// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SubmitSlaCouponApplyRequest : TeaModel {
        [NameInMap("DamagedIds")]
        [Validation(Required=false)]
        public List<string> DamagedIds { get; set; }

        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<SubmitSlaCouponApplyRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class SubmitSlaCouponApplyRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1501603440974415</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202603</para>
        /// </summary>
        [NameInMap("Month")]
        [Validation(Required=false)]
        public int? Month { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
