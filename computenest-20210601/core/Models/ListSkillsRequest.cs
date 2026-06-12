// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListSkillsRequest : TeaModel {
        /// <summary>
        /// <para>The filters for querying Skills.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListSkillsRequestFilter> Filter { get; set; }
        public class ListSkillsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>SkillId</c>: The Skill ID. An exact match is performed.</para>
            /// </description></item>
            /// <item><description><para><c>SkillSpaceId</c>: The ID of the SkillSpace. An exact match is performed.</para>
            /// </description></item>
            /// <item><description><para><c>SkillName</c>: The Skill name.</para>
            /// </description></item>
            /// <item><description><para><c>MatchType</c>: The match type for <c>SkillName</c>. Valid values: <c>exact</c> (exact match), <c>prefix</c> (prefix match), and <c>fuzzy</c> (fuzzy match).</para>
            /// </description></item>
            /// <item><description><para><c>SkillType</c>: The Skill type. Valid values: <c>official</c> and <c>custom</c>.</para>
            /// </description></item>
            /// <item><description><para><c>Keyword</c>: The keyword for a fuzzy match on the Skill name or Skill description.</para>
            /// </description></item>
            /// <item><description><para><c>SkillLabels</c>: The Skill labels. A fuzzy match is performed.</para>
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
            /// <para>The filter values. You can specify a maximum of 10 values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the download URL of the Skill package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedDownloadUrl")]
        [Validation(Required=false)]
        public bool? NeedDownloadUrl { get; set; }

        /// <summary>
        /// <para>The token for the next page of results. Leave this parameter empty for the first request. For subsequent requests, use the <c>NextToken</c> value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
