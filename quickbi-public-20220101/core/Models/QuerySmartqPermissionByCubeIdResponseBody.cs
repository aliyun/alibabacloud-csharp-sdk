// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QuerySmartqPermissionByCubeIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>617277******************ABA47E31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QuerySmartqPermissionByCubeIdResponseBodyResult Result { get; set; }
        public class QuerySmartqPermissionByCubeIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7c7223ae-****-3c744528014b</para>
            /// </summary>
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CubeName")]
            [Validation(Required=false)]
            public string CubeName { get; set; }

            [NameInMap("HasPerssion")]
            [Validation(Required=false)]
            public bool? HasPerssion { get; set; }

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
