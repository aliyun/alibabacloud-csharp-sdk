// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateOperationEventScheduleTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>Returns <c>true</c> if the scheduled time is successfully updated, or <c>false</c> otherwise.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public bool? Data { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11F64C4C-EC50-5472-BC5D-7FD9F51499F6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
