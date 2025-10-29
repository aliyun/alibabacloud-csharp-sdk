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
        /// <item><description>OK: The extension passed the check for this event.</description></item>
        /// <item><description>FAIL: The extension failed the check for this event. You need to review and resolve the error promptly to avoid affecting subsequent program execution.</description></item>
        /// <item><description>WARN: The extension passed the check for this event, but with warnings.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// <para>A summary of the check result for this extension point event. This message is displayed on your current development page. When the check fails or has warnings, you can use this summary to quickly identify the cause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("CheckResultTip")]
        [Validation(Required=false)]
        public string CheckResultTip { get; set; }

        /// <summary>
        /// <para>The unique identifier of the extension. You can obtain the identifier from the Extensions tab on Open Platform in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// <para>The OpenEvent message ID from DataWorks. When an extension point event is triggered, you can obtain the message ID from the event message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
