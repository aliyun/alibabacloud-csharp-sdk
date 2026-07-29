// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetConnectionTicketResponseBody : TeaModel {
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        [NameInMap("P2PToken")]
        [Validation(Required=false)]
        public string P2PToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ticket used to connect to the user instance. Before you use the ticket, decode its content from Base64, save it as an .ica file, and then open the file. The following code provides a Python example:</para>
        /// <pre><c>import base64
        /// response = {
        ///     &quot;Ticket&quot;: &quot;W0VuY29kaW5nXQ0KSW5wdXRFbmNvZGluZz1V********&quot;,
        ///     &quot;RequestId&quot;: &quot;1CBAFFAB-B697-4049-A9B1-67E1FC5F****&quot;,
        /// }
        /// f = open (\\&quot;xxx.ica\\&quot;, \\&quot;w\\&quot;)
        /// out = base64.b64decode(response[\\&quot;Ticket\\&quot;])
        /// f.write(out)
        /// f.close()
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>W0VuY29kaW5nXQ0KSW5wdXRFbmNvZGluZz1V********</para>
        /// </summary>
        [NameInMap("TaskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer connection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2afbad19-778a-4fc5-9674-1f19c63862da</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer connection task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2afbad19-778a-4fc5-9674-1f19c638****</para>
        /// </summary>
        [NameInMap("TaskMessage")]
        [Validation(Required=false)]
        public string TaskMessage { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The connection ticket for the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>W0VuY29kaW5nXQ0KSW5wdXRFbmNvZGluZz1V********</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
