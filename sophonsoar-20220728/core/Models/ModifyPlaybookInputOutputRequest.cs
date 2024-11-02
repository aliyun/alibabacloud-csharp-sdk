// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class ModifyPlaybookInputOutputRequest : TeaModel {
        /// <summary>
        /// <para>The executed mode of a playbook. The value is a JSON array.</para>
        /// </summary>
        [NameInMap("ExeConfig")]
        [Validation(Required=false)]
        public string ExeConfig { get; set; }

        /// <summary>
        /// <para>The configuration of the input parameters. The value is a JSON array.</para>
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
        /// <para>The language of the content within the request and response.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The configuration of the output parameters. This parameter is unavailable. Leave it empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("OutputParams")]
        [Validation(Required=false)]
        public string OutputParams { get; set; }

        /// <summary>
        /// <para>The input parameter type.</para>
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
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a>operation to query the playbook UUID.</para>
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
