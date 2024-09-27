// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class GetConnectionTicketResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2afbad19-778a-4fc5-9674-1f19c63862da</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskMessage")]
        [Validation(Required=false)]
        public string TaskMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>W0VuY29kaW5nXQ0KSW5wdXRFbmNvZGluZz1V********</para>
        /// </summary>
        [NameInMap("Ticket")]
        [Validation(Required=false)]
        public string Ticket { get; set; }

    }

}
