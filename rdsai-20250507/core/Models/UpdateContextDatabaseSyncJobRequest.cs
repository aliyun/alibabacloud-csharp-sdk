// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class UpdateContextDatabaseSyncJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sync-connection-20260923-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;include&quot;:[&quot;/研发文档/<b>&quot;],&quot;exclude&quot;:[&quot;/归档文档/</b>&quot;],&quot;excludedDocumentIds&quot;:[],&quot;sizeLimit&quot;:2147483648,&quot;typeAllowlist&quot;:[&quot;docx&quot;,&quot;pdf&quot;]}</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Filters { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>研发团队文档导入</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id-001</para>
        /// </summary>
        [NameInMap("TargetKnowledgeBaseId")]
        [Validation(Required=false)]
        public string TargetKnowledgeBaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例名称</para>
        /// </summary>
        [NameInMap("TargetKnowledgeBaseName")]
        [Validation(Required=false)]
        public string TargetKnowledgeBaseName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-as1llqmkol****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
