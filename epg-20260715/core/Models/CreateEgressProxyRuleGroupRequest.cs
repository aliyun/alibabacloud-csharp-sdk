// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class CreateEgressProxyRuleGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>Note If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the egress rule group. The description must be 2 to 256 characters in length and can contain Chinese characters, letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: sends a dry run request and does not create the rule group. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the egress IP address pool associated with the egress rule group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eppool-gw80d96a96ca0b00****</para>
        /// </summary>
        [NameInMap("EgressProxyIpPoolId")]
        [Validation(Required=false)]
        public string EgressProxyIpPoolId { get; set; }

        /// <summary>
        /// <para>The name of the egress rule group. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyRuleGroupName")]
        [Validation(Required=false)]
        public string EgressProxyRuleGroupName { get; set; }

        /// <summary>
        /// <para>The list of egress rules grouped by phase (PreDns, PreRequest, and PostResponse).</para>
        /// </summary>
        [NameInMap("EgressProxyRules")]
        [Validation(Required=false)]
        public CreateEgressProxyRuleGroupRequestEgressProxyRules EgressProxyRules { get; set; }
        public class CreateEgressProxyRuleGroupRequestEgressProxyRules : TeaModel {
            /// <summary>
            /// <para>The list of rules in the PostResponse phase (after the response is returned).</para>
            /// </summary>
            [NameInMap("PostResponse")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRuleGroupRequestEgressProxyRulesPostResponse> PostResponse { get; set; }
            public class CreateEgressProxyRuleGroupRequestEgressProxyRulesPostResponse : TeaModel {
                /// <summary>
                /// <para>The action to perform on the matched traffic after the rule is hit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Allow</b>: allows the traffic that matches the rule.</para>
                /// </description></item>
                /// <item><description><para><b>Deny</b>: denies the traffic that matches the rule.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The list of matching conditions for the rule. Each condition consists of a condition key (ConditionKey), an operator (ConditionOperator), and condition values (ConditionValues). The combination of a condition key and an operator must be unique within the same rule.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<CreateEgressProxyRuleGroupRequestEgressProxyRulesPostResponseConditions> Conditions { get; set; }
                public class CreateEgressProxyRuleGroupRequestEgressProxyRulesPostResponseConditions : TeaModel {
                    /// <summary>
                    /// <para>The key of the matching condition. The value must match the phase of the rule and be used with an operator (ConditionOperator) of the corresponding category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>request:SourceIp</b>: the source IP address of the request. Used with IP address operators. Supported in the PreDns and PreRequest phases.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:DestinationDomain</b>: the destination domain name of the request. Used with string operators. Supported in the PreDns and PreRequest phases.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Uri</b>: the URI of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Method</b>: the HTTP request method. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:UserAgent</b>: the User-Agent of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:ContentType</b>: the Content-Type of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Header</b>: the HTTP request header. Used with string operators. Supported in the PreRequest phase. When you use this key, append the header name to the key in the format of request:Http:Header/<HeaderName>.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Protocol</b>: the request protocol. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>request:SourceIp</para>
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// <para>The operator of the matching condition. It must be used with a condition key (ConditionKey). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>StringEquals</b>: exact string match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringNotEquals</b>: string inequality.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringEqualsIgnoreCase</b>: case-insensitive exact string match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringNotEqualsIgnoreCase</b>: case-insensitive string inequality.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixMatch</b>: string prefix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixMatchIgnoreCase</b>: case-insensitive string prefix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixNotMatch</b>: string prefix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixNotMatchIgnoreCase</b>: case-insensitive string prefix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixMatch</b>: string suffix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixMatchIgnoreCase</b>: case-insensitive string suffix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixNotMatch</b>: string suffix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixNotMatchIgnoreCase</b>: case-insensitive string suffix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringRegexMatch</b>: string regular expression match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringRegexNotMatch</b>: string regular expression mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardMatch</b>: string wildcard match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardMatchIgnoreCase</b>: case-insensitive string wildcard match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardNotMatch</b>: string wildcard mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardNotMatchIgnoreCase</b>: case-insensitive string wildcard mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>IpAddress</b>: The source IP address belongs to the specified IP address or CIDR block.</para>
                    /// </description></item>
                    /// <item><description><para><b>NotIpAddress</b>: The source IP address does not belong to the specified IP address or CIDR block.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IpAddress</para>
                    /// </summary>
                    [NameInMap("ConditionOperator")]
                    [Validation(Required=false)]
                    public string ConditionOperator { get; set; }

                    /// <summary>
                    /// <para>The list of condition values.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ConditionValues")]
                    [Validation(Required=false)]
                    public List<string> ConditionValues { get; set; }

                }

                /// <summary>
                /// <para>The description of the egress rule. The description must be 2 to 256 characters in length and can contain Chinese characters, letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
                /// 
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the egress rule. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("EgressProxyRuleName")]
                [Validation(Required=false)]
                public string EgressProxyRuleName { get; set; }

                /// <summary>
                /// <para>The priority of the egress rule within its phase. Valid values: 1 to 1000. A smaller value indicates a higher priority. The priority must be unique within the same phase of a rule group.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The list of rules for the Pre-DNS stage (before DNS resolution).</para>
            /// </summary>
            [NameInMap("PreDns")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRuleGroupRequestEgressProxyRulesPreDns> PreDns { get; set; }
            public class CreateEgressProxyRuleGroupRequestEgressProxyRulesPreDns : TeaModel {
                /// <summary>
                /// <para>The action to perform on the matched traffic after the rule is hit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Allow</b>: allows the traffic that matches the rule.</para>
                /// </description></item>
                /// <item><description><para><b>Deny</b>: denies the traffic that matches the rule.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The list of matching conditions for the rule. Each condition consists of a condition key (ConditionKey), an operator (ConditionOperator), and condition values (ConditionValues). The combination of a condition key and an operator must be unique within the same rule.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<CreateEgressProxyRuleGroupRequestEgressProxyRulesPreDnsConditions> Conditions { get; set; }
                public class CreateEgressProxyRuleGroupRequestEgressProxyRulesPreDnsConditions : TeaModel {
                    /// <summary>
                    /// <para>The key of the matching condition. The value must match the phase of the rule and be used with an operator (ConditionOperator) of the corresponding category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>request:SourceIp</b>: the source IP address of the request. Used with IP address operators. Supported in the PreDns and PreRequest phases.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:DestinationDomain</b>: the destination domain name of the request. Used with string operators. Supported in the PreDns and PreRequest phases.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Uri</b>: the URI of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Method</b>: the HTTP request method. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:UserAgent</b>: the User-Agent of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:ContentType</b>: the Content-Type of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Header</b>: the HTTP request header. Used with string operators. Supported in the PreRequest phase. When you use this key, append the header name to the key in the format of request:Http:Header/<HeaderName>.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Protocol</b>: the request protocol. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>request:SourceIp</para>
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// <para>The operator of the matching condition. It must be used with a condition key (ConditionKey). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>StringEquals</b>: exact string match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringNotEquals</b>: string inequality.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringEqualsIgnoreCase</b>: case-insensitive exact string match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringNotEqualsIgnoreCase</b>: case-insensitive string inequality.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixMatch</b>: string prefix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixMatchIgnoreCase</b>: case-insensitive string prefix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixNotMatch</b>: string prefix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixNotMatchIgnoreCase</b>: case-insensitive string prefix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixMatch</b>: string suffix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixMatchIgnoreCase</b>: case-insensitive string suffix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixNotMatch</b>: string suffix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixNotMatchIgnoreCase</b>: case-insensitive string suffix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringRegexMatch</b>: string regular expression match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringRegexNotMatch</b>: string regular expression mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardMatch</b>: string wildcard match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardMatchIgnoreCase</b>: case-insensitive string wildcard match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardNotMatch</b>: string wildcard mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardNotMatchIgnoreCase</b>: case-insensitive string wildcard mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>IpAddress</b>: The source IP address belongs to the specified IP address or CIDR block.</para>
                    /// </description></item>
                    /// <item><description><para><b>NotIpAddress</b>: The source IP address does not belong to the specified IP address or CIDR block.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IpAddress</para>
                    /// </summary>
                    [NameInMap("ConditionOperator")]
                    [Validation(Required=false)]
                    public string ConditionOperator { get; set; }

                    /// <summary>
                    /// <para>The list of condition values.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ConditionValues")]
                    [Validation(Required=false)]
                    public List<string> ConditionValues { get; set; }

                }

                /// <summary>
                /// <para>The description of the egress rule. The description must be 2 to 256 characters in length and can contain Chinese characters, letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
                /// 
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the egress rule. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("EgressProxyRuleName")]
                [Validation(Required=false)]
                public string EgressProxyRuleName { get; set; }

                /// <summary>
                /// <para>The priority of the egress rule within its phase. Valid values: 1 to 1000. A smaller value indicates a higher priority. The priority must be unique within the same phase of a rule group.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

            /// <summary>
            /// <para>The list of rules in the PreRequest stage, which is executed before the request is forwarded.</para>
            /// </summary>
            [NameInMap("PreRequest")]
            [Validation(Required=false)]
            public List<CreateEgressProxyRuleGroupRequestEgressProxyRulesPreRequest> PreRequest { get; set; }
            public class CreateEgressProxyRuleGroupRequestEgressProxyRulesPreRequest : TeaModel {
                /// <summary>
                /// <para>The action to perform on the matched traffic after the rule is hit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Allow</b>: allows the traffic that matches the rule.</para>
                /// </description></item>
                /// <item><description><para><b>Deny</b>: denies the traffic that matches the rule.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The list of matching conditions for the rule. Each condition consists of a condition key (ConditionKey), an operator (ConditionOperator), and condition values (ConditionValues). The combination of a condition key and an operator must be unique within the same rule.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<CreateEgressProxyRuleGroupRequestEgressProxyRulesPreRequestConditions> Conditions { get; set; }
                public class CreateEgressProxyRuleGroupRequestEgressProxyRulesPreRequestConditions : TeaModel {
                    /// <summary>
                    /// <para>The key of the matching condition. The value must match the phase of the rule and be used with an operator (ConditionOperator) of the corresponding category. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>request:SourceIp</b>: the source IP address of the request. Used with IP address operators. Supported in the PreDns and PreRequest phases.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:DestinationDomain</b>: the destination domain name of the request. Used with string operators. Supported in the PreDns and PreRequest phases.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Uri</b>: the URI of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Method</b>: the HTTP request method. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:UserAgent</b>: the User-Agent of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:ContentType</b>: the Content-Type of the HTTP request. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Http:Header</b>: the HTTP request header. Used with string operators. Supported in the PreRequest phase. When you use this key, append the header name to the key in the format of request:Http:Header/<HeaderName>.</para>
                    /// </description></item>
                    /// <item><description><para><b>request:Protocol</b>: the request protocol. Used with string operators. Supported in the PreRequest phase.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>request:DestinationDomain</para>
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// <para>The operator of the matching condition. It must be used with a condition key (ConditionKey). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>StringEquals</b>: exact string match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringNotEquals</b>: string inequality.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringEqualsIgnoreCase</b>: case-insensitive exact string match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringNotEqualsIgnoreCase</b>: case-insensitive string inequality.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixMatch</b>: string prefix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixMatchIgnoreCase</b>: case-insensitive string prefix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixNotMatch</b>: string prefix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringPrefixNotMatchIgnoreCase</b>: case-insensitive string prefix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixMatch</b>: string suffix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixMatchIgnoreCase</b>: case-insensitive string suffix match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixNotMatch</b>: string suffix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringSuffixNotMatchIgnoreCase</b>: case-insensitive string suffix mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringRegexMatch</b>: string regular expression match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringRegexNotMatch</b>: string regular expression mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardMatch</b>: string wildcard match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardMatchIgnoreCase</b>: case-insensitive string wildcard match.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardNotMatch</b>: string wildcard mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>StringWildcardNotMatchIgnoreCase</b>: case-insensitive string wildcard mismatch.</para>
                    /// </description></item>
                    /// <item><description><para><b>IpAddress</b>: The source IP address belongs to the specified IP address or CIDR block.</para>
                    /// </description></item>
                    /// <item><description><para><b>NotIpAddress</b>: The source IP address does not belong to the specified IP address or CIDR block.</para>
                    /// </description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>StringEquals</para>
                    /// </summary>
                    [NameInMap("ConditionOperator")]
                    [Validation(Required=false)]
                    public string ConditionOperator { get; set; }

                    /// <summary>
                    /// <para>The list of condition values.</para>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ConditionValues")]
                    [Validation(Required=false)]
                    public List<string> ConditionValues { get; set; }

                }

                /// <summary>
                /// <para>The description of the egress rule. The description must be 2 to 256 characters in length and can contain Chinese characters, letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
                /// 
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the egress rule. The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testEpg</para>
                /// </summary>
                [NameInMap("EgressProxyRuleName")]
                [Validation(Required=false)]
                public string EgressProxyRuleName { get; set; }

                /// <summary>
                /// <para>The priority of the egress rule within its phase. Valid values: 1 to 1000. A smaller value indicates a higher priority. The priority must be unique within the same phase of a rule group.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-gw80bb6a94f835db****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEgressProxyRuleGroupRequestTag> Tag { get; set; }
        public class CreateEgressProxyRuleGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. It can be up to 128 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. It can be up to 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
