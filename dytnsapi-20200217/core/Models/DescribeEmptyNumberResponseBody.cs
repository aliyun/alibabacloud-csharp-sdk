// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribeEmptyNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OK</b>: The request is successful.</description></item>
        /// <item><description><b>InvalidPhoneNumber.Check</b>: The phone number is invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEmptyNumberResponseBodyData Data { get; set; }
        public class DescribeEmptyNumberResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The specified phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>189****1234</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <para>The returned status for the queried phone number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EMPTY</b>: The queried phone number is a nonexistent number.</description></item>
            /// <item><description><b>NORMAL</b>: The queried phone number is valid.</description></item>
            /// <item><description><b>SUSPECT_EMPTY</b>: The queried phone number is suspected to be a nonexistent number.</description></item>
            /// <item><description><b>UNKNOWN</b>: The queried phone number is unknown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EMPTY</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID. It is a common parameter and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
