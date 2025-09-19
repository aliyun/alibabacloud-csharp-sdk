// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeOperationLogMonitoringResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeOperationLogMonitoringResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeOperationLogMonitoringResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Time axis slice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-19</para>
            /// </summary>
            [NameInMap("dateGrouped")]
            [Validation(Required=false)]
            public string DateGrouped { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

    }

}
