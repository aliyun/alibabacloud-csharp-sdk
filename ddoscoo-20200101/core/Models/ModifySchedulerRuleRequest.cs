// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifySchedulerRuleRequest : TeaModel {
        /// <summary>
        /// <para>The details of the CDN interaction rule. This parameter is a JSON string. The string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ParamType</b>: the type of the scheduling rule. This field is required and must be of the string type. Set the value to <b>cdn</b>. This indicates that you want to modify a CDN interaction rule.</para>
        /// </description></item>
        /// <item><description><para><b>ParamData</b>: the values of parameters that you want to modify for the CDN interaction rule. This field is required and must be of the map type. The ParamData parameter contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>Domain</b>: the accelerated domain in CDN. This parameter is required and must be of the string type.</description></item>
        /// <item><description><b>Cname</b>: the CNAME that is assigned to the accelerated domain. This parameter is required and must be of the string type.</description></item>
        /// <item><description><b>AccessQps</b>: the queries per second (QPS) threshold that is used to switch service traffic to Anti-DDoS Pro or Anti-DDoS Premium. This parameter is required and must be of the integer type.</description></item>
        /// <item><description><b>UpstreamQps</b>: the QPS threshold that is used to switch service traffic to CDN. This parameter is optional and must be of the integer type.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ParamType&quot;:&quot;cdn&quot;,&quot;ParamData&quot;:&quot;Domain&quot;:&quot;example.aliyundoc.com&quot;,&quot;Cname&quot;:&quot;demo.aliyundoc.com&quot;,&quot;AccessQps&quot;:100,&quot;UpstreamQps&quot;:100}}</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the rule that you want to modify.</para>
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
        /// <item><description><b>2</b>: tiered protection</description></item>
        /// <item><description><b>3</b>: network acceleration</description></item>
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
        /// <para>The details of the scheduling rule. This parameter is a JSON string. The following list describes the fields in the value of the parameter:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Type</b>: the address type of the interaction resource that you want to use in the scheduling rule. This field is required and must be of the string type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>A</b>: IP address</description></item>
        /// <item><description><b>CNAME</b>: domain name</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Value</b>: the address of the interaction resource that you want to use in the scheduling rule. This field is required and must be of the string type.</para>
        /// </description></item>
        /// <item><description><para><b>Priority</b>: the priority of the scheduling rule. This field is required and must be of the integer type. Valid values: <b>0</b> to <b>100</b>. A larger value indicates a higher priority.</para>
        /// </description></item>
        /// <item><description><para><b>ValueType</b>: the type of the interaction resource that you want to use in the scheduling rule. This field is required and must be of the integer type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: the IP address of the Anti-DDoS Pro or Anti-DDoS Premium instance</description></item>
        /// <item><description><b>2</b>: the IP address of the interaction resource in the tiered protection scenario</description></item>
        /// <item><description><b>3</b>: the IP address that is used to accelerate access in the network acceleration scenario</description></item>
        /// <item><description><b>5</b>: the domain name that is configured in Alibaba Cloud CDN (CDN) in the CDN interaction scenario</description></item>
        /// <item><description><b>6</b> the IP address of the interaction resource in the cloud service interaction scenario</description></item>
        /// <item><description><b>8</b>: the IP address of the Secure Chinese Mainland Acceleration (Sec-CMA) instance in the secure acceleration scenario</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>RegionId</b>: the region where the interaction resource is deployed. This parameter must be specified when <b>ValueType</b> is set to <b>2</b>. The value must be of the string type.</para>
        /// </description></item>
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
