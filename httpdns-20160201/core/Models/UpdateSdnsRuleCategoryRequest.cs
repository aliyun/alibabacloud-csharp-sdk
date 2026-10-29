// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class UpdateSdnsRuleCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The JSON text string of the IP address range array. This parameter is used only to update IP_RANGE policies. If this parameter is omitted, the original IP address ranges are retained. If this parameter is provided, the original IP address ranges are replaced as a whole. You cannot pass an empty string, an empty array [], null, or a non-string array. Single IP addresses, CIDR blocks, and start-end ranges of IPv4 and IPv6 are supported. Multiple entries have an OR relationship. For CIDR blocks, the IPv4 prefix length ranges from 0 to 32, and the IPv6 prefix length ranges from 0 to 128. Start-end ranges are inclusive and must belong to the same address family, and the start address must not be greater than the end address. Overlapping, containing, and duplicate ranges are allowed within the same policy. When the policy is saved and read back, the array order, duplicate items, and the original text of each string are retained. An array can contain up to 2,000 array elements. The total number of parsed non-empty address expressions ranges from 1 to 2,000, and duplicate items are counted. We recommend that you specify one expression per element. It is compatible with line breaks within an element. Each expression can contain up to 128 characters, including leading and trailing whitespace. The serialized UTF-8 JSON sequence cannot exceed 65,535 bytes. The quantity and byte limits take effect at the same time. Overlapping is not allowed among different IP_RANGE policies of the same account, the same domain name, and the same address family. Disabled policies are also checked. Disabling a policy does not release its IP address ranges. This limit does not compare LINE policies and the independent configurations of the legacy SetIPRegionResult operation. The new ranges do not conflict with the old ranges of the same policy during an update. Send this parameter as a single form field, and do not add quotes to the JSON text again.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;198.51.100.0/24&quot;,&quot;2001:db8:1::/64&quot;]</para>
        /// </summary>
        [NameInMap("ClientIpRanges")]
        [Validation(Required=false)]
        public string ClientIpRanges { get; set; }

        /// <summary>
        /// <para>The ID of the policy for the current account. This parameter is required. You can obtain the ID from the Id field in the response of CreateSdnsRuleCategory or from the list returned by SdnsListRuleCategories. Use a decimal string to avoid precision loss for large integers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012345678</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The complete list of rules. This parameter is required and must contain at least one rule. If you match only by IP address range, you can configure a default rule without ArgKeys and Args, and configure the A or AAAA destination addresses in the Records field of the rule. The update replaces the original rule list as a whole. Old rules that are not included in the new list are removed. When the rules are saved, the serialized UTF-8 JSON content must be less than 65,535 bytes.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateSdnsRuleCategoryRequestRules> Rules { get; set; }
        public class UpdateSdnsRuleCategoryRequestRules : TeaModel {
            /// <summary>
            /// <para>The optional list of custom parameter names, which is used to record the display order. Omit this parameter if you match only by IP address range. If you use Args, the names must correspond to the parameter names in Args.</para>
            /// </summary>
            [NameInMap("ArgKeys")]
            [Validation(Required=false)]
            public List<string> ArgKeys { get; set; }

            /// <summary>
            /// <para>The optional custom parameter conditions. The key is the parameter name, and the value is the match value. Omit this parameter if you match only by IP address range. You do not need to add business parameters.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public Dictionary<string, string> Args { get; set; }

            /// <summary>
            /// <para>The name of the rule. This parameter is required and cannot be null. We recommend that you use a non-empty name that has business meaning. The name cannot replace the policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default rule</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of configured DNS records. The list can include A and AAAA records. Actual DNS resolution returns only the records of the queried type. If the list is empty or does not contain records of the queried type, the system continues to fall back.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<UpdateSdnsRuleCategoryRequestRulesRecords> Records { get; set; }
            public class UpdateSdnsRuleCategoryRequestRulesRecords : TeaModel {
                /// <summary>
                /// <para>The single destination IP address corresponding to the record. When Type is set to 1, the IP address is an IPv4 address, such as 192.0.2.200. When Type is set to 28, the IP address is an IPv6 address, such as 2001:db8::200. Do not use CIDR blocks, start-end ranges, or domain names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.2.200</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The DNS record type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: A record.</description></item>
                /// <item><description>28: AAAA record.
                /// Specify an integer. Do not use the string A or AAAA.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The auxiliary display text for the record type. This text is not used for matching or DNS resolution decisions. You can omit this parameter in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("TypeLabel")]
                [Validation(Required=false)]
                public string TypeLabel { get; set; }

                /// <summary>
                /// <para>The relative weight of the record. This parameter is used to select one record of the same queried type only when ResultMode is set to 1. We recommend that you set this parameter to a positive integer from 1 to 100. The sum of the weights of all records does not need to be 100. This parameter is not used for selection when ResultMode is set to 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The record return mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Returns all records of the queried type.</description></item>
            /// <item><description>1: Returns one record of the queried type based on the weight.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResultMode")]
            [Validation(Required=false)]
            public int? ResultMode { get; set; }

            /// <summary>
            /// <para>The cache validity period of the record, in seconds. The value must be a positive integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

    }

}
