// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class RemoveEntriesFromAclResponseBody : TeaModel {
        /// <summary>
        /// <para>The asynchronous task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72dcd26b-f12d-4c27-b3af-18f6aed5****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
