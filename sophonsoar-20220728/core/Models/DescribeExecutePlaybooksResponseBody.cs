// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeExecutePlaybooksResponseBody : TeaModel {
        /// <summary>
        /// <para>The playbook.</para>
        /// </summary>
        [NameInMap("PlaybookMetrics")]
        [Validation(Required=false)]
        public List<DescribeExecutePlaybooksResponseBodyPlaybookMetrics> PlaybookMetrics { get; set; }
        public class DescribeExecutePlaybooksResponseBodyPlaybookMetrics : TeaModel {
            /// <summary>
            /// <para>The playbook description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a demo playbook</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The playbook name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_playbook</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The configuration of the input parameter. The value is a JSON array.</para>
            /// <remarks>
            /// <para> For more information, see <a href="~~DescribePlaybookInputOutput~~">DescribePlaybookInputOutput</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;typeName&quot;: &quot;String&quot;,
            ///         &quot;dataClass&quot;: &quot;normal&quot;,
            ///         &quot;dataType&quot;: &quot;String&quot;,
            ///         &quot;description&quot;: &quot;period&quot;,
            ///         &quot;example&quot;: &quot;&quot;,
            ///         &quot;name&quot;: &quot;period&quot;,
            ///         &quot;required&quot;: false
            ///     }
            /// ]</para>
            /// </summary>
            [NameInMap("ParamConfig")]
            [Validation(Required=false)]
            public string ParamConfig { get; set; }

            /// <summary>
            /// <para>The input parameter type of the playbook.</para>
            /// <list type="bullet">
            /// <item><description><b>template-ip</b></description></item>
            /// <item><description><b>template-file</b></description></item>
            /// <item><description><b>template-process</b></description></item>
            /// <item><description><b>custom</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// <para>The playbook UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c5c88b5e-97ca-435d-8c20-2xxxxx</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88A39217-2802-5B1E-BA2B-CF1BBC43C1F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
