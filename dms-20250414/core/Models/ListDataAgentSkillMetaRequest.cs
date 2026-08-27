// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentSkillMetaRequest : TeaModel {
        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data-query-skill</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The source of the skill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: a skill uploaded by the user.</description></item>
        /// <item><description>Agent: a skill derived from Agent analysis.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("SkillFrom")]
        [Validation(Required=false)]
        public string SkillFrom { get; set; }

        /// <summary>
        /// <para>The skill ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ski-04pomiln*************j0</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        /// <summary>
        /// <para>The skill name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data-query-skill</para>
        /// </summary>
        [NameInMap("SkillName")]
        [Validation(Required=false)]
        public string SkillName { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b5u96hud*************gq3</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
