// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateSkillRequest : TeaModel {
        /// <summary>
        /// <para>The content of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MySQL&quot;: &quot;MySQL 优化指南...&quot;,&quot;PostgreSQL&quot;: &quot;PostgreSQL 优化指南...&quot;}</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        /// <summary>
        /// <para>The list of database engines.</para>
        /// </summary>
        [NameInMap("Dbtypes")]
        [Validation(Required=false)]
        public List<string> Dbtypes { get; set; }

        /// <summary>
        /// <para>The description of the Skill. It can be up to 1000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL审查专家：全面审核SQL的安全性、性能与规范性，识别风险并提供优化建议。用户提交SQL或询问“SQL审核”“SQL Review”“有风险吗”“如何优化”时，立即启用。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the skill, which can contain only lowercase letters, numbers, and hyphens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sql-optimization</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique identifier of the skill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8f6a2111-3828-4a9f-a3ce-51ce73c6****</para>
        /// </summary>
        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

    }

}
