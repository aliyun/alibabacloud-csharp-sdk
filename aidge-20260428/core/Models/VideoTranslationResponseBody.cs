// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VideoTranslationResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Processing</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of the asynchronous task submission.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public VideoTranslationResponseBodyData Data { get; set; }
        public class VideoTranslationResponseBodyData : Darabonba.Model {
            /// <summary>
            /// <para>The ID of the asynchronous task. You can use this ID for subsequent queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ea3b66e88a543658520c994f08896a0</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Translation processing</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req_20260608_jkl012</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values: <c>true</c> (successful) and <c>false</c> (failed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

