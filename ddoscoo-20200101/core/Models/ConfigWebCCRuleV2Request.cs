// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigWebCCRuleV2Request : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Expires")]
        [Validation(Required=false)]
        public long? Expires { get; set; }

        /// <summary>
        /// <para>The frequency control rule. This parameter is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>action</b>: the action that is performed if the rule is matched. This field is required and must be of the string type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b>: The requests that match the rule are blocked.</description></item>
        /// <item><description><b>challenge</b>: Completely Automated Public Turing test to tell Computers and Humans Apart (CAPTCHA) verification for the requests that match the rule is implemented.</description></item>
        /// <item><description><b>watch</b>: The requests that match the rule are recorded in logs and allowed.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>name</b>: the name of the rule. This field is required and must be of the string type.</para>
        /// </description></item>
        /// <item><description><para><b>condition</b>: the match conditions. This field is required and must be of the map type. This field contains the following parameters:</para>
        /// <para>**</para>
        /// <para><b>Note</b> The AND logical operator is used to evaluate multiple match conditions.</para>
        /// <list type="bullet">
        /// <item><description><para><b>field</b>: the match field. This field is required and must be of the string type.</para>
        /// </description></item>
        /// <item><description><para><b>match_method</b>: the logical relation. This field is required and must be of the string type.</para>
        /// <para>**</para>
        /// <para><b>Note</b> For information about the mappings between the <b>field</b> and <b>match_method</b> parameters, see the &quot;Mappings between the field and match_method parameters&quot; section of this topic.</para>
        /// </description></item>
        /// <item><description><para><b>header_name</b>: the name of the custom HTTP header. This field is optional and must be of the string type.</para>
        /// <para>**</para>
        /// <para><b>Note</b> This field is required only when <b>field</b> is set to <b>header</b>.</para>
        /// </description></item>
        /// <item><description><para><b>content</b>: the match content. This field is required and must be of the string type.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>ratelimit</b>: the frequency control field. This field is optional and must be of the string type. The frequency can be measured based on IP addresses or custom headers. This field contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>interval</b>: the statistical duration. Unit: seconds. This field is required and must be of the integer type.</description></item>
        /// <item><description><b>ttl</b>: the period during which the specified action is performed. Unit: seconds. This field is required and must be of the integer type.</description></item>
        /// <item><description><b>threshold</b>: the threshold. This field is required and must be of the integer type.</description></item>
        /// <item><description><b>subkey</b>: the name of the field. This field is optional and must be of the string type. This field is required only when target is set to header.</description></item>
        /// <item><description><b>target</b>: the statistical source. This field is required and must be of the string type. Valid values: ip and header.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>status_code</b>: the frequency control field. This field is optional and must be of the string type. Frequency control can be performed based on the quantity or percentage of status codes. This field contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: specifies whether to enable status code statistics. This field is required and must be of the Boolean type.</description></item>
        /// <item><description><b>code</b>: the status code. This field is required and must be of the integer type. Valid values: <b>100</b> to <b>599</b>.</description></item>
        /// <item><description><b>use_ratio</b>: specifies whether to use a ratio. This field is required and must be of the Boolean type. To use a ratio, set this field to true.</description></item>
        /// <item><description><b>ratio_threshold</b>: the ratio of the status code. This field is optional and must be of the integer type. If a ratio is used, the action specified in the rule is performed only when the ratio of the status code reaches <b>ratio_threshold</b>. Valid values: <b>1</b> to <b>100</b>.</description></item>
        /// <item><description><b>count_threshold</b>: the quantity of the status code. This field is optional and must be of the integer type. If a ratio is not used, the action specified in the rule is performed only when the quantity of the status code reaches <b>count_threshold</b>. Valid values: <b>2</b> to <b>50000</b>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>statistics</b>: specifies whether deduplication is used for statistics. This field is optional and must be of the string type. By default, deduplication is not used for statistics. This field contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>mode</b>: specifies whether deduplication is used for status code statistics. This field is required and must be of the string type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>count</b>: Deduplication is not used for statistics.</description></item>
        /// <item><description><b>distinct</b>: Deduplication is used for statistics.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>field</b>: the statistical source. This field is required and must be of the string type. Valid values: ip, header, and uri.</para>
        /// </description></item>
        /// <item><description><para><b>header_name</b>: the name of the header. This field is optional and must be of the string type. This field is required only when field is set to header.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;action&quot;:&quot;block&quot;,&quot;name&quot;:&quot;trdsss&quot;,&quot;ratelimit&quot;:{&quot;interval&quot;:60,&quot;ttl&quot;:300,&quot;threshold&quot;:70,&quot;target&quot;:&quot;ip&quot;},&quot;condition&quot;:[{&quot;field&quot;:&quot;ip&quot;,&quot;match_method&quot;:&quot;belong&quot;,&quot;content&quot;:&quot;1.1.1.1&quot;}]}]</para>
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public string RuleList { get; set; }

    }

}
