// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class GetEgressProxyConfigurationAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time of the egress proxy configuration. The time is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-02T02:20:24Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The default actions executed in each effective phase (PreDns, PreRequest, and PostResponse) when traffic does not match any rules.</para>
        /// </summary>
        [NameInMap("DefaultRulePhaseActions")]
        [Validation(Required=false)]
        public GetEgressProxyConfigurationAttributeResponseBodyDefaultRulePhaseActions DefaultRulePhaseActions { get; set; }
        public class GetEgressProxyConfigurationAttributeResponseBodyDefaultRulePhaseActions : TeaModel {
            /// <summary>
            /// <para>The default action executed in the PostResponse phase (after a response is returned) when traffic does not match any rules. This phase only supports the value <b>Allow</b> (default), which indicates that the traffic is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PostResponse")]
            [Validation(Required=false)]
            public string PostResponse { get; set; }

            /// <summary>
            /// <para>The default action executed in the PreDns phase (before DNS resolution) when traffic does not match any rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Allow</b> (default): allows the traffic.</para>
            /// </description></item>
            /// <item><description><para><b>Deny</b>: denies the traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PreDns")]
            [Validation(Required=false)]
            public string PreDns { get; set; }

            /// <summary>
            /// <para>The default action executed in the PreRequest phase (before a request is forwarded) when traffic does not match any rules. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Allow</b> (default): allows the traffic.</para>
            /// </description></item>
            /// <item><description><para><b>Deny</b>: denies the traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Allow</para>
            /// </summary>
            [NameInMap("PreRequest")]
            [Validation(Required=false)]
            public string PreRequest { get; set; }

        }

        /// <summary>
        /// <para>The description of the egress proxy configuration. The description must be 2 to 256 characters in length and can contain Chinese characters, letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the egress proxy configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epc-uf609a6a8fdf9f4d****</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationId")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationId { get; set; }

        /// <summary>
        /// <para>The name of the egress proxy configuration. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationName")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C79118A9-CA6D-5359-B53E-111BE8A03DCF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzorljcazp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of egress rule group references associated with the egress proxy configuration.</para>
        /// </summary>
        [NameInMap("RuleGroups")]
        [Validation(Required=false)]
        public List<GetEgressProxyConfigurationAttributeResponseBodyRuleGroups> RuleGroups { get; set; }
        public class GetEgressProxyConfigurationAttributeResponseBodyRuleGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the egress rule group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eprg-uf60966a9633667c****</para>
            /// </summary>
            [NameInMap("EgressProxyRuleGroupId")]
            [Validation(Required=false)]
            public string EgressProxyRuleGroupId { get; set; }

            /// <summary>
            /// <para>The priority of the egress rule group in the egress proxy configuration. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The status of the egress proxy configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Provisioning</b>: The configuration is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Available</b>: The configuration is available.</para>
        /// </description></item>
        /// <item><description><para><b>Configuring</b>: The configuration is being modified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetEgressProxyConfigurationAttributeResponseBodyTags> Tags { get; set; }
        public class GetEgressProxyConfigurationAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
