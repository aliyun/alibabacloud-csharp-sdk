// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateImageEventOperationRequest : TeaModel {
        /// <summary>
        /// <para>The rule conditions. The value is in JSON format. The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>condition</b>: the matching condition.</description></item>
        /// <item><description><b>type</b>: the matching type.</description></item>
        /// <item><description><b>value</b>: the matching value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;condition\&quot;: \&quot;MD5\&quot;, \&quot;type\&quot;: \&quot;equals\&quot;, \&quot;value\&quot;: \&quot;0083a31cc0083a31ccf7c10367a6e****\&quot;}]</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>The ID of the alert handling rule.</para>
        /// <remarks>
        /// <para>You can call <a href="~~DescribeImageEventOperationPage~~">DescribeImageEventOperationPage</a> to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>814163</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The remarks to add.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The rule scope. The value is in JSON format. The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b>: the scope type.</description></item>
        /// <item><description><b>value</b>: the scope value.<remarks>
        /// <para>This parameter and Source cannot both be empty. If Source is set to agentless, this parameter does not take effect.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;: \&quot;repo\&quot;, \&quot;value\&quot;: \&quot;test-aaa/shenzhen-repo-01\&quot;}</para>
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public string Scenarios { get; set; }

        /// <summary>
        /// <para>The whitelist source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b>: image.</description></item>
        /// <item><description><b>agentless</b>: agentless detection.<remarks>
        /// <para>This parameter and Scenarios cannot both be empty. If this parameter is set to agentless, the Scenarios parameter does not take effect.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
