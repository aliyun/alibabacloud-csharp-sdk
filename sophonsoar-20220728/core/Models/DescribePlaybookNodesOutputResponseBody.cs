// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookNodesOutputResponseBody : TeaModel {
        /// <summary>
        /// <para>The output data of the component node.</para>
        /// </summary>
        [NameInMap("PlaybookNodesOutput")]
        [Validation(Required=false)]
        public DescribePlaybookNodesOutputResponseBodyPlaybookNodesOutput PlaybookNodesOutput { get; set; }
        public class DescribePlaybookNodesOutputResponseBodyPlaybookNodesOutput : TeaModel {
            /// <summary>
            /// <para>The name of the component node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataFormat_1</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The historical output data of the component node. The value is in the JSON string format. If no data is found, the parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;datalist&quot;: [
            ///         {
            ///             &quot;score&quot;: &quot;10&quot;,
            ///             &quot;ip&quot;: &quot;1.1.1.1&quot;
            ///         }
            ///     ],
            ///     &quot;total_data_successful&quot;: 1,
            ///     &quot;filter_total_data&quot;: 1,
            ///     &quot;total_data&quot;: 1,
            ///     &quot;total_exe_successful&quot;: 1,
            ///     &quot;total_exe&quot;: 1,
            ///     &quot;total_data_with_dup&quot;: 1,
            ///     &quot;filter_total_data_successful&quot;: 1,
            ///     &quot;status&quot;: true
            /// }</para>
            /// </summary>
            [NameInMap("NodeOutput")]
            [Validation(Required=false)]
            public string NodeOutput { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A491170C-FE1F-520E-83D4-72ED205B72ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
