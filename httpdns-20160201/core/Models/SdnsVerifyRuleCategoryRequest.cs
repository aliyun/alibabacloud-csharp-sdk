// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class SdnsVerifyRuleCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The parameter object used for the current validation. If no custom parameters are used, pass an empty JSON object {}. Do not pass an empty string or null.</para>
        /// </summary>
        [NameInMap("Args")]
        [Validation(Required=false)]
        public Dictionary<string, string> Args { get; set; }

        /// <summary>
        /// <para>The simulated client IP address. This parameter is required in IP_RANGE mode. Supports a single IPv4 or IPv6 address. CIDR blocks and start-to-end ranges are not supported. This parameter is used for CIDR block matching in the current request and does not change the source of the actual DNS resolution request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>198.51.100.10</para>
        /// </summary>
        [NameInMap("Cip")]
        [Validation(Required=false)]
        public string Cip { get; set; }

        /// <summary>
        /// <para>The array of client CIDR blocks that must be provided in the IP_RANGE pattern. Send this parameter as a JSON form field. Do not pass this parameter in the LINE pattern. Supports single IPv4 and IPv6 addresses, CIDR blocks, and start-to-end ranges. Multiple entries have an OR relationship. For CIDR blocks, the IPv4 prefix length ranges from 0 to 32, and the IPv6 prefix length ranges from 0 to 128. Start-to-end ranges are inclusive and must belong to the same address family, with the start address not greater than the end address. Overlapping, containing, and duplicate ranges are allowed within the same policy. When the policy is saved and read back, the array sequence, duplicate items, and the original text of each string are preserved. The array can contain up to 2,000 array elements. The total number of parsed non-empty address expressions ranges from 1 to 2,000, including duplicates. Specify one expression per array element. It is compatible with line breaks within an array element. Each expression can contain up to 128 characters, including leading and trailing whitespace. The serialized UTF-8 JSON content cannot exceed 65,535 bytes. Both the quantity and byte limits apply simultaneously. To authenticate, the system only checks the ranges that you commit and does not check for conflicts with saved policies.</para>
        /// </summary>
        [NameInMap("ClientIpRanges")]
        [Validation(Required=false)]
        public List<string> ClientIpRanges { get; set; }

        /// <summary>
        /// <para>The match type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LINE: line mode</description></item>
        /// <item><description>IP_RANGE: client CIDR block mode
        /// If this parameter is omitted, LINE is used. In IP_RANGE mode, you must provide both ClientIpRanges and Cip.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IP_RANGE</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The complete list of rules. This parameter is required and must contain at least one rule. If you only need to match CIDR blocks, configure a default rule without ArgKeys and Args, and configure the A/AAAA destination addresses in the Records field of this rule. This operation is used for match validation and does not save the rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<SdnsVerifyRuleCategoryRequestRules> Rules { get; set; }
        public class SdnsVerifyRuleCategoryRequestRules : TeaModel {
            /// <summary>
            /// <para>The optional list of custom parameter names, used to record the display order. Omit this parameter if you only match CIDR blocks. If you use Args, the names must correspond to the parameter names in Args.</para>
            /// </summary>
            [NameInMap("ArgKeys")]
            [Validation(Required=false)]
            public List<string> ArgKeys { get; set; }

            /// <summary>
            /// <para>The optional custom parameter conditions. The key is the parameter name and the value is the match value. Omit this parameter if you only match CIDR blocks. You do not need to add business parameters.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public Dictionary<string, string> Args { get; set; }

            /// <summary>
            /// <para>The rule name. This parameter is required and cannot be null. Use a non-empty name with business meaning. This parameter cannot replace the policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default rule</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of configured DNS records, which can include A and AAAA records. Actual DNS resolution returns only records of the queried type. If the list is empty or does not contain records of the queried type, the system continues to fall back. This operation returns the records configured in the rule and does not filter them by query type.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<SdnsVerifyRuleCategoryRequestRulesRecords> Records { get; set; }
            public class SdnsVerifyRuleCategoryRequestRulesRecords : TeaModel {
                /// <summary>
                /// <para>The single destination IP address for the record. If Type is set to 1, specify an IPv4 address, such as 192.0.2.200. If Type is set to 28, specify an IPv6 address, such as 2001:db8::200. Do not use CIDR blocks, start-to-end ranges, or domain names.</para>
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
                /// <item><description>1: A record</description></item>
                /// <item><description>28: AAAA record
                /// Specify an integer. Do not use the strings A or AAAA.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <para>The auxiliary display text for the record type. This parameter does not participate in matching or resolution decisions and can be omitted in the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("TypeLabel")]
                [Validation(Required=false)]
                public string TypeLabel { get; set; }

                /// <summary>
                /// <para>The relative weight of the record. This parameter is used to select one record of the same query type only when ResultMode is set to 1. Set this parameter to a positive integer from 1 to 100. The sum of the weights of all records does not need to be 100. This parameter does not participate in selection when ResultMode is set to 0.</para>
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
            /// <item><description>1: Returns one record of the queried type based on weight.
            /// Policy validation only returns the rule configuration and does not perform weight sampling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ResultMode")]
            [Validation(Required=false)]
            public int? ResultMode { get; set; }

            /// <summary>
            /// <para>The cache validity period of the record, in seconds. This parameter must be a positive integer.</para>
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
