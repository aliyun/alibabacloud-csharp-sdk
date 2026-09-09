// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateIDEEventResultRequest : TeaModel {
        /// <summary>
        /// <para>The check status of the extension for this extension point event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The extension check for this extension point event passed.</description></item>
        /// <item><description>FAIL: The extension check for this extension point event failed. View and resolve the error promptly to avoid affecting the normal execution of subsequent programs.</description></item>
        /// <item><description>WARN: The extension check for this extension point event passed, but warnings exist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// <para>The summary of the check performed by the extension on this extension point event.
        /// This information is displayed on your current development page. If the check has warnings or fails, you can use this summary to quickly identify the cause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("CheckResultTip")]
        [Validation(Required=false)]
        public string CheckResultTip { get; set; }

        /// <summary>
        /// <para>The unique identifier of the extension.
        /// You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and view the identifier on the Extensions tab of the Open Platform page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// <para>The message ID of the DataWorks open message. After an extension point event is triggered, you can obtain the message ID from the received event message.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;For more information about the message format, see <a href="https://help.aliyun.com/document_detail/215367.html">Message format</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
