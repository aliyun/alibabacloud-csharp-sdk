// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class DescribeEmptyNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>返回状态码。取值：</para>
        /// <list type="bullet">
        /// <item><description><para><b>OK</b>：成功。</para>
        /// </description></item>
        /// <item><description><para><b>InvalidPhoneNumber.Check</b>：手机号非法。</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>返回结果。</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEmptyNumberResponseBodyData Data { get; set; }
        public class DescribeEmptyNumberResponseBodyData : TeaModel {
            /// <summary>
            /// <para>传入的手机号。</para>
            /// 
            /// <b>Example:</b>
            /// <para>189****1234</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <para>检测手机号返回状态。取值：</para>
            /// <list type="bullet">
            /// <item><description><para><b>EMPTY</b>：空号。</para>
            /// </description></item>
            /// <item><description><para><b>NORMAL</b>：正常。</para>
            /// </description></item>
            /// <item><description><para><b>SUSPECT_EMPTY</b>：疑似空号。</para>
            /// </description></item>
            /// <item><description><para><b>UNKNOWN</b>：未知。</para>
            /// </description></item>
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
        /// <para>状态码的描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>公共参数，每个请求返回的ID都是唯一的，可用于排查和定位问题。</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
