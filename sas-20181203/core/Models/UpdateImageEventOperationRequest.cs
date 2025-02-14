// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateImageEventOperationRequest : TeaModel {
        /// <summary>
        /// <para>The rule conditions. Specify a value in the JSON format. You can specify the following keys:</para>
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
        /// <para>The ID of the alert handling rule. </para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageEventOperationPage~~">DescribeImageEventOperationPage</a> operation to query the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>814163</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The remarks that you want to add.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>The application scope of the rule. The value is in the JSON format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b></description></item>
        /// <item><description><b>value</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;: \&quot;repo\&quot;, \&quot;value\&quot;: \&quot;test-aaa/shenzhen-repo-01\&quot;}</para>
        /// </summary>
        [NameInMap("Scenarios")]
        [Validation(Required=false)]
        public string Scenarios { get; set; }

        /// <summary>
        /// <para>The source of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b>: image.</description></item>
        /// <item><description><b>agentless</b>: agentless detection.</description></item>
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
