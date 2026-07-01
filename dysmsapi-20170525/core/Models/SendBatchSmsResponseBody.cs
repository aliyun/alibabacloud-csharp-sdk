// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchSmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The delivery receipt ID.</para>
        /// <list type="bullet">
        /// <item><description><para>You can use this ID to query the delivery status by calling the <a href="https://help.aliyun.com/document_detail/102352.html">QuerySendDetails</a> operation.</para>
        /// </description></item>
        /// <item><description><para>Log on to the <a href="https://dysms.console.aliyun.com/dysms.htm#/overview">Short Message Service console</a> and go to <b>Statistics</b> &gt; <b>Delivery Logs</b> to view delivery details.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9006197469364984400</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of <c>OK</c> indicates a successful request.</para>
        /// </description></item>
        /// <item><description><para>For a list of other error codes, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</para>
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
        /// <para>The description of the request status.</para>
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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8D230E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
