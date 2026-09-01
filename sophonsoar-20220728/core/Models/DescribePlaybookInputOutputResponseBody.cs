// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookInputOutputResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration information.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribePlaybookInputOutputResponseBodyConfig Config { get; set; }
        public class DescribePlaybookInputOutputResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The execution method of the playbook. The value is in the JSONObject format.</para>
            /// </summary>
            [NameInMap("ExeConfig")]
            [Validation(Required=false)]
            public string ExeConfig { get; set; }

            /// <summary>
            /// <para>The input parameter configurations of the playbook. The value is in the JSONArray format.</para>
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

            /// <summary>
            /// <para>Playbooks do not support output parameter configurations. This parameter is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("OutputParams")]
            [Validation(Required=false)]
            public string OutputParams { get; set; }

            /// <summary>
            /// <para>The type of the input parameters for the playbook.</para>
            /// <list type="bullet">
            /// <item><description><para><b>template-ip</b>: IP request template.</para>
            /// </description></item>
            /// <item><description><para><b>template-file</b>: file request template.</para>
            /// </description></item>
            /// <item><description><para><b>template-process</b>: process request template.</para>
            /// </description></item>
            /// <item><description><para><b>custom</b>: custom parameters.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            /// <summary>
            /// <para>The UUID of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9030076b-6733-4842-b05a-xxxxxx</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates this unique ID for each request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>688B4CCD-5272-5DCF-9D76-FE5EFEF545F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
