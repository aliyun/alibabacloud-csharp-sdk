// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListPublicSkillsRequest : TeaModel {
        /// <summary>
        /// <para>A list of filters.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListPublicSkillsRequestFilter> Filter { get; set; }
        public class ListPublicSkillsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter criterion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>SkillId</c>: The ID of the skill. An exact match is performed.</para>
            /// </description></item>
            /// <item><description><para><c>SkillName</c>: The name of the skill.</para>
            /// </description></item>
            /// <item><description><para><c>MatchType</c>: The match type for the <c>SkillName</c> filter. Valid values: <c>exact</c> (exact match), <c>prefix</c> (prefix match), and <c>fuzzy</c> (fuzzy match).</para>
            /// </description></item>
            /// <item><description><para><c>Keyword</c>: The keyword used for a fuzzy match on the skill name or skill description.</para>
            /// </description></item>
            /// <item><description><para><c>SkillLabels</c>: The skill labels. A fuzzy match is performed.</para>
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
            /// <para>The filter values. You can specify 1 to 10 values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the download link for the skill package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedDownloadUrl")]
        [Validation(Required=false)]
        public bool? NeedDownloadUrl { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
