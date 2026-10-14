// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class GetDataMaskingColumnCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The column encryption statistics.</para>
        /// </summary>
        [NameInMap("ColumnCount")]
        [Validation(Required=false)]
        public GetDataMaskingColumnCountResponseBodyColumnCount ColumnCount { get; set; }
        public class GetDataMaskingColumnCountResponseBodyColumnCount : TeaModel {
            /// <summary>
            /// <para>The number of encrypted columns within the current scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaskedCount")]
            [Validation(Required=false)]
            public long? MaskedCount { get; set; }

            /// <summary>
            /// <para>The number of columns that failed to be encrypted within the current scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaskingFailedCount")]
            [Validation(Required=false)]
            public long? MaskingFailedCount { get; set; }

            /// <summary>
            /// <para>The number of sensitive columns within the current scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public long? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The total number of columns within the current scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which can be used to locate this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
