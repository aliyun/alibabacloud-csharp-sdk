// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class GetAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>Status message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6159ba01-6687-4fb2-a831-f0cd8d188648</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Start timestamp, in Unix time, measured in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751513144838</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Agent status. Valid values: 0 (not started), 1 (starting), 2 (running), 3 (stopping), 4 (stopped), or 5 (failed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>End timestamp, in Unix time, measured in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751513144838</para>
        /// </summary>
        [NameInMap("StopTime")]
        [Validation(Required=false)]
        public string StopTime { get; set; }

    }

}
