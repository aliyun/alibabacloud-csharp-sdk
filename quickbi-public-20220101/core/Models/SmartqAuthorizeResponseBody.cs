// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SmartqAuthorizeResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>617277C****************ABA47E31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Array of failed user information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<SmartqAuthorizeResponseBodyResult> Result { get; set; }
        public class SmartqAuthorizeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Reason for failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INVALID_FILE_FORMAT</para>
            /// </summary>
            [NameInMap("DetailMessage")]
            [Validation(Required=false)]
            public string DetailMessage { get; set; }

            /// <summary>
            /// <para>Q&amp;A resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("LlmCube")]
            [Validation(Required=false)]
            public string LlmCube { get; set; }

            /// <summary>
            /// <para>Analysis theme ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("LlmCubeTheme")]
            [Validation(Required=false)]
            public string LlmCubeTheme { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>617277C****************ABA47E31</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. The value range is as follows:</para>
        /// <list type="bullet">
        /// <item><description>true: Request succeeded</description></item>
        /// <item><description>false: Request failed</description></item>
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
