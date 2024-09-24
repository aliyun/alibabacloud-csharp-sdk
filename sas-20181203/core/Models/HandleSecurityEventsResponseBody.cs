// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class HandleSecurityEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The handling result of the alert events.</para>
        /// </summary>
        [NameInMap("HandleSecurityEventsResponse")]
        [Validation(Required=false)]
        public HandleSecurityEventsResponseBodyHandleSecurityEventsResponse HandleSecurityEventsResponse { get; set; }
        public class HandleSecurityEventsResponseBodyHandleSecurityEventsResponse : TeaModel {
            /// <summary>
            /// <para>The ID of the task to handle the alert events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15411</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FF0020B9-999F-5DE2-985F-DB282BDA5311</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
