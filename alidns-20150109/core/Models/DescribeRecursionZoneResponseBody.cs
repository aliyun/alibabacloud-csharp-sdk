// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeRecursionZoneResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-06-06T11:34Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1533773400000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SOAR</para>
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
        public DescribeRecursionZoneResponseBodyEffectiveScopes EffectiveScopes { get; set; }
        public class DescribeRecursionZoneResponseBodyEffectiveScopes : TeaModel {
            [NameInMap("EffectiveScope")]
            [Validation(Required=false)]
            public List<DescribeRecursionZoneResponseBodyEffectiveScopesEffectiveScope> EffectiveScope { get; set; }
            public class DescribeRecursionZoneResponseBodyEffectiveScopesEffectiveScope : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>account</para>
                /// </summary>
                [NameInMap("EffectiveType")]
                [Validation(Required=false)]
                public string EffectiveType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[20003]</para>
                /// </summary>
                [NameInMap("Scopes")]
                [Validation(Required=false)]
                public DescribeRecursionZoneResponseBodyEffectiveScopesEffectiveScopeScopes Scopes { get; set; }
                public class DescribeRecursionZoneResponseBodyEffectiveScopesEffectiveScopeScopes : TeaModel {
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-01-03T08:57Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>169438909000011</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cheng.suow.cc</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

    }

}
