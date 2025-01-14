// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetTaskInstanceLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The run log of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is running log</para>
        /// </summary>
        [NameInMap("TaskInstanceLog")]
        [Validation(Required=false)]
        public string TaskInstanceLog { get; set; }

    }

}
