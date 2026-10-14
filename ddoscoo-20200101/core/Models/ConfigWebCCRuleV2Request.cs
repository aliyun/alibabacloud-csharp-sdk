// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigWebCCRuleV2Request : TeaModel {
        /// <summary>
        /// <para>The domain name of the website service.</para>
        /// <remarks>
        /// <para>The domain name must have a website service forwarding rule configured. You can call <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The validity period of the rule. Unit: seconds. Default value: 0, which indicates that the rule is permanently effective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Expires")]
        [Validation(Required=false)]
        public long? Expires { get; set; }

        /// <summary>
        /// <para>The configuration of the frequency control rule, expressed as a JSON-formatted string with the following structure:</para>
        /// <list type="bullet">
        /// <item><description><para><b>action</b>: String type. Required. The matching action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>block</b>: Block.</description></item>
        /// <item><description><b>challenge</b>: JavaScript Challenge.</description></item>
        /// <item><description><b>watch</b>: Monitor.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>name</b>: String type. Required. The rule name.</para>
        /// </description></item>
        /// <item><description><para><b>condition</b>: Map type. Required. The matching condition. The structure is as follows:</para>
        /// <remarks>
        /// <para>If multiple matching conditions are specified, the conditions are evaluated using the AND logic.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>field</b>: String type. Required. The matching field.</para>
        /// </description></item>
        /// <item><description><para><b>match_method</b>: String type. Required. The matching method.</para>
        /// <remarks>
        /// <para>For the valid values of <b>field</b> and <b>match_method</b>, see the supplementary description below the request parameters table.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>header_name</b>: String type. Optional. The name of the custom HTTP header field.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>field</b> is set to <b>header</b>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>content</b>: String type. Required. The matching content.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>ratelimit</b>: String type. Required. The frequency control field. You can collect frequency statistics by IP address or custom header. The structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>interval</b>: Integer type. Required. The statistical period (seconds).</description></item>
        /// <item><description><b>ttl</b>: Integer type. Required. The action duration (seconds).</description></item>
        /// <item><description><b>threshold</b>: Integer type. Required. The threshold (count).</description></item>
        /// <item><description><b>subkey</b>: String type. Optional. The field name. Set this parameter only when the statistical source is header.</description></item>
        /// <item><description><b>target</b>: String type. Required. The statistical source. Valid values: ip and header.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>status_code</b>: String type. Optional. The frequency control field. You can collect statistics based on the count or ratio of status codes. The structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Boolean type. Required. Specifies whether to enable status code statistics.</description></item>
        /// <item><description><b>code</b>: Integer type. Required. Enabling status code. Valid values: <b>100</b> to <b>599</b>.</description></item>
        /// <item><description><b>use_ratio</b>: Boolean type. Required. Specifies whether to use the ratio. If set to true, the ratio is used.</description></item>
        /// <item><description><b>ratio_threshold</b>: Integer type. Optional. The ratio at which enabling status code appears. When the ratio is used, the action is triggered only when the corresponding status code reaches <b>ratio_threshold</b>. Valid values: <b>1</b> to <b>100</b>.</description></item>
        /// <item><description><b>count_threshold</b>: Integer type. Optional. The count at which enabling status code appears. When the ratio is not used, the action is triggered only when the corresponding status code reaches <b>count_threshold</b>. Valid values: <b>2</b> to <b>50000</b>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>statistics</b>: String type. Optional. The deduplication statistics. This parameter can be left empty, which indicates that deduplication is not performed. The structure is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>mode</b>: String type. Required. Specifies whether to enable deduplication statistics. Valid values:<list type="bullet">
        /// <item><description><b>count</b>: deduplication disabled</description></item>
        /// <item><description><b>distinct</b>: deduplication enabled</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>field</b>: String type. Required. The statistical source for deduplication. Valid values: ip, header, and uri.</description></item>
        /// <item><description><b>header_name</b>: String type. Optional. The field name. Set this parameter only when the statistical source is header.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;action&quot;:&quot;block&quot;,&quot;name&quot;:&quot;trdsss&quot;,&quot;statistics&quot;:{&quot;mode&quot;:&quot;count&quot;,&quot;field&quot;:&quot;header&quot;,&quot;header_name&quot;:&quot;hahah&quot;},&quot;ratelimit&quot;:{&quot;interval&quot;:60,&quot;ttl&quot;:300,&quot;threshold&quot;:70,&quot;target&quot;:&quot;ip&quot;},&quot;status_code&quot;:{&quot;enabled&quot;:true,&quot;code&quot;:404,&quot;use_ratio&quot;:true,&quot;ratio_threshold&quot;:80,&quot;count_threshold&quot;:2},&quot;condition&quot;:[{&quot;field&quot;:&quot;ip&quot;,&quot;match_method&quot;:&quot;belong&quot;,&quot;content&quot;:&quot;1.1.1.1&quot;}]}]</para>
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public string RuleList { get; set; }

    }

}
