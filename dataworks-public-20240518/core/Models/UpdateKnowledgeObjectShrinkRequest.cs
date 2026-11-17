// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateKnowledgeObjectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token. This parameter is supported only for DOCUMENT. Model updates do not guarantee exactly-once remote save notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edit-document-text-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The typed content update. Object properties are submitted as needed. Arrays are replaced in their entirety when submitted. Unspecified properties are retained.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para>The new description. An empty string clears the description. If this parameter is not specified, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Actual paid amount</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expected modification time. This parameter is supported only for DOCUMENT. It is required when modifying the body text and optional when modifying metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1790200800000</para>
        /// </summary>
        [NameInMap("ExpectedModifyTime")]
        [Validation(Required=false)]
        public long? ExpectedModifyTime { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base to which the object belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The stable knowledge object ID returned by the Get or List operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>obj-model-001</para>
        /// </summary>
        [NameInMap("KnowledgeObjectId")]
        [Validation(Required=false)]
        public string KnowledgeObjectId { get; set; }

        /// <summary>
        /// <para>The new name. This parameter cannot be empty. If this parameter is not specified, the original value is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>orders</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The upload ID. This parameter is supported only for SEMANTIC_MODEL. It replaces the public model content with a complete YAML file and is mutually exclusive with Content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abd</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// <para>The version number. This parameter is required when updating Content or UploadId for SEMANTIC_MODEL. Use the VersionNo returned by the Get operation. This is not an optimistic lock.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VersionNo")]
        [Validation(Required=false)]
        public long? VersionNo { get; set; }

    }

}
