// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadNumGroupByClassResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the call fails. For more information, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The execution result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ReadNumGroupByClassResponseBodyData> Data { get; set; }
        public class ReadNumGroupByClassResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClassId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// <para>The number of unread messages in the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MsgCount")]
            [Validation(Required=false)]
            public long? MsgCount { get; set; }

        }

        /// <summary>
        /// <para>The message returned when the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5F62766-1C2F-1F56-A39D-63E3D30F0633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
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
