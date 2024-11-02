// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentPlaybookResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the predefined components.</para>
        /// </summary>
        [NameInMap("Playbooks")]
        [Validation(Required=false)]
        public List<DescribeComponentPlaybookResponseBodyPlaybooks> Playbooks { get; set; }
        public class DescribeComponentPlaybookResponseBodyPlaybooks : TeaModel {
            /// <summary>
            /// <para>The description of the predefined component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis_kill_process</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the predefined component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AegisKillQuara</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The input parameter configuration of the playbook. The value is a JSON array.</para>
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
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5F5D6C9-DF1A-5381-92B1-39676F777D20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
