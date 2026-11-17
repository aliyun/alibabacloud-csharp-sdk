// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeSourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The complete configuration for Type=DATA_SOURCE.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSourceShrink { get; set; }

        /// <summary>
        /// <para>The new description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and policy documents</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The complete configuration for Type=DOCUMENT. Credentials are not returned after they are written.</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public string DocumentShrink { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base to which the source belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The new name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales Project</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The complete configuration for Type=PROJECT.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string ProjectShrink { get; set; }

        /// <summary>
        /// <para>The source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>src-001</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

    }

}
