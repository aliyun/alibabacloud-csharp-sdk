// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ModifyPlaybookInputOutputRequest : TeaModel {
        /// <summary>
        /// <para>The execution method for the playbook. This parameter is in the JSONObject format.</para>
        /// </summary>
        [NameInMap("ExeConfig")]
        [Validation(Required=false)]
        public string ExeConfig { get; set; }

        /// <summary>
        /// <para>The input parameter configuration for the playbook. This parameter is in the JSONArray format.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The language of the request and response messages.</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Playbooks do not support output parameter configurations. This parameter is fixed to an empty value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("OutputParams")]
        [Validation(Required=false)]
        public string OutputParams { get; set; }

        /// <summary>
        /// <para>The type of the input parameter for the playbook.</para>
        /// <list type="bullet">
        /// <item><description><para><b>template-ip</b>: IP request template.</para>
        /// </description></item>
        /// <item><description><para><b>template-file</b>: file request template.</para>
        /// </description></item>
        /// <item><description><para><b>template-process</b>: process request template.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: custom parameter.</para>
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
        /// <remarks>
        /// <para>Call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8baa6cff-319e-4ede-97bc-xxxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
