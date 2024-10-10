// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetSwitchInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FAECEFA8-09BB-58AB-BC58-C8ACEFE4D232</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetSwitchInfoResponseBodyResult Result { get; set; }
        public class QueryDatasetSwitchInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7c7223ae-****-3c744528014b</para>
            /// </summary>
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsOpenColumnLevelPermission")]
            [Validation(Required=false)]
            public int? IsOpenColumnLevelPermission { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsOpenRowLevelPermission")]
            [Validation(Required=false)]
            public int? IsOpenRowLevelPermission { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
