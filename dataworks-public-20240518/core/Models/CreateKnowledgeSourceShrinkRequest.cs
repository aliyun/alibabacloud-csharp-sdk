// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeSourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source-create-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The data source configuration. This parameter is required when Type is set to DATA_SOURCE.</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSourceShrink { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and policy documents</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The document configuration. This parameter is required when Type is set to DOCUMENT.</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public string DocumentShrink { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The name of the source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales topic project</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The project configuration. This parameter is required when Type is set to PROJECT.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string ProjectShrink { get; set; }

        /// <summary>
        /// <para>The type of the knowledge source. Valid values: PROJECT, DATA_SOURCE, and DOCUMENT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROJECT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
