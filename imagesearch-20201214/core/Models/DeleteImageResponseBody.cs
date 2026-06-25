// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DeleteImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: success.</description></item>
        /// <item><description>Non-zero value: failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The deletion result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteImageResponseBodyData Data { get; set; }
        public class DeleteImageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The deleted PicName.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5555.jpg</para>
            /// </summary>
            [NameInMap("PicNames")]
            [Validation(Required=false)]
            public List<string> PicNames { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0703956F-9BCC-48FA-99F7-96C0BF449C69</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
