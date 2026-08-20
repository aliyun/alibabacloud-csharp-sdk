// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListSkillSpacesRequest : TeaModel {
        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListSkillSpacesRequestFilter> Filter { get; set; }
        public class ListSkillSpacesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter name. You can specify one or more names for the query. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SkillSpaceId: the SkillSpace ID. Exact match.</para>
            /// </description></item>
            /// <item><description><para>SkillSpaceName: the SkillSpace name.</para>
            /// </description></item>
            /// <item><description><para>MatchType: the match type that controls the matching behavior of SkillSpace. Valid values: exact, prefix, and fuzzy.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SkillSpaceId</para>
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
        /// <para>The number of entries per page in a paging query. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the value of NextToken that was returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBBAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
