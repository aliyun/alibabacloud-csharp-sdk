// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class InitTenantAliasResponseBody : TeaModel {
        [NameInMap("AliasInfo")]
        [Validation(Required=false)]
        public InitTenantAliasResponseBodyAliasInfo AliasInfo { get; set; }
        public class InitTenantAliasResponseBodyAliasInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>FrequencyExceedsLimit</para>
            /// </summary>
            [NameInMap("AliasEditDisabledReason")]
            [Validation(Required=false)]
            public string AliasEditDisabledReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("AliasEditable")]
            [Validation(Required=false)]
            public bool? AliasEditable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Customized</para>
            /// </summary>
            [NameInMap("AliasSourceType")]
            [Validation(Required=false)]
            public string AliasSourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-04-17 20:31:48</para>
            /// </summary>
            [NameInMap("NextModifyTime")]
            [Validation(Required=false)]
            public string NextModifyTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WY23***</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
