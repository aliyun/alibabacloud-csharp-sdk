// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateMediaConvertTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED-1Bz8z71k5TtsUejT4UJ16Es****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA995EFD-083D-4F40-BE8A-BDF75FFFE0B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MediaConvert-adb1ee28-c4c9-42a7-9f54-3b8eadcb****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
