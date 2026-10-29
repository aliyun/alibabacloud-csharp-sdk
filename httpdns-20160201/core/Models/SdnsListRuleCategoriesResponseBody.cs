// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class SdnsListRuleCategoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of all custom resolution policies for the domain name, including LINE and IP_RANGE policies, as well as enabled and disabled policies. The order of the list is not guaranteed.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<SdnsListRuleCategoriesResponseBodyList> List { get; set; }
        public class SdnsListRuleCategoriesResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The array of original CIDR blocks from the most recent successful submission for an IP_RANGE policy. The order, duplicates, and content of each string are preserved. The response is a JSON array, not a text string of an array. This field is not used for LINE policies.</para>
            /// </summary>
            [NameInMap("ClientIpRanges")]
            [Validation(Required=false)]
            public List<string> ClientIpRanges { get; set; }

            /// <summary>
            /// <para>The domain name to which the policy is bound.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api.example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The ID of the policy, which can be used to query, update, enable, disable, or delete the policy. Treat it as a string to avoid precision loss of large integers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789012345678</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The match type of the policy. Valid values: LINE: line policy. IP_RANGE: client CIDR block policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IP_RANGE</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The line display information for a LINE policy. This field can be empty or omitted for an IP_RANGE policy.</para>
            /// </summary>
            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public SdnsListRuleCategoriesResponseBodyListRecordLine RecordLine { get; set; }
            public class SdnsListRuleCategoriesResponseBodyListRecordLine : TeaModel {
                /// <summary>
                /// <para>The line identifier. Valid values: internal: the Chinese mainland. overseas: outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>internal</para>
                /// </summary>
                [NameInMap("LineId")]
                [Validation(Required=false)]
                public string LineId { get; set; }

                /// <summary>
                /// <para>The display name of the line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The Chinese mainland</para>
                /// </summary>
                [NameInMap("LineLabel")]
                [Validation(Required=false)]
                public string LineLabel { get; set; }

                /// <summary>
                /// <para>The line selection path, which describes the line conditions at each level. This field applies only to LINE policies. IP_RANGE policies do not use line paths.</para>
                /// </summary>
                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<SdnsListRuleCategoriesResponseBodyListRecordLinePaths> Paths { get; set; }
                public class SdnsListRuleCategoriesResponseBodyListRecordLinePaths : TeaModel {
                    /// <summary>
                    /// <para>The code of the option at this level. For example, chinanet at the isps level indicates China Telecom. Use valid options for the associated line and maintain consistent hierarchical relationships.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chinanet</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The level identifier. For the Chinese mainland, valid values are isps, subRegions, and provinces. For regions outside the Chinese mainland, valid values are continents and geoRegions. This corresponds to the Level field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>isps</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The display name of the line option. The display name of the default option can be empty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>China Telecom</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The sequence number of the line level. For the Chinese mainland, the values are 1 (ISP), 2 (region), and 3 (province). For regions outside the Chinese mainland, the values are 1 (continent) and 2 (geographical region).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                }

            }

            /// <summary>
            /// <para>The line and region display information for compatibility with existing clients. This field applies only to LINE policies and can be empty or omitted for IP_RANGE policies.</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public SdnsListRuleCategoriesResponseBodyListRegion Region { get; set; }
            public class SdnsListRuleCategoriesResponseBodyListRegion : TeaModel {
                /// <summary>
                /// <para>The code and display name of the region.</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public SdnsListRuleCategoriesResponseBodyListRegionArea Area { get; set; }
                public class SdnsListRuleCategoriesResponseBodyListRegionArea : TeaModel {
                    /// <summary>
                    /// <para>The code of the region. The value x indicates the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>huadong</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The display name of the region. An empty string can be returned for the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>East China</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>The code and display name of the city. This is a reserved field for compatibility. City-level granularity is not currently provided.</para>
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public SdnsListRuleCategoriesResponseBodyListRegionCity City { get; set; }
                public class SdnsListRuleCategoriesResponseBodyListRegionCity : TeaModel {
                    /// <summary>
                    /// <para>The code of the city. This is a reserved field for compatibility. The default value is x, which indicates that no city is specified. The example uses the JSON string literal &quot;x&quot;, where the double quotes are not part of the actual field content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;x&quot;</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The display name of the city. This is a reserved field for compatibility, and an empty string is returned. The example uses the JSON literal &quot;&quot; to represent an empty string, where the double quotes are not part of the actual field content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>The code and display name of the continent.</para>
                /// </summary>
                [NameInMap("Continent")]
                [Validation(Required=false)]
                public SdnsListRuleCategoriesResponseBodyListRegionContinent Continent { get; set; }
                public class SdnsListRuleCategoriesResponseBodyListRegionContinent : TeaModel {
                    /// <summary>
                    /// <para>The code of the continent. The value x indicates the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The display name of the continent. An empty string can be returned for the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Asia</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>The code and display name of the country or region.</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public SdnsListRuleCategoriesResponseBodyListRegionCountry Country { get; set; }
                public class SdnsListRuleCategoriesResponseBodyListRegionCountry : TeaModel {
                    /// <summary>
                    /// <para>The code of the country or region. The value x indicates the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The display name of the country or region. An empty string can be returned for the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The Chinese mainland</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>The code and display name of the ISP.</para>
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public SdnsListRuleCategoriesResponseBodyListRegionIsp Isp { get; set; }
                public class SdnsListRuleCategoriesResponseBodyListRegionIsp : TeaModel {
                    /// <summary>
                    /// <para>The code of the ISP. The value x indicates the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chinanet</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The display name of the ISP. An empty string can be returned for the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>China Telecom</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <para>The code and display name of the province.</para>
                /// </summary>
                [NameInMap("Province")]
                [Validation(Required=false)]
                public SdnsListRuleCategoriesResponseBodyListRegionProvince Province { get; set; }
                public class SdnsListRuleCategoriesResponseBodyListRegionProvince : TeaModel {
                    /// <summary>
                    /// <para>The code of the province. The value x indicates the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhejiang</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The display name of the province. An empty string can be returned for the default item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhejiang</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of custom resolution rules included in the policy. If multiple rules have no parameter conditions, only the first rule is prioritized. Multiple return addresses should be configured in a single rule.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<SdnsListRuleCategoriesResponseBodyListRules> Rules { get; set; }
            public class SdnsListRuleCategoriesResponseBodyListRules : TeaModel {
                /// <summary>
                /// <para>The names and display order of custom parameters. This field can be empty if no custom parameters are used.</para>
                /// </summary>
                [NameInMap("ArgKeys")]
                [Validation(Required=false)]
                public List<string> ArgKeys { get; set; }

                /// <summary>
                /// <para>The custom parameter matching conditions attached to the rule. If not configured, no parameter restrictions are applied.</para>
                /// </summary>
                [NameInMap("Args")]
                [Validation(Required=false)]
                public Dictionary<string, string> Args { get; set; }

                /// <summary>
                /// <para>The name of the rule, which is used to identify the rule and cannot replace the policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default rule</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of configured DNS records, which can include A and AAAA records. Actual resolution returns only records of the queried type. If the list is empty or contains no records of the queried type, the system continues to fall back.</para>
                /// </summary>
                [NameInMap("Records")]
                [Validation(Required=false)]
                public List<SdnsListRuleCategoriesResponseBodyListRulesRecords> Records { get; set; }
                public class SdnsListRuleCategoriesResponseBodyListRulesRecords : TeaModel {
                    /// <summary>
                    /// <para>The single destination IP address corresponding to the record. When Type is 1, it is an IPv4 address, such as 192.0.2.200. When Type is 28, it is an IPv6 address, such as 2001:db8::200. CIDR blocks, IP ranges, or domain names are not used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.0.2.200</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <para>The DNS record type. Valid values: 1: A record. 28: AAAA record. Enter an integer instead of the string A or AAAA.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <para>The auxiliary display text for the record type, which is not used for matching or resolution decisions. This field can be omitted in requests.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("TypeLabel")]
                    [Validation(Required=false)]
                    public string TypeLabel { get; set; }

                    /// <summary>
                    /// <para>The relative weight of the record, which is used to select one record of the same query type only when ResultMode is 1. Set this to a positive integer from 1 to 100. The sum of the weights of all records does not need to be 100. This field is not used for selection when ResultMode is 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                /// <summary>
                /// <para>The record return mode. Valid values: 0: returns all records of the queried type. 1: returns one record of the queried type based on weight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ResultMode")]
                [Validation(Required=false)]
                public int? ResultMode { get; set; }

                /// <summary>
                /// <para>The cache validity period of the record, in seconds. This value must be a positive integer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <para>The status of the policy. Valid values: 0: disabled. 1: enabled. After a policy is enabled, actual resolution requires waiting for configuration propagation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to troubleshoot call issues and is not the policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50F9C40E-188D-4208-BE2C-74271337****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
