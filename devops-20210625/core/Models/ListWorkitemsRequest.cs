// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkitemsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Req</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;conditionGroups&quot;:[]}</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;conditionGroups&quot;:[]}</para>
        /// </summary>
        [NameInMap("extraConditions")]
        [Validation(Required=false)]
        public string ExtraConditions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;fieldIdentifier&quot;:&quot;tag&quot;,&quot;className&quot;:&quot;tag&quot;,&quot;format&quot;:&quot;multiList&quot;,&quot;value&quot;:[&quot;c76e0e4bf64801cfad73......&quot;],&quot;operator&quot;:&quot;EQUALS&quot;}</para>
        /// </summary>
        [NameInMap("groupCondition")]
        [Validation(Required=false)]
        public string GroupCondition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;fieldIdentifier&quot;:&quot;status&quot;,&quot;format&quot;:&quot;list&quot;,&quot;order&quot;:&quot;desc&quot;,&quot;className&quot;:&quot;status&quot;}</para>
        /// </summary>
        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LIST</para>
        /// </summary>
        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8fb83debd69a6c7c6626......</para>
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Project</para>
        /// </summary>
        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

    }

}
