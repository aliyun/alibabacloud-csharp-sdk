// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqAuthorizeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>617277C****************ABA47E31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of user information for failed operations.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<SmartqAuthorizeResponseBodyResult> Result { get; set; }
        public class SmartqAuthorizeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INVALID_FILE_FORMAT</para>
            /// </summary>
            [NameInMap("DetailMessage")]
            [Validation(Required=false)]
            public string DetailMessage { get; set; }

            /// <summary>
            /// <para>The Q\&amp;A resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("LlmCube")]
            [Validation(Required=false)]
            public string LlmCube { get; set; }

            /// <summary>
            /// <para>The analysis subject ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("LlmCubeTheme")]
            [Validation(Required=false)]
            public string LlmCubeTheme { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
