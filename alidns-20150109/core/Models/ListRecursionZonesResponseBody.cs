// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListRecursionZonesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4698691</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public ListRecursionZonesResponseBodyZones Zones { get; set; }
        public class ListRecursionZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<ListRecursionZonesResponseBodyZonesZone> Zone { get; set; }
            public class ListRecursionZonesResponseBodyZonesZone : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-08T05:45Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1729674680000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>218497924149333932</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SUB</para>
                /// </summary>
                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                [NameInMap("EffectiveScopes")]
                [Validation(Required=false)]
                public ListRecursionZonesResponseBodyZonesZoneEffectiveScopes EffectiveScopes { get; set; }
                public class ListRecursionZonesResponseBodyZonesZoneEffectiveScopes : TeaModel {
                    [NameInMap("EffectiveScope")]
                    [Validation(Required=false)]
                    public List<ListRecursionZonesResponseBodyZonesZoneEffectiveScopesEffectiveScope> EffectiveScope { get; set; }
                    public class ListRecursionZonesResponseBodyZonesZoneEffectiveScopesEffectiveScope : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>account</para>
                        /// </summary>
                        [NameInMap("EffectiveType")]
                        [Validation(Required=false)]
                        public string EffectiveType { get; set; }

                        [NameInMap("Scopes")]
                        [Validation(Required=false)]
                        public ListRecursionZonesResponseBodyZonesZoneEffectiveScopesEffectiveScopeScopes Scopes { get; set; }
                        public class ListRecursionZonesResponseBodyZonesZoneEffectiveScopesEffectiveScopeScopes : TeaModel {
                            [NameInMap("Scope")]
                            [Validation(Required=false)]
                            public List<string> Scope { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>record</para>
                /// </summary>
                [NameInMap("ProxyPattern")]
                [Validation(Required=false)]
                public string ProxyPattern { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public int? RecordCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>107</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-12T04:30Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1707189878000</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>173671468000011</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dfsdfsd</para>
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

    }

}
