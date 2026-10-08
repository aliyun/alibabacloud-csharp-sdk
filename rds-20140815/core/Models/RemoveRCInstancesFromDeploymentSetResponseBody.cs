// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RemoveRCInstancesFromDeploymentSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C816A4BF-A6EC-4722-95F9-2055859CCFD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The call results of the operation.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<RemoveRCInstancesFromDeploymentSetResponseBodyResults> Results { get; set; }
        public class RemoveRCInstancesFromDeploymentSetResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-w9htiydssds</para>
            /// </summary>
            [NameInMap("RCInstanceId")]
            [Validation(Required=false)]
            public string RCInstanceId { get; set; }

            /// <summary>
            /// <para>The node status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Success</b>: Succeeded.</description></item>
            /// <item><description><b>Failed</b>: Failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
