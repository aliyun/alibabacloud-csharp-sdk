// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class SendBatchSmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the delivery receipt. You can use one of the following methods to query the delivery status of a message based on the ID.</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/102352.html">QuerySendDetails</a> operation.</description></item>
        /// <item><description>Log on to the <a href="https://dysms.console.aliyun.com/dysms.htm#/overview">Alibaba Cloud SMS console</a>. In the left-side navigation pane, choose <b>Analytics</b> &gt; <b>Delivery Report</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9006197469364984400</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>Other values indicate that the request fails. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8D230E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
