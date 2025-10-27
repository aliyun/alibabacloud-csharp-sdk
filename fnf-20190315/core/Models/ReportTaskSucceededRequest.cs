// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ReportTaskSucceededRequest : TeaModel {
        /// <summary>
        /// <para>The output information of the task whose execution success you want to report.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public string Output { get; set; }

        /// <summary>
        /// <para>The token of the task whose execution you want to report. The task token is passed to the called service, such as Message Service (MNS) or Function Compute. For MNS, the value of this parameter can be obtained from a message. For Function Compute, the value of this parameter can be obtained from an event. For more information, see <a href="https://help.aliyun.com/document_detail/2592915.html">Service integration modes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>emptyString</para>
        /// </summary>
        [NameInMap("TaskToken")]
        [Validation(Required=false)]
        public string TaskToken { get; set; }

    }

}
