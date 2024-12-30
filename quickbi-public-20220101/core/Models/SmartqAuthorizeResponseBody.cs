// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqAuthorizeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>617277C****************ABA47E31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<SmartqAuthorizeResponseBodyResult> Result { get; set; }
        public class SmartqAuthorizeResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>INVALID_FILE_FORMAT</para>
            /// </summary>
            [NameInMap("DetailMessage")]
            [Validation(Required=false)]
            public string DetailMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("LlmCube")]
            [Validation(Required=false)]
            public string LlmCube { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("LlmCubeTheme")]
            [Validation(Required=false)]
            public string LlmCubeTheme { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

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
