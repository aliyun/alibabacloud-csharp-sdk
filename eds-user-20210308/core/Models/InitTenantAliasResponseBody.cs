// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class InitTenantAliasResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("AliasInfo")]
        [Validation(Required=false)]
        public InitTenantAliasResponseBodyAliasInfo AliasInfo { get; set; }
        public class InitTenantAliasResponseBodyAliasInfo : TeaModel {
            /// <summary>
            /// <para>The reason why modification is not allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FrequencyExceedsLimit</para>
            /// </summary>
            [NameInMap("AliasEditDisabledReason")]
            [Validation(Required=false)]
            public string AliasEditDisabledReason { get; set; }

            /// <summary>
            /// <para>Indicates whether modification is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("AliasEditable")]
            [Validation(Required=false)]
            public bool? AliasEditable { get; set; }

            /// <summary>
            /// <para>The source of the organization ID.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Generated: auto-generated.</description></item>
            /// <item><description>Customized: user-defined.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Customized</para>
            /// </summary>
            [NameInMap("AliasSourceType")]
            [Validation(Required=false)]
            public string AliasSourceType { get; set; }

            /// <summary>
            /// <para>The time window during which modification is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-17 20:31:48</para>
            /// </summary>
            [NameInMap("NextModifyTime")]
            [Validation(Required=false)]
            public string NextModifyTime { get; set; }

        }

        /// <summary>
        /// <para>The generated ID of the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WY23***</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
