// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CallbackExtensionRequest : TeaModel {
        /// <summary>
        /// <para>The reason for the failure when CheckResult is set to FAIL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The xxx rule is hit. Modify it and try again.</para>
        /// </summary>
        [NameInMap("CheckMessage")]
        [Validation(Required=false)]
        public string CheckMessage { get; set; }

        /// <summary>
        /// <para>The check status of the extension for the current extension point event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The extension passes the check for the current extension point event.</description></item>
        /// <item><description>FAIL: The extension fails the check for the current extension point event. You must check and handle the error promptly to avoid affecting the normal execution of subsequent programs.</description></item>
        /// <item><description>WARN: The extension passes the check for the current extension point event, but a warning is generated.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAIL</para>
        /// </summary>
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// <para>The unique code of the extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2****</para>
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// <para>The message ID of the DataWorks open message. After an extension point event is triggered, you can obtain the message ID from the received event message. &lt;props=&quot;china&quot;&gt;For the message format, refer to <a href="https://help.aliyun.com/document_detail/215367.html">Message format</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>034********091</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
