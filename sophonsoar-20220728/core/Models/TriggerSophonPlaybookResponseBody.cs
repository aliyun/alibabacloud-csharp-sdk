// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerSophonPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The details that is returned after the command or playbook is triggered.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TriggerSophonPlaybookResponseBodyData Data { get; set; }
        public class TriggerSophonPlaybookResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The custom ID. If you do not specify this parameter when the playbook is triggered, a random ID is generated for fault locating and troubleshooting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7c6d055-a72f-4676-bc89-3cd9edc0284c</para>
            /// </summary>
            [NameInMap("SophonTaskId")]
            [Validation(Required=false)]
            public string SophonTaskId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DFC9403-54EB-5672-B690-9AA93C9EBB54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
