// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Httpdns20160201.Models
{
    public class SdnsGetRuleCategoryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SdnsGetRuleCategoryResponseBodyData Data { get; set; }
        public class SdnsGetRuleCategoryResponseBodyData : TeaModel {
            [NameInMap("ClientIpRanges")]
            [Validation(Required=false)]
            public List<string> ClientIpRanges { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>api.example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789012345678</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IP_RANGE</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public SdnsGetRuleCategoryResponseBodyDataRecordLine RecordLine { get; set; }
            public class SdnsGetRuleCategoryResponseBodyDataRecordLine : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>internal</para>
                /// </summary>
                [NameInMap("LineId")]
                [Validation(Required=false)]
                public string LineId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>中国地区</para>
                /// </summary>
                [NameInMap("LineLabel")]
                [Validation(Required=false)]
                public string LineLabel { get; set; }

                [NameInMap("Paths")]
                [Validation(Required=false)]
                public List<SdnsGetRuleCategoryResponseBodyDataRecordLinePaths> Paths { get; set; }
                public class SdnsGetRuleCategoryResponseBodyDataRecordLinePaths : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>chinanet</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>isps</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>电信</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                }

            }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public SdnsGetRuleCategoryResponseBodyDataRegion Region { get; set; }
            public class SdnsGetRuleCategoryResponseBodyDataRegion : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public SdnsGetRuleCategoryResponseBodyDataRegionArea Area { get; set; }
                public class SdnsGetRuleCategoryResponseBodyDataRegionArea : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>huadong</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>华东</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                [NameInMap("City")]
                [Validation(Required=false)]
                public SdnsGetRuleCategoryResponseBodyDataRegionCity City { get; set; }
                public class SdnsGetRuleCategoryResponseBodyDataRegionCity : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;x&quot;</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                [NameInMap("Continent")]
                [Validation(Required=false)]
                public SdnsGetRuleCategoryResponseBodyDataRegionContinent Continent { get; set; }
                public class SdnsGetRuleCategoryResponseBodyDataRegionContinent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>亚洲</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                [NameInMap("Country")]
                [Validation(Required=false)]
                public SdnsGetRuleCategoryResponseBodyDataRegionCountry Country { get; set; }
                public class SdnsGetRuleCategoryResponseBodyDataRegionCountry : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>中国大陆</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public SdnsGetRuleCategoryResponseBodyDataRegionIsp Isp { get; set; }
                public class SdnsGetRuleCategoryResponseBodyDataRegionIsp : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>chinanet</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>电信</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public SdnsGetRuleCategoryResponseBodyDataRegionProvince Province { get; set; }
                public class SdnsGetRuleCategoryResponseBodyDataRegionProvince : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zhejiang</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>浙江</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

            }

            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<SdnsGetRuleCategoryResponseBodyDataRules> Rules { get; set; }
            public class SdnsGetRuleCategoryResponseBodyDataRules : TeaModel {
                [NameInMap("ArgKeys")]
                [Validation(Required=false)]
                public List<string> ArgKeys { get; set; }

                [NameInMap("Args")]
                [Validation(Required=false)]
                public Dictionary<string, string> Args { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>默认规则</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Records")]
                [Validation(Required=false)]
                public List<SdnsGetRuleCategoryResponseBodyDataRulesRecords> Records { get; set; }
                public class SdnsGetRuleCategoryResponseBodyDataRulesRecords : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>192.0.2.200</para>
                    /// </summary>
                    [NameInMap("Ip")]
                    [Validation(Required=false)]
                    public string Ip { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public int? Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("TypeLabel")]
                    [Validation(Required=false)]
                    public string TypeLabel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ResultMode")]
                [Validation(Required=false)]
                public int? ResultMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50F9C40E-188D-4208-BE2C-74271337****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
