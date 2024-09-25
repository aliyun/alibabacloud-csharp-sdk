// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddMockRuleRequest : TeaModel {
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

        /// <summary>
        /// <para>The ID of the custom application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;appName\&quot;:\&quot;provide\&quot;,\&quot;appId\&quot;:\&quot;bst8l6o735@f6d8aaf6e56e67d\&quot;}]</para>
        /// </summary>
        [NameInMap("ConsumerAppIds")]
        [Validation(Required=false)]
        public string ConsumerAppIds { get; set; }

        /// <summary>
        /// <para>The items in the recycle bin.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("DubboMockItems")]
        [Validation(Required=false)]
        public string DubboMockItems { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the alert rule.</description></item>
        /// <item><description><c>false</c>: disables the alert rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtraJson")]
        [Validation(Required=false)]
        public string ExtraJson { get; set; }

        /// <summary>
        /// <para>The response time (RT) threshold of slow calls. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>\- 15: 15 ms</description></item>
        /// <item><description>\- 30: 30 ms</description></item>
        /// <item><description>\- 60: 60 ms</description></item>
        /// <item><description>\- 120: 120 ms</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MockType")]
        [Validation(Required=false)]
        public long? MockType { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-auto-test-sc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the service provider application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcqtkuhnc4@66e5235415****</para>
        /// </summary>
        [NameInMap("ProviderAppId")]
        [Validation(Required=false)]
        public string ProviderAppId { get; set; }

        /// <summary>
        /// <para>The name of the service provider application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-cartservice</para>
        /// </summary>
        [NameInMap("ProviderAppName")]
        [Validation(Required=false)]
        public string ProviderAppName { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The input parameters. The JSON format is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ScMockItems")]
        [Validation(Required=false)]
        public string ScMockItems { get; set; }

        /// <summary>
        /// <para>The rule source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edasmsc</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
