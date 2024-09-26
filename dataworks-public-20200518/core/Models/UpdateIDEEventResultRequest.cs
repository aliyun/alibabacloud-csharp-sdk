// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateIDEEventResultRequest : TeaModel {
        /// <summary>
        /// <para>The check status of the extension point event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The event passes the check.</description></item>
        /// <item><description>FAIL: The event fails to pass the check. You must check and handle the reported error at the earliest opportunity to ensure that your program is run as expected.</description></item>
        /// <item><description>WARN: The event passes the check, but an alert is reported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// <para>The summary information of the check result. The information is displayed in DataStudio. If an alert is reported or the event fails the check, you can troubleshoot errors based on the information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("CheckResultTip")]
        [Validation(Required=false)]
        public string CheckResultTip { get; set; }

        /// <summary>
        /// <para>The unique identifier of the extension. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Extensions tab of the Open Platform page to view the identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// <para>The message ID. You can obtain the ID from a received message when an extension point event is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
