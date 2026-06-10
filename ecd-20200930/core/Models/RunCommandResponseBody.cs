// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RunCommandResponseBody : TeaModel {
        /// <summary>
        /// <para>The script execution ID. You can use this ID with the <a href="~~DescribeInvocations~~">DescribeInvocations</a> operation to query the script\&quot;s execution status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-hz01qgsqj2n****</para>
        /// </summary>
        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
