// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeAckOperatorResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6615EE8D-FD9D-4FD3-997E-6FEA5B8D82ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAckOperatorResponseBodyResult Result { get; set; }
        public class DescribeAckOperatorResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The Operator installation status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>deployed: installed</description></item>
            /// <item><description>not-deploy: not installed</description></item>
            /// <item><description>failed: installation failed</description></item>
            /// <item><description>unknown: unknown status.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>deployed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The Operator version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
