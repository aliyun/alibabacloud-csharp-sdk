// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListSkillSpacesRequest : TeaModel {
        /// <summary>
        /// <para>The query filters.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListSkillSpacesRequestFilter> Filter { get; set; }
        public class ListSkillSpacesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter name. You can specify one or more filter names. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>SkillSpaceId</c>: The SkillSpace ID. This filter performs an exact match.</para>
            /// </description></item>
            /// <item><description><para><c>SkillSpaceName</c>: The SkillSpace name.</para>
            /// </description></item>
            /// <item><description><para><c>MatchType</c>: The match type for the <c>SkillSpaceName</c> filter. Valid values: <c>exact</c>, <c>prefix</c>, and <c>fuzzy</c>.</para>
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
            /// <para>The filter values. You can specify 1 to 10 values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return per page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results. To retrieve the next page, set this parameter to the <c>NextToken</c> value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBBAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
