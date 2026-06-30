// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateSkillResponseBody : TeaModel {
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
        /// <para>The description of the skill. It can be up to 1000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL审查专家：全面审核SQL的安全性、性能与规范性，识别风险并提供优化建议。用户提交SQL或询问“SQL审核”“SQL Review”“有风险吗”“如何优化”时，立即启用。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The unique identifier of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d1b7d639-f34e-44c7-8231-987da14d****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the skill, which can contain only lowercase letters, numbers, and hyphens.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sql-review</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE9C65D7-930F-57A5-A207-8C396329****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The skill type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("SkillType")]
        [Validation(Required=false)]
        public string SkillType { get; set; }

        /// <summary>
        /// <para>The update time of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-02-04T21:14:45Z</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
