// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class CreateSdnsRuleCategoryRequest : TeaModel {
        /// <summary>
        /// <para>The array of client IP address ranges required for the IP_RANGE pattern. Send this parameter as a JSON form field. Do not specify this parameter for the LINE pattern. This parameter supports single IPv4 and IPv6 addresses, CIDR blocks, and start-end ranges. Multiple entries have an OR relationship. For CIDR blocks, the IPv4 prefix length ranges from 0 to 32, and the IPv6 prefix length ranges from 0 to 128. Start-end ranges are inclusive and must belong to the same address family, and the start address cannot be greater than the end address. Duplicates, inclusions, and overlaps are allowed within the same policy. When the policy is saved and read back, the array sequence, duplicates, and original text of each string are preserved. The array can contain up to 2,000 array elements. The total number of parsed non-empty address expressions ranges from 1 to 2,000, and duplicates are counted. We recommend that you specify one expression per array element. It is compatible with line breaks within an array element. Each expression can contain up to 128 characters, including leading and trailing spaces. The serialized UTF-8 JSON content cannot exceed 65,535 bytes. The quantity and byte limits take effect simultaneously. Overlaps are not allowed between different IP_RANGE policies for the same account, domain name, and address family. Disabled policies are also checked. Disabling a policy does not release the ranges. This limit does not compare independent configurations of LINE policies and the legacy SetIPRegionResult operation.</para>
        /// </summary>
        [NameInMap("ClientIpRanges")]
        [Validation(Required=false)]
        public List<string> ClientIpRanges { get; set; }

        /// <summary>
        /// <para>The domain name connected to HTTPDNS for the current account. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the policy upon creation. If this parameter is omitted or set to false, the policy is disabled (Status=0). If this parameter is set to true, the policy is enabled (Status=1), and you do not need to call the enable operation. This parameter applies to the LINE and IP_RANGE modes. Actual resolution still requires waiting for configuration propagation.</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The line identifier required for the LINE mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>internal: the Chinese mainland.</description></item>
        /// <item><description>overseas: outside the Chinese mainland.</description></item>
        /// </list>
        /// <para>Do not specify this parameter for the IP_RANGE mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal</para>
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public string LineId { get; set; }

        /// <summary>
        /// <para>The match type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LINE: the line mode.</description></item>
        /// <item><description>IP_RANGE: the client IP address range mode.</description></item>
        /// </list>
        /// <para>If this parameter is omitted, it is processed as LINE. To create an IP address range policy, you must explicitly set this parameter to IP_RANGE and provide ClientIpRanges. You cannot provide LineId or Paths at the same time. The match type cannot be changed after creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IP_RANGE</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The line selection path that describes the line conditions at each level. This parameter applies only to the LINE mode. The IP_RANGE mode does not use line paths. When you create a line policy, provide valid options at each level. Use x for the default option. For the Chinese mainland, the levels include ISP, region, and province. For regions outside the Chinese mainland, the levels include continent and region.</para>
        /// </summary>
        [NameInMap("Paths")]
        [Validation(Required=false)]
        public List<CreateSdnsRuleCategoryRequestPaths> Paths { get; set; }
        public class CreateSdnsRuleCategoryRequestPaths : TeaModel {
            /// <summary>
            /// <para>The code of the option at this level. For example, chinanet at the isps level indicates China Telecom. Use valid options for the associated line and maintain consistent hierarchical subordination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chinanet</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The level identifier. For the Chinese mainland, use isps, subRegions, and provinces. For regions outside the Chinese mainland, use continents and geoRegions. This parameter corresponds to Level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>isps</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The sequence number of the line level. For the Chinese mainland, the values are 1 (ISP), 2 (region), and 3 (province). For regions outside the Chinese mainland, the values are 1 (continent) and 2 (region).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

        }

        /// <summary>
        /// <para>The complete list of rules. This parameter is required and must contain at least one rule. When matching only by IP address range, configure a default rule without ArgKeys and Args, and configure the A or AAAA destination addresses in the Records of this rule. When saved, the serialized UTF-8 JSON content must be less than 65,535 bytes.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateSdnsRuleCategoryRequestRules> Rules { get; set; }
        public class CreateSdnsRuleCategoryRequestRules : TeaModel {
            /// <summary>
            /// <para>The optional list of custom parameter names used to record the display order. Omit this parameter when matching only by IP address range. If Args is used, the names must correspond to the parameter names in Args.</para>
            /// </summary>
            [NameInMap("ArgKeys")]
            [Validation(Required=false)]
            public List<string> ArgKeys { get; set; }

            /// <summary>
            /// <para>The optional custom parameter conditions. The key is the parameter name, and the value is the match value. Omit this parameter when matching only by IP address range. You do not need to add business parameters.</para>
            /// </summary>
            [NameInMap("Args")]
            [Validation(Required=false)]
            public Dictionary<string, string> Args { get; set; }

            /// <summary>
            /// <para>The rule name. This parameter is required and cannot be null. We recommend that you use a non-empty name with business meaning. This parameter cannot replace the policy Id.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default rule</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of configured resolution records, which can include A and AAAA records. Actual resolution returns only records of the queried type. If the list is empty or does not contain records of the queried type, the system continues to fall back.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<CreateSdnsRuleCategoryRequestRulesRecords> Records { get; set; }
            public class CreateSdnsRuleCategoryRequestRulesRecords : TeaModel {
                /// <summary>
                /// <para>The single destination IP address corresponding to the record. If Type is set to 1, the value is an IPv4 address, such as 192.0.2.200. If Type is set to 28, the value is an IPv6 address, such as 2001:db8::200. Do not use CIDR blocks, start-end ranges, or domain names.</para>
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
                /// <item><description>28: AAAA record.</description></item>
                /// </list>
                /// <para>Specify an integer. Do not use the string A or AAAA.</para>
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
                /// <para>The relative weight of the record. This parameter is used to select one record of the same queried type only when ResultMode is set to 1. We recommend that you set this parameter to a positive integer from 1 to 100. The sum of the weights of all records does not need to be 100. This parameter does not participate in selection when ResultMode is set to 0.</para>
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
            /// <item><description>0: returns all records of the queried type.</description></item>
            /// <item><description>1: returns one record of the queried type based on the weight.</description></item>
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
