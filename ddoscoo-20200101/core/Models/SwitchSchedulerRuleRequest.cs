// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class SwitchSchedulerRuleRequest : TeaModel {
        /// <summary>
        /// <para>The name of the scheduling rule to manage.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/157481.html">DescribeSchedulerRules</a> operation to query the names of all scheduling rules.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The type of the scheduling rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: tiered protection rule</description></item>
        /// <item><description><b>3</b>: network acceleration rule</description></item>
        /// <item><description><b>5</b>: Alibaba Cloud CDN (CDN) interaction rule</description></item>
        /// <item><description><b>6</b>: cloud service interaction rule</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The configuration that is used to switch service traffic. This parameter is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Value</b>: required. The IP address of the associated resource. Data type: string.</para>
        /// </description></item>
        /// <item><description><para><b>State</b>: required. The operation type. Data type: integer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: switches service traffic from the associated resource to your Anti-DDoS Pro or Anti-DDoS Premium instance for scrubbing.</description></item>
        /// <item><description><b>1</b>: switches service traffic back to the associated cloud resource.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Interval</b>: optional. The waiting time that is required before the service traffic is switched back. Unit: minutes. Data type: integer. Usage notes:</para>
        /// <list type="bullet">
        /// <item><description>If the <b>State</b> parameter is set to <b>0</b>, you must set this parameter to \<em>\</em>-1\<em>\</em>. Otherwise, the call fails.</description></item>
        /// <item><description>If the <b>State</b> parameter is set to <b>1</b>, you do not need to set this parameter.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Value&quot;:&quot;39.104.XX.XX&quot;,&quot;State&quot;:0,&quot;Interval&quot;:-1}]</para>
        /// </summary>
        [NameInMap("SwitchData")]
        [Validation(Required=false)]
        public string SwitchData { get; set; }

    }

}
