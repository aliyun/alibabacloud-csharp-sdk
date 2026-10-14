// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateSchedulerRuleRequest : TeaModel {
        /// <summary>
        /// <para>The details of the CDN interaction rule. This parameter is a JSON format character string. The following list describes the structure:</para>
        /// <list type="bullet">
        /// <item><description><b>ParamType</b>: Required. String type. The type of CDN interaction. Valid values: <b>cdn</b>, which indicates CDN interaction.</description></item>
        /// <item><description><b>ParamData</b>: Required. Map type. The CDN interaction parameters. The following list describes the structure:<list type="bullet">
        /// <item><description><b>Domain</b>: Required. String type. The CDN-accelerated domain name.</description></item>
        /// <item><description><b>Cname</b>: Required. String type. The CNAME of the accelerated domain name.</description></item>
        /// <item><description><b>AccessQps</b>: Required. Integer type. The access QPS threshold. If the QPS exceeds this threshold, traffic is switched to Anti-DDoS Pro and Anti-DDoS Premium.</description></item>
        /// <item><description><b>UpstreamQps</b>: Optional. Integer type. The back-to-origin QPS threshold. If the QPS is lower than this threshold, traffic is switched to CDN.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ParamType&quot;:&quot;cdn&quot;,&quot;ParamData&quot;:{&quot;Domain&quot;:&quot;example.aliyundoc.com&quot;,&quot;Cname&quot;:&quot;demo.aliyundoc.com&quot;,&quot;AccessQps&quot;:100,&quot;UpstreamQps&quot;:100}}</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Pro or Anti-DDoS Premium instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: tiered protection</description></item>
        /// <item><description><b>3</b>: acceleration for China-to-global traffic</description></item>
        /// <item><description><b>5</b>: CDN interaction</description></item>
        /// <item><description><b>6</b>: cloud service interaction</description></item>
        /// <item><description><b>8</b>: secure acceleration</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The details of the general interaction rule. This parameter is a JSON string that consists of the following characters. The following list describes the structure:</para>
        /// <list type="bullet">
        /// <item><description><b>Type</b>: String type. Required. The format of the Resource for Interaction address. Valid values:<list type="bullet">
        /// <item><description><b>A</b>: IP address</description></item>
        /// <item><description><b>CNAME</b>: domain name</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>Value</b>: String type. Required. The address of the Resource for Interaction.</description></item>
        /// <item><description><b>Priority</b>: Integer type. Required. The priority of the rule. Valid values: <b>0</b> to <b>100</b>. A larger value indicates a higher priority.</description></item>
        /// <item><description><b>ValueType</b>: Integer type. Required. The type of the Resource for Interaction. Valid values:<list type="bullet">
        /// <item><description><b>1</b>: IP Address of Anti-DDoS Proxy instance </description></item>
        /// <item><description><b>2</b>: (Tiered protection) IP addresses of cloud resources</description></item>
        /// <item><description><b>3</b>: (Sec-acceleration for China-to-global traffic) acceleration line IP address</description></item>
        /// <item><description><b>5</b>: (CDN interaction) acceleration domain name</description></item>
        /// <item><description><b>6</b>: (Cloud service interaction) IP addresses of cloud resources</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><b>RegionId</b>: String type. Optional (required when <b>ValueType</b> is <b>2</b>). The region ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Type&quot;:&quot;A&quot;, &quot;Value&quot;:&quot;1.1.XX.XX&quot;, &quot;Priority&quot;:80,&quot;ValueType&quot;:2, &quot;RegionId&quot;:&quot;cn-hangzhou&quot; },{&quot;Type&quot;:&quot;A&quot;, &quot;Value&quot;:&quot;203.199.XX.XX&quot;, &quot;Priority&quot;:80,&quot;ValueType&quot;:1}]</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
