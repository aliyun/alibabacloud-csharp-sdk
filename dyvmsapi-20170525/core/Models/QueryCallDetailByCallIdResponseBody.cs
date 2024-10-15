// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallDetailByCallIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/112502.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the call, in the JSON format.</para>
        /// <list type="bullet">
        /// <item><description><b>caller</b>: the calling number.</description></item>
        /// <item><description><b>startDate</b>: the time when the call was started.</description></item>
        /// <item><description><b>stateDesc</b>: the description of the call state.</description></item>
        /// <item><description><b>duration</b>: the call duration. Unit: seconds. The value <b>0</b> indicates that the user was not connected.</description></item>
        /// <item><description><b>callerShowNumber</b>: the calling number displayed to the called party.</description></item>
        /// <item><description><b>gmtCreate</b>: the time when the call request was received.</description></item>
        /// <item><description><b>state</b>: the call state. The call state is returned by the Internet service provider (ISP) in real time. For more information about call states, see <a href="https://help.aliyun.com/document_detail/55085.html">ISP-returned error codes</a>.</description></item>
        /// <item><description><b>endDate</b>: the time when the call was ended.</description></item>
        /// <item><description><b>calleeShowNumber</b>: the number displayed to the called party.</description></item>
        /// <item><description><b>callee</b>: the called number.</description></item>
        /// <item><description><b>aRingTime</b>: the time when Line A started to ring, in the yyyy-MM-dd HH:mm:ss format.</description></item>
        /// <item><description><b>aEndTime</b>: the time when ringing on Line A ended, in the yyyy-MM-dd HH:mm:ss format.</description></item>
        /// <item><description><b>bRingTime</b>: the time when Line B started to ring, in the yyyy-MM-dd HH:mm:ss format.</description></item>
        /// <item><description><b>bEndTime</b>: the time when ringing on Line B ended, in the yyyy-MM-dd HH:mm:ss format.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;caller&quot;:&quot;18767****&quot;,&quot;startDate&quot;:&quot;&quot;,&quot;stateDesc&quot;:&quot;502&quot;,&quot;duration&quot;:0,&quot;callerShowNumber&quot;:&quot;05344****&quot;,&quot;gmtCreate&quot;:&quot;2017-11-27 20:09:06&quot;,&quot;state&quot;:&quot;502&quot;,&quot;endDate&quot;:&quot;&quot;,&quot;calleeShowNumber&quot;:&quot;053447****&quot;,&quot;bRingTime&quot;:&quot;2022-01-01 12:02:00&quot;，&quot;bEndTime&quot;:&quot;2022-01-01 12:02:28&quot;，&quot;callee&quot;:&quot;1373546****&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A90E4451-FED7-49D2-87C8-00700A8C4D0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
