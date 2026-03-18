// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchRecursionZonesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
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
        /// <para>20</para>
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
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public SearchRecursionZonesResponseBodyZones Zones { get; set; }
        public class SearchRecursionZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<SearchRecursionZonesResponseBodyZonesZone> Zone { get; set; }
            public class SearchRecursionZonesResponseBodyZonesZone : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                [NameInMap("EffectiveScopes")]
                [Validation(Required=false)]
                public SearchRecursionZonesResponseBodyZonesZoneEffectiveScopes EffectiveScopes { get; set; }
                public class SearchRecursionZonesResponseBodyZonesZoneEffectiveScopes : TeaModel {
                    [NameInMap("EffectiveScope")]
                    [Validation(Required=false)]
                    public List<SearchRecursionZonesResponseBodyZonesZoneEffectiveScopesEffectiveScope> EffectiveScope { get; set; }
                    public class SearchRecursionZonesResponseBodyZonesZoneEffectiveScopesEffectiveScope : TeaModel {
                        [NameInMap("EffectiveType")]
                        [Validation(Required=false)]
                        public string EffectiveType { get; set; }

                        [NameInMap("Scopes")]
                        [Validation(Required=false)]
                        public SearchRecursionZonesResponseBodyZonesZoneEffectiveScopesEffectiveScopeScopes Scopes { get; set; }
                        public class SearchRecursionZonesResponseBodyZonesZoneEffectiveScopesEffectiveScopeScopes : TeaModel {
                            [NameInMap("Scope")]
                            [Validation(Required=false)]
                            public List<string> Scope { get; set; }

                        }

                    }

                }

                [NameInMap("ProxyPattern")]
                [Validation(Required=false)]
                public string ProxyPattern { get; set; }

                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public int? RecordCount { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

            }

        }

    }

}
