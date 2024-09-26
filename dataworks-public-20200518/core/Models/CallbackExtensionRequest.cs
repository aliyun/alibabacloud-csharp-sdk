// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CallbackExtensionRequest : TeaModel {
        /// <summary>
        /// <para>The check message of the extension point event. If CheckResult is set to FAIL, you must provide the failure cause.</para>
        /// </summary>
        [NameInMap("CheckMessage")]
        [Validation(Required=false)]
        public string CheckMessage { get; set; }

        /// <summary>
        /// <para>The check status of the extension point event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The event passes the check.</description></item>
        /// <item><description>FAIL: The event fails to pass the check. You must check and handle the reported error at the earliest opportunity to ensure that your program is run as expected.</description></item>
        /// <item><description>WARN: The event passes the check, but an alert is reported.</description></item>
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
        /// <para>8abcb91f-d266-4073-b907-2ed670378ed1</para>
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// <para>The message ID in DataWorks OpenEvent. You can obtain the ID from a received message when an extension point event is triggered.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03400b03-b721-4c34-8727-2d6884077091</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
