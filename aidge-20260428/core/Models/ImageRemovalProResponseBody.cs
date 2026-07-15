// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemovalProResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The intelligent removal Pro result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImageRemovalProResponseBodyData Data { get; set; }
        public class ImageRemovalProResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The URL of the result image. This parameter is returned in synchronous mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aib-image.oss-ap-southeast-1.aliyuncs.com/ai_desc%2F250cc947-9cd5-4df0-9c23-44eba5d0dfc30.jpg?OSSAccessKeyId=LTAI5tSEGjGp5wixZgHLc3bV&Expires=4999655814&Signature=shvGNDmkyv9MLTw4%2BOxYglJCpAE%3D">https://aib-image.oss-ap-southeast-1.aliyuncs.com/ai_desc%2F250cc947-9cd5-4df0-9c23-44eba5d0dfc30.jpg?OSSAccessKeyId=LTAI5tSEGjGp5wixZgHLc3bV&amp;Expires=4999655814&amp;Signature=shvGNDmkyv9MLTw4%2BOxYglJCpAE%3D</a></para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The asynchronous task ID. This parameter is returned in asynchronous mode and is used to query the task result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ed9d8504-6141-9fbb-8345-4fa36433483f</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The usage details. This parameter is returned in synchronous mode.</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, long?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
