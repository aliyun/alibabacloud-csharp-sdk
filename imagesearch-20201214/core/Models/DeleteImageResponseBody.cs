// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DeleteImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// <list type="bullet">
        /// <item><description>A value of 0 indicates that the operation is successful.</description></item>
        /// <item><description>Values other than 0 indicate errors.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the deleted images.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteImageResponseBodyData Data { get; set; }
        public class DeleteImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name (PicName) of the deleted image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5555.jpg</para>
            /// </summary>
            [NameInMap("PicNames")]
            [Validation(Required=false)]
            public List<string> PicNames { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0703956F-9BCC-48FA-99F7-96C0BF449C69</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
