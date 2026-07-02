// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListSkillsRequest : TeaModel {
        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListSkillsRequestFilter> Filter { get; set; }
        public class ListSkillsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter name. You can specify one or more names for the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SkillId: the skill ID. Exact match.</para>
            /// </description></item>
            /// <item><description><para>SkillSpaceId: the SkillSpace ID. Exact match.</para>
            /// </description></item>
            /// <item><description><para>SkillName: the skill name.</para>
            /// </description></item>
            /// <item><description><para>MatchType: the match type that controls how SkillName is matched. Valid values: exact, prefix, and fuzzy.</para>
            /// </description></item>
            /// <item><description><para>SkillType: the skill type. Valid values: official and custom.</para>
            /// </description></item>
            /// <item><description><para>Keyword: keyword match for the skill name or skill description. Fuzzy match.</para>
            /// </description></item>
            /// <item><description><para>SkillLabels: the skill labels. Fuzzy match.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SkillId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of filter values. Valid values of N: 1 to 10.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the download URL of the skill package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedDownloadUrl")]
        [Validation(Required=false)]
        public bool? NeedDownloadUrl { get; set; }

        /// <summary>
        /// <para>NextToken</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
