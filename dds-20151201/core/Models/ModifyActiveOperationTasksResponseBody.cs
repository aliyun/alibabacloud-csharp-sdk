// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyActiveOperationTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the O\&amp;M tasks. Multiple task IDs are separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111,22222</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAAE9DDA-65FD-584C-A378-F1F24676****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
