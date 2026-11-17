// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateKnowledgeObjectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token for the creation request. Keep the original request unchanged when retrying.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create-document-001</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Only Content.Document is supported. It includes Text and ContentFormat (MARKDOWN or TEXT).</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// <para>The document description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sales metrics and policy document</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the target knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abc</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The document name. Existing objects are not overwritten based on the name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business description</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the object. For this operation, the value is fixed to DOCUMENT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOCUMENT</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the completed PUT upload session for this knowledge base. This parameter is mutually exclusive with Content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-4234-8234-123456789abd</para>
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
