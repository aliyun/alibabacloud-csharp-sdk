// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ApplyTagPoliciesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>h5pohqu3gd@xxx</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        [Obsolete]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The Microservices Engine (MSE) namespace to which the application belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Optional. The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12233****</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The details of the routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;blue&quot;: { # Tag key. &quot;rate&quot;: 20, # Rate. A value of 20 indicates that 20% of the traffic is routed to the node identified by the tag. &quot;name&quot;: &quot;luoye-route-test&quot;, # Routing rule name. &quot;carryData&quot;: false, # Specifies whether to enable pass-through. This parameter is applicable to end-to-end canary release. &quot;rules&quot;: { # Rule information. &quot;dubbo&quot;: [{ # Dubbo rule. The system also supports Spring Cloud and Istio rule. &quot;serviceName&quot;: &quot;com.taobao.hsf.common.DemoService&quot;, # Service name (operation name). &quot;group&quot;: &quot;&quot;, # Group name. &quot;version&quot;: &quot;&quot;, # Service version. &quot;methodName&quot;: &quot;sayHello&quot;, # Method name. &quot;condition&quot;: &quot;AND&quot;, # Logical operator used by the following items. Valid values: AND and OR. &quot;argumentItems&quot;: [{ # Array of rule details. &quot;index&quot;: 0, # Index field. &quot;expr&quot;: &quot;&quot;, # Expression. Its details is described below. &quot;operator&quot;: &quot;rawvalue&quot;, # The comparison mode. A value of rawvalue indicates direct comparison. A value of mode indicates the modulo operation. A value of list indicates using a whitelist. &quot;value&quot;: &quot;jim&quot;, # Base value. The value obtained by the expression will be compared with this value. If operator is set to list, separate the items specified for this parameter with commas (,). Example: 1,2,3. &quot;cond&quot;: &quot;==&quot; # Comparison operator. Valid values: &gt;=, &lt;=, &gt;, &lt;, and ==. }] }] } }, &quot;_base&quot;: { # Another tag key. &quot;rate&quot;: 80 # Rate. A value of 20 indicates that 20% of the traffic is routed to the node identified by the tag. } }</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string RulesShrink { get; set; }

    }

}
