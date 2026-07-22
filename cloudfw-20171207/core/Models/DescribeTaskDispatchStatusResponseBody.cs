// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeTaskDispatchStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71209DFE-XXX-XXX-52B4A4E9DA3B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PENDING: pending execution.</description></item>
        /// <item><description>RUNNING: running.</description></item>
        /// <item><description>SUCCESS: succeeded.</description></item>
        /// <item><description>FAILED: failed.</description></item>
        /// <item><description>CANCELLED: cancelled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
