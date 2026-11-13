// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateWorkbenchEventResultRequest : TeaModel {
        /// <summary>
        /// <para>The callback result. A value of OK indicates that the check is successful. A value of FAIL indicates that the check fails.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FAIL</para>
        /// </summary>
        [NameInMap("CheckResult")]
        [Validation(Required=false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// <para>The reason for the check failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL is too long</para>
        /// </summary>
        [NameInMap("CheckResultTip")]
        [Validation(Required=false)]
        public string CheckResultTip { get; set; }

        /// <summary>
        /// <para>The code of the extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58e95e2acd6f408e8707f1bf2591f9e9</para>
        /// </summary>
        [NameInMap("ExtensionCode")]
        [Validation(Required=false)]
        public string ExtensionCode { get; set; }

        /// <summary>
        /// <para>The message ID. You can obtain the MessageId only from the OpenEvent extension point event message generated when a process in the Operation Center is blocked by an extension. The ExtensionCode must be the code of an extension that is registered in the DataWorks console and is handling the process. You can use ListExtensions and ListCheckProcesses only to query existing configurations or processes. These operations cannot create valid events.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03400b03-b721-4c34-8727-2****1</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
